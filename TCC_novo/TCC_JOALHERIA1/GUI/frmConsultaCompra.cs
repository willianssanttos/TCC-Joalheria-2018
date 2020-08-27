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
using System.Runtime.InteropServices;
using Ferramentas;

namespace GUI
{
    public partial class frmConsultaCompra : Form
    {
        public int codigo = 0;

        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            
            rbGeral_CheckedChanged(sender, e);
        }

        public void ExecutarConsulta(int op)
        {
            //op = 1 todas as compras 
            //op = 2 por fornecedor
            //op = 3 data da compra
            //op = 4 parcelas em aberto
        }
        public void AtualizaCabeçalhoDGridCompra()
        {
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "Data da compra";
            dgvDados.Columns[1].Width = 125;
            dgvDados.Columns[2].HeaderText = "Número da nota fiscal";
            dgvDados.Columns[2].Width = 90;
            dgvDados.Columns[3].HeaderText = "Número de parcelas";
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].HeaderText = "Fornecedor";
            dgvDados.Columns[4].Width = 150;
            dgvDados.Columns[5].HeaderText = "Status da compra";
            dgvDados.Columns[5].Width = 90;
            dgvDados.Columns[6].HeaderText = "Código do fornecedor";
            dgvDados.Columns[6].Width = 90;
            dgvDados.Columns[7].HeaderText = "Código do tipo de pagamento";
            dgvDados.Columns[7].Width = 90;
            dgvDados.Columns[8].HeaderText = "Total";
            dgvDados.Columns[8].Width = 90;
            dgvDados.Columns[8].DefaultCellStyle.Format = "c";﻿

            //ocultar colunas
            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[6].Visible = false;
            dgvDados.Columns[7].Visible = false;
        }

        private void btLocFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                lbForNome.Text = "Nome do fornecedor: " + modelo.ForNome;
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar(f.codigo);
                f.Dispose();
                this.AtualizaCabeçalhoDGridCompra();
            }
            else
            {
                txtForCod.Text = ""; lbForNome.Text = "Nome do Fornecedor:";
            }
        }

        private void rbGeral_CheckedChanged(object sender, EventArgs e)
        {
            //oculta paineis
            pFornecedor.Visible = false;
            pData.Visible = false;
            //limpar os grids
            dgvDados.DataSource = null;
            dgvItens.DataSource = null;
            dgvParcelas.DataSource = null;

            if (rbGeral.Checked == true)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.Localizar();
                this.AtualizaCabeçalhoDGridCompra();
            }
            if (rbData.Checked == true)
            {
                pData.Visible = true;
            }
            if (rbFornecedor.Checked == true)
            {
                pFornecedor.Visible = true;
            }
            if (rbParcelas.Checked == true)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCompra bllcompra = new BLLCompra(cx);
                dgvDados.DataSource = bllcompra.LocalizarPorParcelasEmAberto();
                this.AtualizaCabeçalhoDGridCompra();
            }
        }

        private void btnLocData_Click(object sender, EventArgs e)
        {
            DateTime dtini = dateTimePicker1.Value;
            DateTime dtfim = dateTimePicker2.Value;
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLCompra bllcompra = new BLLCompra(cx);
            dgvDados.DataSource = bllcompra.Localizar(dtini,dtfim);
            this.AtualizaCabeçalhoDGridCompra();
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

        private void frmConsultaCompra_MouseDown(object sender, MouseEventArgs e)
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
