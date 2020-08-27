using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferramentas;
using DAO;

namespace GUI
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup File|*.back";
                d.ShowDialog();                                                                             
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDeConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDeConexao.servidor + "Initial Catalog=master;User=" +
                    DadosDeConexao.usuario + "Password=" + DadosDeConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado com sucesso!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup File|*.back";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDeConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDeConexao.servidor + "Initial Catalog=master;User=" +
                    DadosDeConexao.usuario + "Password=" + DadosDeConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup restaurado com sucesso!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
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
