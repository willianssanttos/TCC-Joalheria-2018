using DAO;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
      

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçaoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguraçaoBancoDados f = new frmConfiguraçaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            //verifica conexao com o banco
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDeConexao.servidor = arquivo.ReadLine();
                DadosDeConexao.banco = arquivo.ReadLine();
                DadosDeConexao.usuario = arquivo.ReadLine();
                DadosDeConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDeConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
                catch(SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                    "Acesse as configurações do banco de dados e informe os parâmetros de conexão");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDeDados f = new frmBackupBancoDeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void formaPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoCompra f = new frmMovimentacaoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra f = new frmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoVenda f = new frmMovimentacaoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario f = new frmCadastroFuncionario();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebimentoVenda f = new frmRecebimentoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void nivelDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroNivelAcesso f = new frmCadastroNivelAcesso();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto f = new frmRelatorioProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
