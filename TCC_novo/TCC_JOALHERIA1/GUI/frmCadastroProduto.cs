using BLL;
using DAO;
using Ferramentas;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroProduto : GUI.frmModeloCategoria
    {
        public string foto = "";
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtQtde.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtDescricao.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }
        Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, this.txtNome.ToString());

                    BLLCategoria cbll = new BLLCategoria(cx);
                    cbCategoria.DataSource = cbll.loadComboBox();
                    cbCategoria.DisplayMember = "cat_nome";
                    cbCategoria.ValueMember = "cat_cod";
                try
                {
                    //combo da subcategoria
                    BLLSubCategoria sbll = new BLLSubCategoria(cx);
                    cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                    cbSubCategoria.DisplayMember = "scat_nome";
                    cbSubCategoria.ValueMember = "scat_cod";
                }
                catch
                {
                    //MessageBox.Show("Cadastre uma categoria");
                }
                //combo und medida
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
                cbUnd.DataSource = ubll.Localizar("");
                cbUnd.DisplayMember = "umed_nome";
                cbUnd.ValueMember = "umed_cod";

                this.alteraBotoes(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(".") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 )
            {
                e.Handled = true;
            }
           
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQtde.Text) > 1)
            {
                MessageBox.Show("OPPSSS!!!!!! \n \n Quantidade excedida, Permitido apenas 1 produto", "DUPLICIDADE DE REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo da categoria
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            try
            {
                cbSubCategoria.Text = "";
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProData = dtCadastro.Value;
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);
                modelo.UmedCod = Convert.ToInt32(cbUnd.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                
                
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma produto
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());

                }
                else
                {
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    //alterar um produto
                    if (this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodigo.Text = modelo.ProCod.ToString();
                //colocar os dados na tela
                txtCodigo.Text = modelo.ProCod.ToString();
                dtCadastro.Value = modelo.ProData;
                txtNome.Text = modelo.ProNome;
                txtDescricao.Text = modelo.ProDescricao;
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUnd.SelectedValue = modelo.UmedCod;
                //carregar a foto na tela
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch {}
                
                txtValorPago_Leave(sender, e);
                txtValorVenda_Leave(sender, e);
                this.alteraBotoes(3);
               
                
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto f = new frmRelatorioProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            /*if (this.operacao == "inserir" || this.operacao == "Alterar")
            {
                int r = 0;
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                r = bll.VerificaSeJaExiste(txtNome.Text);
                if (r > 0)
                {
                    MessageBox.Show("OPPSSS!!!!!! \n \n Já existe um Produto registrado. ", "DUPLICIDADE DE REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    return;
                }
            }  */       
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {
         //   frmCadastroProduto_Load(sender, e);
        }

        
    }
}
