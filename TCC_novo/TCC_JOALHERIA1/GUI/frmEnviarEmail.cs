using Ferramentas;
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
    public partial class frmEnviarEmail : Form
    {
        public frmEnviarEmail()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtPara.Clear();
            txtAssunto.Clear();
            txtAnexar.Clear();
            txtMensagem.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmail classe = new EnviarEmail();
            classe.email(txtPara.Text, txtAssunto.Text, txtMensagem.Text, txtAnexar.Text);

            if(EnviarEmail.teste == true)
            {
                MessageBox.Show("Email enviado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Erro ao enviar o email!!!");
            }
            this.LimpaTela();
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if(open.ShowDialog() == DialogResult.OK)
            {
                txtAnexar.Text = open.FileName;
            }
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
