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
    public partial class frmConsultaFuncionario : Form
    {
        public int codigo = 0;

        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Data Cadastro";
            dgvDados.Columns[1].Width = 90;
            dgvDados.Columns[2].HeaderText = "Nome";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Data Nascimento ";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "CPF";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "RG";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Sexo";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Telefone";
            dgvDados.Columns[7].Width = 88;
            dgvDados.Columns[8].HeaderText = "Celular";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Email";
            dgvDados.Columns[9].Width = 75;
            dgvDados.Columns[10].HeaderText = "Escolaridade";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[11].HeaderText = "Data Admissão";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "Cargo ou Função";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Cep";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[14].HeaderText = "Logradouro";
            dgvDados.Columns[14].Width = 100;
            dgvDados.Columns[15].HeaderText = "Bairro";
            dgvDados.Columns[15].Width = 100;
            dgvDados.Columns[16].HeaderText = "Cidade";
            dgvDados.Columns[16].Width = 100;
            dgvDados.Columns[17].HeaderText = "Estado";
            dgvDados.Columns[17].Width = 100;
            dgvDados.Columns[18].HeaderText = "Número";
            dgvDados.Columns[18].Width = 100;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLFuncionario bll = new BLLFuncionario(cx);
            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCPF(txtValor.Text);
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

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
