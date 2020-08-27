using BLL;
using DAO;
using MODELO;
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
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;

        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        public void AtualizaCabeçalhoDGridVenda()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Data da venda";
            dgvDados.Columns[1].Width = 125;
            dgvDados.Columns[2].HeaderText = "Número da nota fiscal";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Número de parcelas";
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].HeaderText = "Cliente";
            dgvDados.Columns[4].Width = 150;
            dgvDados.Columns[5].HeaderText = "Status da venda";
            dgvDados.Columns[5].Width = 90;
            dgvDados.Columns[6].HeaderText = "Código do cliente";
            dgvDados.Columns[6].Width = 90;
            dgvDados.Columns[7].HeaderText = "Código do tipo de pagamento";
            dgvDados.Columns[7].Width = 90;
            dgvDados.Columns[8].HeaderText = "Venda a vista ou a prazo";
            dgvDados.Columns[8].Width = 90;
            dgvDados.Columns[9].HeaderText = "Total";
            dgvDados.Columns[9].Width = 90;
            dgvDados.Columns[9].DefaultCellStyle.Format = "c";﻿

            //ocultar colunas
            //dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].Visible = false;
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //oculta paineis
            pCliente.Visible = false;
            pData.Visible = false;
            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar();
                this.AtualizaCabeçalhoDGridVenda();
            }
            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbCliente.Checked == true)
            {
                pCliente.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.LocalizarPorParcelasEmAberto();
                this.AtualizaCabeçalhoDGridVenda();
            }
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            rbGeral_CheckedChanged(sender, e);
        }

        private void btLocCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCliCod.Text = f.codigo.ToString();
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                lbCliNome.Text = "Nome do cliente: " + modelo.CliNome;
                BLLVenda bllvenda = new BLLVenda(cx);
                dgvDados.DataSource = bllvenda.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabeçalhoDGridVenda();
            }
            else
            {
                txtCliCod.Text = ""; lbCliNome.Text = "Nome do Cliente:";
            }
        }

        private void btnLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = data1.Value;
            DateTime dtfim = data2.Value;
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLVenda bllvenda = new BLLVenda(cx);
            dgvDados.DataSource = bllvenda.Localizar(dtini, dtfim);
            this.AtualizaCabeçalhoDGridVenda();
        }

        public void AlteraCabecalhoItensParcelas()
        {
            try
            {
                dgvItens.Columns[0].Visible = false;
                dgvItens.Columns[1].HeaderText = "Código item";
                dgvItens.Columns[2].HeaderText = "Código Produto";
                dgvItens.Columns[3].HeaderText = "Nome Produto";
                dgvItens.Columns[4].HeaderText = "Quantidade";
                dgvItens.Columns[5].HeaderText = "Valor";

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].Visible = false;
                dgvParcelas.Columns[2].HeaderText = "Valor";
                dgvParcelas.Columns[3].HeaderText = "Data de Pagamento";
                dgvParcelas.Columns[4].HeaderText = "Data de Vencimento";

            }
            catch
            {

            }

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                //itens da compra
                BLLItensCompra bllItens = new BLLItensCompra(cx);
                dgvItens.DataSource = bllItens.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                //parcelas da compra
                BLLParcelasCompra bllParcelas = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllParcelas.Localizar(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value));
                this.AlteraCabecalhoItensParcelas();
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
