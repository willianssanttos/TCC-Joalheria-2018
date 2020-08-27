using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmFerramentas : Form
    {
        public frmFerramentas()
        {
            InitializeComponent();
            AbrirForms(new frmBackupBancoDeDados());
            labelTitle.Text = "Backup do Banco de Dados";
        }

        private void AbrirForms(object forms)
        {
            if (this.pnCadastros.Controls.Count > 0)
                this.pnCadastros.Controls.RemoveAt(0);
            Form fh = forms as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnCadastros.Controls.Add(fh);
            this.pnCadastros.Tag = fh;
            fh.Show();
        }

        private void backup_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmBackupBancoDeDados());
            labelTitle.Text = "Backup do Banco de Dados";
        }

        private void conf_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmConfiguraçaoBancoDados());
            labelTitle.Text = "Configuração do Banco de Dados";
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
