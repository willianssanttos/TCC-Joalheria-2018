using BLL;
using DAO;
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
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        
        public frmConsultaCliente()
        {
            InitializeComponent();
        }
                
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
             btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Tipo";
            dgvDados.Columns[1].Width = 60;
            dgvDados.Columns[2].HeaderText = "Data Cadastro";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Nome";
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "RG/IE";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Data Nascimento";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Sexo";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[8].HeaderText = "Razao Social";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "CEP";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "logradouro";
            dgvDados.Columns[10].Width = 88;
            dgvDados.Columns[11].HeaderText = "Bairro";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "Telefone";
            dgvDados.Columns[12].Width = 75;
            dgvDados.Columns[13].HeaderText = "Celular";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[14].HeaderText = "Email";
            dgvDados.Columns[14].Width = 100;
            dgvDados.Columns[15].HeaderText = "Número";
            dgvDados.Columns[15].Width = 100;
            dgvDados.Columns[16].HeaderText = "Cidade";
            dgvDados.Columns[16].Width = 100;
            dgvDados.Columns[17].HeaderText = "Estado";
            dgvDados.Columns[17].Width = 100;
            
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCPFCNPJ(txtValor.Text);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
