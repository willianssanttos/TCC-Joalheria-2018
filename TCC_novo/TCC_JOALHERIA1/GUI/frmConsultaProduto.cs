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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Unidade de Medida";
            dgvDados.Columns[1].Width = 90;
            dgvDados.Columns[2].HeaderText = "Categoria";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Sub Categoria";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "Data Cadastro";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "Produto";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Descrição";
            dgvDados.Columns[6].Width = 100;
            dgvDados.Columns[7].HeaderText = "Foto";
            dgvDados.Columns[7].Width = 100;
            dgvDados.Columns[8].HeaderText = "Valor Pago";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].DefaultCellStyle.Format = "c";﻿
            dgvDados.Columns[9].HeaderText = "Valor Venda";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[9].DefaultCellStyle.Format = "c";﻿
            dgvDados.Columns[10].HeaderText = "Quantidade";
            dgvDados.Columns[10].Width = 100;﻿
            dgvDados.Columns[11].HeaderText = "Unidade de Medida";
            dgvDados.Columns[11].Width = 100;
            dgvDados.Columns[12].HeaderText = "Categoria";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "SubCategoria";
            dgvDados.Columns[13].Width = 100;

            //ocultar colunas
             dgvDados.Columns["cat_cod"].Visible = false;
             dgvDados.Columns["scat_cod"].Visible = false;
             dgvDados.Columns["umed_cod"].Visible = false;
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
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
