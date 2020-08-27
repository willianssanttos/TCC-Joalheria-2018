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
    public partial class frmCadastroCategoria : GUI.frmModeloCategoria
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        //Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, this.txtNome.ToString());

                //Carregar as Permissões do usuário
               
                this.alteraBotoes(1);
            }
            catch
            {

            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                txtNome.Text = modelo.CatNome;
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
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CatCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CatCod = Convert.ToInt32(txtCodigo.Text);
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
                    BLLCategoria bll = new BLLCategoria(cx);
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

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
