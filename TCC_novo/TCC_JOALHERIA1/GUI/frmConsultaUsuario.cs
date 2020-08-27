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

namespace GUI
{
    public partial class frmConsultaUsuario : Form
    {
        public int codigo = 0;

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);         
        }

        public void AtualizaCabeçalhoDGridUsuario()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Login";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Grupo";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "Senha";
            dgvDados.Columns[4].Width = 90;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
            this.AtualizaCabeçalhoDGridUsuario();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
