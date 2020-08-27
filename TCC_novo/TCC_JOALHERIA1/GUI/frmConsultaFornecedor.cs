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
    public partial class frmConsultaFornecedor : Form
    {
        public int codigo = 0;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Data Cadastro";
            dgvDados.Columns[1].Width = 90;
            dgvDados.Columns[2].HeaderText = "Nome";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Razão Social ";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "IE";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "CNPJ";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "CEP";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "logradouro";
            dgvDados.Columns[7].Width = 88;
            dgvDados.Columns[8].HeaderText = "Bairro";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Telefone";
            dgvDados.Columns[9].Width = 75;
            dgvDados.Columns[10].HeaderText = "Celular";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[11].HeaderText = "Email";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "Número";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Cidade";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[14].HeaderText = "Estado";
            dgvDados.Columns[14].Width = 100;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCNPJ(txtValor.Text);
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
    }
}
