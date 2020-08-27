using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frmMovimentacaoEstoque : Form
    {
        public frmMovimentacaoEstoque()
        {
            InitializeComponent();
            AbrirForms(new frmCadastroFornecedor());
            labelTitle.Text = "Cadastro de Fornecedor";
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

        private void cadFornecedor_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmCadastroFornecedor());
            labelTitle.Text = "Cadastro de Fornecedor";
        }

        private void cadProduto_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmCadastroProduto());
            labelTitle.Text = "Cadastro de Produto";
        }

        private void cadCategoria_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmCadastroCategoria());
            labelTitle.Text = "Cadastro de Categoria";
        }

        private void cadSub_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmCadastroSubCategoria());
            labelTitle.Text = "Cadastro de SubCategoria";
        }

        private void cadUnidade_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmCadastroUnidadeDeMedida());
            labelTitle.Text = "Cadastro de Unidade de Medida";
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; 
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        private void frmMovimentacaoEstoque_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
