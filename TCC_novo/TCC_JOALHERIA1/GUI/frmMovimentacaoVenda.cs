using BLL;
using DAO;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMovimentacaoVenda : GUI.frmModeloCategoria
    {
        public double totalVenda = 0; 

        public frmMovimentacaoVenda()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtVenCodigo.Clear();
            txtNFiscal.Clear();
            txtCliCod.Clear();
            txtCodPro.Clear();
            lProduto.Text = "Informe o codigo do produto ou clique em localizar";
            txtQtd.Clear();
            txtValor.Clear();
            txtTotalVenda.Text = "0,00";
            dgvItens.Rows.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTpagto.SelectedIndex = 0;
            lbMsg.Visible = false;
           
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalVenda = 0;
            this.alteraBotoes(2);
            cbNParcelas.SelectedIndex = 0;
            cbVendaAVista.Checked = false;
        }

        private void btLocCli_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                txtCliCod_Leave(sender, e);
            }
        }

        private void txtCliCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(Convert.ToInt32(txtCliCod.Text));
                if (modelo.CliCod <= 0)
                {
                    txtCliCod.Clear();
                    lCliente.Text = "Informe o código do cliente ou clique em Localizar";
                }
                else lCliente.Text = modelo.CliNome;
            }
            catch
            {
                txtCliCod.Clear();
                lCliente.Text = "Informe o código do cliente ou clique em Localizar";
            }
        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCodPro.Text = f.codigo.ToString();
                txtCodPro_Leave(sender, e);
            }
        }

        private Double VerificaQuantidadeDeProdutosEmEstoque(int ProCod)
        {
            Double QtdeEmEstoque = 0;
            try
            {
                //O que tem no bando de dados
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(ProCod);
                QtdeEmEstoque = modelo.ProQtde;
                //verifica produtos na grid
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    if (Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value) == ProCod)
                    {
                        QtdeEmEstoque = QtdeEmEstoque - Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                    }
                }
                
            }
            catch
            {

            }
            return QtdeEmEstoque;
        }

        private void txtCodPro_Leave(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodPro.Text));
                lProduto.Text = modelo.ProNome;
                txtQtd.Text = "1";
                txtValor.Text = modelo.ProValorVenda.ToString();
            }
            catch
            {
                txtCodPro.Clear();
                lProduto.Text = "Informe o codigo do produto ou clique em localizar";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            Double Qtde = 0;
            try
            {
                if ((txtCodPro.Text != "") && (txtQtd.Text != "") && (txtValor.Text != ""))
                {
                       Qtde = VerificaQuantidadeDeProdutosEmEstoque(Convert.ToInt32(txtCodPro.Text ));
                        if (Convert.ToDouble(txtQtd.Text) > Qtde)
                        {
                            MessageBox.Show("Quantidade de produtos indisponivel.\n Você possui "+Qtde+
                                "unidades em estoque");
                            return;
                        }
                    
                    Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValor.Text); //Metodo para calcular a compra
                    this.totalVenda = this.totalVenda + TotalLocal; //Metodo para somar o total da compra
                    String[] i = new String[] { txtCodPro.Text, lProduto.Text, txtQtd.Text, txtValor.Text, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(i); //adicionando o string dentro da datagrid

                    txtCodPro.Clear(); //limpar o campo
                    lProduto.Text = "Informe o codigo do produto ou clique em localizar";
                    txtQtd.Clear(); //limpar o campo
                    txtValor.Clear(); //limpar o campo

                    txtTotalVenda.Text = this.totalVenda.ToString(); //atualizar o total da compra
                }
            }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referente ao valor e quantidade do produto ");
            }
        }

        private void frmMovimentacaoVenda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

        private void cbVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if(cbVendaAVista.Checked == true)
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
            }
            else
            {
                cbNParcelas.Enabled = true;
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //validar os dados da venda
            try
            {
                if (Convert.ToInt32(txtCliCod.Text) <=0)
                {
                    MessageBox.Show("Informe um código válido para o cliente");
                    return;
                }

                if (Convert.ToInt32(txtNFiscal.Text) <=0)
                {
                    MessageBox.Show("Informe o número válido para a nota fiscal");
                    return;
                }

                if (totalVenda <= 0)
                {
                    MessageBox.Show("Insira itens em sua venda para continuar...");
                    return;
                }
                    dgvParcelas.Rows.Clear();
                    int parcelas = Convert.ToInt32(cbNParcelas.Text);
                    Double totallocal = Convert.ToDouble(txtTotalVenda.Text);
                    double valor = totallocal / parcelas;
                    DateTime dt = new DateTime();
                    dt = dtDataini.Value;
                    lbTotal.Text = this.totalVenda.ToString();
                    for (int i = 1; i <= parcelas; i++)
                    {
                        String[] k = new String[] { i.ToString(), valor.ToString(), dt.Date.ToString() };
                        this.dgvParcelas.Rows.Add(k);
                        if (dt.Month != 12)
                        {
                            dt = new DateTime(dt.Year, dt.Month + 1, dt.Day);
                        }
                        else
                        {
                            dt = new DateTime(dt.Year + 1, 1, dt.Day);
                        }
                    }
                    pnFinalizaVenda.Visible = true;
                }
            catch
            {
                MessageBox.Show("Verifique os campos da tela de venda");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnFinalizaVenda.Visible = false;
        }

        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloVenda modeloVenda = new ModeloVenda();
                modeloVenda.VenData = dtDataVenda.Value;
                modeloVenda.VenNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloVenda.VenNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloVenda.VenStatus = "ativa";
                modeloVenda.VenTotal = this.totalVenda;
                modeloVenda.CliCod = Convert.ToInt32(txtCliCod.Text);
                modeloVenda.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);
                if(cbVendaAVista.Checked == true)
                {
                    modeloVenda.VenAvista = 1;
                }
                else 
                {
                    modeloVenda.VenAvista = 0;
                }
               

                //obj para gravar os dados no banco
                BLLVenda bll = new BLLVenda(cx);

                ModeloItensVenda mitens = new ModeloItensVenda();
                BLLItensVenda bitens = new BLLItensVenda(cx);

               ModeloParcelasVenda mparcelas = new ModeloParcelasVenda();
               BLLParcelasVenda bparcelas = new BLLParcelasVenda(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloVenda);
                    //cadastrar os intens da venda 
                    
                    for (int i = 0; i < dgvItens.RowCount; i++ )
                    {
                        mitens.ItvCod = i + 1;
                        mitens.VenCod = modeloVenda.VenCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItvQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItvValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }
                    //inserir os itens na tabela de parcelas venda 
                    
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.VenCod = modeloVenda.VenCod;
                        mparcelas.PveCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PveValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PveDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                     
                    MessageBox.Show("Venda efetuado: Código " + modeloVenda.VenCod.ToString());

                }
                this.LimpaTela();
                pnFinalizaVenda.Visible = false;
                this.alteraBotoes(1);
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelarTransacao();
                cx.Desconectar();
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtVenCodigo.Text = modelo.VenCod.ToString();
                txtNFiscal.Text = modelo.VenNFiscal.ToString();
                dtDataVenda.Value = modelo.VenData;
                txtCliCod.Text = modelo.CliCod.ToString();
                txtCliCod_Leave(sender, e); //para escrever o nome do cliente na tela
                cbTpagto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.VenNParcelas.ToString();
                if(modelo.VenAvista == 1)
                {
                    cbVendaAVista.Checked = true;
                }
                else
                {
                    cbVendaAVista.Checked = false;
                }
                txtTotalVenda.Text = modelo.VenTotal.ToString();
                this.totalVenda = modelo.VenTotal; //armazenar o valor total da venda

                //itens da venda
                BLLItensVenda bllItens = new BLLItensVenda(cx);
                DataTable tabela = bllItens.Localizar(modelo.VenCod);
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itv_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itv_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itv_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itv_valor"]);
                    String[] it = new String[] { icod, inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

                this.alteraBotoes(3);
                lbMsg.Visible = false;
                if(modelo.VenStatus != "ativa")
                {
                    //lbMsg.Text = "Venda Cancelada";
                    lbMsg.Visible = true;
                    btExcluir.Enabled = false;
                }
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //implementar o cancelamento da venda
            //alterar o campo status da tabela venda
            //retornar os itens para o estoque 
            //devolver o dinheiro para o comprador
           
            DialogResult d = MessageBox.Show("Deseja cancelar o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                if (bll.CancelarVenda(Convert.ToInt32(txtVenCodigo.Text)) == true)
                {
                    MessageBox.Show("Venda Cancelada");
                }
                else
                {
                    MessageBox.Show("Não foi possivel cancelar a avenda. \nContate o seu desenvolvedor");
                }
            }
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItens_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodPro.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString();
            }
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtCliCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
