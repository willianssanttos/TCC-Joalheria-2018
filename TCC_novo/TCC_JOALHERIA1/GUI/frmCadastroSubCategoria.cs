using BLL;
using DAO;
using Ferramentas;
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
    public partial class frmCadastroSubCategoria : GUI.frmModeloCategoria
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtNome.Clear();
            txtScatCod.Clear();
        }
        //Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

        private void frmSubCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, this.txtNome.ToString());
                                
                BLLCategoria bllc = new BLLCategoria(cx);
                cbCatCod.DataSource = bllc.loadComboBox();
                cbCatCod.DisplayMember = "cat_nome";
                cbCatCod.ValueMember = "cat_cod";

                this.alteraBotoes(1);
            }
            catch
            {

            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCod.Text);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCod.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                cbCatCod.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
          //  cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {
          //  frmSubCategoria_Load(sender, e);
        }

    }
}
