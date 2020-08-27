using BLL;
using DAO;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferramentas;

namespace GUI
{
    public partial class frmCaixaDeFrente : Form
    {
        public double totalVenda = 0;
        public String operacao;
        public frmCaixaDeFrente()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

        private void frmCaixaDeFrente_Load(object sender, EventArgs e)
        {
            lblnome.Text = SessaoUsuario.Session.Instance.UsuNome;
            lblseja.Text = "SEJA BEM VINDO!";
            txtCodPro.Focus();
            timer1.Enabled = true;

            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void topo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodPro_KeyUp(object sender, KeyEventArgs e)
        {
            try
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodPro.Text));
                    lblseja.Text = modelo.ProNome;
                    lblQuantidade.Text = "1";
                    lblValor.Text = modelo.ProValorVenda.ToString();
                    lblSub.Text = modelo.ProValorVenda.ToString();
                }
                catch
                {
                    txtCodPro.Clear();
                    lblQuantidade.Text = "";
                    lblValor.Text = "";
                    lblSub.Text = "";
                    lblseja.Text = "SEJA BEM VINDO!";
                }

        }

        private void frmCaixaDeFrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Double Qtde = 0;
                try
                {
                    if ((txtCodPro.Text != "") && (lblQuantidade.Text != "") && (lblValor.Text != ""))
                    {
                        Qtde = VerificaQuantidadeDeProdutosEmEstoque(Convert.ToInt32(txtCodPro.Text));
                        if (Convert.ToDouble(lblQuantidade.Text) > Qtde)
                        {
                            MessageBox.Show("Quantidade de produtos indisponivel.\n Você possui " + Qtde +
                                "unidades em estoque");
                            return;
                        }

                        Double TotalLocal = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblValor.Text); //Metodo para calcular a compra
                        this.totalVenda = this.totalVenda + TotalLocal; //Metodo para somar o total da compra
                        String[] i = new String[] { txtCodPro.Text, lblseja.Text, lblQuantidade.Text, lblValor.Text, TotalLocal.ToString() };
                        this.dgvItens.Rows.Add(i); //adicionando o string dentro da datagrid

                        txtCodPro.Clear(); //limpar o campo
                        lblseja.Text = "SEJA BEM VINDO!";
                        lblQuantidade.Text = "";
                        lblValor.Text = "";
                        lblSub.Text = "";
                        

                        txtTotalVenda.Text = this.totalVenda.ToString("c"); //atualizar o total da compra
                    }
                }
                catch
                {
                    MessageBox.Show("Informe apenas o código do produto no campo referente ao código! ");
                }        
            }
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodPro.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblseja.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblQuantidade.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
               //lblSub.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalVenda = this.totalVenda - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalVenda.Text = this.totalVenda.ToString("c");
            }
        }

        private void frmCaixaDeFrente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                panelCli.Visible = true;
            }
          
            if (e.KeyCode == Keys.F2)
            {
                panelPagamento.Visible = true;
                /* var frm = new frmFormaDePagamento(lblTotalVenda.Text);
                frm.Show();*/
            }
            else
            {
                panelPagamento.Visible = false;
            }
            
        }

        private void iconeminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconerestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            //iconerestaurar.Visible = false;
            //iconemaxizar.Visible = true;
        }

        int LX, LY, SW, SH;
        private void iconemaxizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
           // iconerestaurar.Visible = true;
            //iconemaxizar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                if (cbVendaAVista.Checked == true)
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

                    for (int i = 0; i < dgvItens.RowCount; i++)
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
               // this.LimpaTela();
               // pnFinalizaVenda.Visible = false;
               // this.alteraBotoes(1);
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

        private void btnExcluir_Click(object sender, EventArgs e)
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
/*
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
                if (modelo.VenAvista == 1)
                {
                    cbVendaAVista.Checked = true;
                }
                else
                {
                    cbVendaAVista.Checked = false;
                }
                lblTotalVenda.Text = modelo.VenTotal.ToString();
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
                if (modelo.VenStatus != "ativa")
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
            f.Dispose();*/
            
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
                   
                }
                //else txtCliCod.Text = modelo.CliCod;
            }
            catch
            {
                txtCliCod.Clear();
            }
        }

        private void cbVendaAVista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendaAVista.Checked == true)
            {
                cbNParcelas.SelectedIndex = 0;
                cbNParcelas.Enabled = false;
            }
            else
            {
                cbNParcelas.Enabled = true;
            }
        }   
    }
}
