using BLL;
using DAO;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfiguraçaoBancoDados : Form
    {
        public frmConfiguraçaoBancoDados()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo Atualizado com sucesso!!!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            this.Close();
        }

        private void frmConfiguraçaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, this.txtServidor.ToString());

                /* //Carregar as Permissões do usuário
                 perInserir = Convert.ToBoolean(tabela.Rows[0][5]);
                 perAlterar = Convert.ToBoolean(tabela.Rows[0][6]);
                 perExcluir = Convert.ToBoolean(tabela.Rows[0][7]);
                 perImprimir = Convert.ToBoolean(tabela.Rows[0][8]);

                 this.alteraBotoes(1, perInserir, perAlterar, perExcluir, perImprimir);*/
            }
            catch
            {

            }
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDeConexao.servidor = txtServidor.Text;
                DadosDeConexao.banco = txtBanco.Text;
                DadosDeConexao.usuario = txtUsuario.Text;
                DadosDeConexao.senha = txtSenha.Text;
               
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDeConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com secesso");
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                    "Verifique os dados informados");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconeencerar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
