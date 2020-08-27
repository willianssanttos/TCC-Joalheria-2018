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
    public partial class frmMovimentacaoCompra : GUI.frmModeloCategoria
    {
        public double totalCompra = 0;

        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtComCodigo.Clear();
            txtNFiscal.Clear();
            txtForCod.Clear();
            txtCodPro.Clear();
            lProduto.Text = "Informe o codigo do produto ou clique em localizar";
            txtQtd.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
            cbNParcelas.SelectedIndex = 0;
            cbTpagto.SelectedIndex = 0;
       
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtComCodigo.Text = modelo.ComCod.ToString();
                txtNFiscal.Text = modelo.ComNFiscal.ToString();
                dtDataCompra.Value = modelo.ComData;
                txtForCod.Text = modelo.ForCod.ToString();
                txtForCod_Leave(sender, e); //para escrever o nome do fornecedor na tela
                cbTpagto.SelectedValue = modelo.TpaCod;
                cbNParcelas.Text = modelo.ComNParcelas.ToString();
                txtTotalCompra.Text = modelo.ComTotal.ToString();
                this.totalCompra = modelo.ComTotal; //armazenar o valor total da compra
                
                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                DataTable tabela = bllItens.Localizar(modelo.ComCod);
                for (int i = 0; i < tabela.Rows.Count; i++ )
                {
                    string icod = tabela.Rows[i]["pro_cod"].ToString();
                    string inome = tabela.Rows[i]["pro_nome"].ToString();
                    string iqtd = tabela.Rows[i]["itc_qtde"].ToString();
                    string ivu = tabela.Rows[i]["itc_valor"].ToString();
                    Double TotalLocal = Convert.ToDouble(tabela.Rows[i]["itc_qtde"]) * Convert.ToDouble(tabela.Rows[i]["itc_valor"]);              
                    String[] it = new String[] { icod , inome, iqtd, ivu, TotalLocal.ToString() };
                    this.dgvItens.Rows.Add(it);
                }

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
            
             
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtComCodigo.Text);
            int qtde = Convert.ToInt32(cbNParcelas.Text);
            //conexao eo bll da compra
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLCompra bllc = new BLLCompra(cx);
            qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
            if (qtde == 0) //paguei alguma parcela
            {
                this.operacao = "alterar";
                this.alteraBotoes(2);
            }
            else
            {
                MessageBox.Show("Impossível Alterar o registro. \n O registro possui parcelas pagas.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    int codigo = Convert.ToInt32(txtComCodigo.Text);
                    int qtde = Convert.ToInt32(cbNParcelas.Text);
                    //conexao eo bll da compra
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLCompra bllc = new BLLCompra(cx);
                    qtde -= bllc.QuantidadeParcelasNaoPagas(codigo);
                    if(qtde == 0) //paguei alguma parcela
                    {
                        cx.Conectar();
                        cx.IniciarTransacao();
                        try { 
                        //excluir as parcelas da compra
                        BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                        bllp.ExcluirTodasAsParcelas(codigo);
                        //itens da compra
                        BLLItensCompra blli = new BLLItensCompra(cx);
                        blli.ExcluirTodosOsItens(codigo);
                        //compra
                        bllc.Excluir(codigo);
                        MessageBox.Show("Compra excluida.");
                        cx.TerminarTransacao();
                        cx.Desconectar();
                        
                        this.LimpaTela();
                        this.alteraBotoes(1);
                        
                        }
                        catch(Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            cx.CancelarTransacao();
                            cx.Desconectar();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Impossível excluir o registro. \n O registro possui parcelas pagas.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
             
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(txtNFiscal.Text == "")
            {
                MessageBox.Show("Informe número da nota fiscal da compra");
                return;
            }
            if(txtForCod.Text == "")
            {
                MessageBox.Show("Informe um fornecedor para a compra");
                return;
            }
            if(this.totalCompra <= 0) //validação dos itens
            {
                MessageBox.Show("Informe os produtos dessa compra");
                return;
            }

            dgvParcelas.Rows.Clear();
            int parcelas = Convert.ToInt32(cbNParcelas.Text);
            Double totallocal = Convert.ToDouble(txtTotalCompra.Text);
            double valor = totallocal / parcelas; 
            DateTime dt = new DateTime();
            dt = dtDataini.Value;
            lbTotal.Text = this.totalCompra.ToString();
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
            pnFinalizaCompra.Visible = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;

        }

        private void frmMovimentacaoCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {
            
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                txtForCod_Leave(sender, e); 
                //chamada do metodo do txtforcod
            }
        }

        private void txtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                if (modelo.ForCod <= 0)
                {
                    txtForCod.Clear();
                    lFornecedor.Text = "Informe o código do fornecedor ou clique em Localizar";
                }
                else lFornecedor.Text = modelo.ForNome;
            }
            catch
            {
                txtForCod.Clear();
                lFornecedor.Text = "Informe o código do fornecedor ou clique em Localizar";
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
                //chamada do metodo do txtforcod
            }
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
            try { 
            if ((txtCodPro.Text != "") && (txtQtd.Text !="") && (txtValor.Text != ""))
            {
                Double TotalLocal = Convert.ToDouble(txtQtd.Text) * Convert.ToDouble(txtValor.Text); //Metodo para calcular a compra
                this.totalCompra = this.totalCompra + TotalLocal; //Metodo para somar o total da compra
                String[] i = new String[] { txtCodPro.Text, lProduto.Text, txtQtd.Text, txtValor.Text, TotalLocal.ToString() };
                this.dgvItens.Rows.Add(i); //adicionando o string dentro da datagrid

                txtCodPro.Clear(); //limpar o campo
                lProduto.Text = "Informe o codigo do produto ou clique em localizar";
                txtQtd.Clear(); //limpar o campo
                txtValor.Clear(); //limpar o campo

                txtTotalCompra.Text = this.totalCompra.ToString(); //atualizar o total da caompra
            }
            
         }
            catch
            {
                MessageBox.Show("Informe apenas números nos campos referente ao valor e quantidade do produto ");
            }
       }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodPro.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtd.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }

        private void btCancelarFinal_Click(object sender, EventArgs e)
        {
            pnFinalizaCompra.Visible = false;
        }

        private void btSalvarFinal_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //leitura dos dados
                ModeloCompra modeloCompra = new ModeloCompra();
                modeloCompra.ComData = dtDataCompra.Value;
                modeloCompra.ComNFiscal = Convert.ToInt32(txtNFiscal.Text);
                modeloCompra.ComNParcelas = Convert.ToInt32(cbNParcelas.Text);
                modeloCompra.ComStatus = "ativa";
                modeloCompra.ComTotal = this.totalCompra;
                modeloCompra.ForCod = Convert.ToInt32(txtForCod.Text);
                modeloCompra.TpaCod = Convert.ToInt32(cbTpagto.SelectedValue);
               

                //obj para gravar os dados no banco
                BLLCompra bll = new BLLCompra(cx);

                ModeloItensCompra mitens = new ModeloItensCompra();
                BLLItensCompra bitens = new BLLItensCompra(cx);

                ModeloParcelasCompra mparcelas = new ModeloParcelasCompra();
                BLLParcelasCompra bparcelas = new BLLParcelasCompra(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma compra
                    bll.Incluir(modeloCompra);
                    //cadastrar os intens da compras 
                    for (int i = 0; i < dgvItens.RowCount; i++ )
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }
                    //inserir os itens na tabela de parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }
                    //cadastrar as parcelas da compra
                    MessageBox.Show("Compra efetuado: Código " + modeloCompra.ComCod.ToString());

                }
                else
                {
                    //alterar uma compra
                    modeloCompra.ComCod = Convert.ToInt32(txtComCodigo.Text);
                    bll.Alterar(modeloCompra);

                    bitens.ExcluirTodosOsItens(modeloCompra.ComCod);

                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        mitens.ItcCod = i + 1;
                        mitens.ComCod = modeloCompra.ComCod;
                        mitens.ProCod = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        mitens.ItcQtde = Convert.ToDouble(dgvItens.Rows[i].Cells[2].Value);
                        mitens.ItcValor = Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value);
                        bitens.Incluir(mitens);
                    }

                    bparcelas.ExcluirTodasAsParcelas(modeloCompra.ComCod);
                    //inserir os itens na tabela de parcelas compra
                    for (int i = 0; i < dgvParcelas.RowCount; i++)
                    {
                        mparcelas.ComCod = modeloCompra.ComCod;
                        mparcelas.PcoCod = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value);
                        mparcelas.PcoValor = Convert.ToDouble(dgvParcelas.Rows[i].Cells[1].Value);
                        mparcelas.PcoDataVecto = Convert.ToDateTime(dgvParcelas.Rows[i].Cells[2].Value);
                        bparcelas.Incluir(mparcelas);
                    }


                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                pnFinalizaCompra.Visible = false;
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

        private void txtNFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
