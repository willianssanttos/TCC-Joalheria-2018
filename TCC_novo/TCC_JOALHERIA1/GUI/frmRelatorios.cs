using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
            AbrirForms(new frmRelatorioProduto());
            labelTitle.Text = "Relatório Produto";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

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

        private void reEstoque_Click(object sender, EventArgs e)
        {
            
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            iconerestaurar.Visible = true;
            iconemaxizar.Visible = false; 
        }

        private void iconerestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconerestaurar.Visible = false;
            iconemaxizar.Visible = true;
        }

        private void iconeminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pagaCompra_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmRelatorioProduto());
            labelTitle.Text = "Relatório de Produto";
        }

        private void pagaRecebe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
