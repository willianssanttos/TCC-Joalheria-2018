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
    public partial class frmPagamentoCompra : Form
    {
        public int pcoCod = 0;
        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            btPagar.Enabled = false;
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txtCodigo.Text = modelo.VenCod.ToString();
                dtData.Value = modelo.VenData;
                BLLCliente bllf = new BLLCliente(cx);
                ModeloCliente modeloc = bllf.CarregaModeloCliente(modelo.CliCod);
                txtForNome.Text = modeloc.CliNome;
                txtValor.Text = modelo.VenTotal.ToString();

                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.VenCod);

                dgvParcelas.Columns[0].Visible = false;
                dgvParcelas.Columns[1].HeaderText = "Parcela";
                dgvParcelas.Columns[1].Width = 100;
                dgvParcelas.Columns[2].HeaderText = "Valor da parcela";
                dgvParcelas.Columns[2].Width = 225;
                dgvParcelas.Columns[3].HeaderText = "Recebido em";
                dgvParcelas.Columns[3].Width = 200;
                dgvParcelas.Columns[4].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Width = 250;

            }
            /*btPagar.Enabled = false;
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txtCodigo.Text = modelo.ComCod.ToString();
                dtData.Value = modelo.ComData;
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(modelo.ForCod);
                txtForNome.Text = modelof.ForNome;
                txtValor.Text = modelo.ComTotal.ToString();

                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                dgvParcelas.DataSource = bllp.Localizar(modelo.ComCod);

                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[0].Width = 125;
                dgvParcelas.Columns[1].Visible = false;
                dgvParcelas.Columns[2].HeaderText = "Valor da parcela";
                dgvParcelas.Columns[2].Width = 200;
                dgvParcelas.Columns[3].HeaderText = "Pago em";
                dgvParcelas.Columns[3].Width = 200;
                dgvParcelas.Columns[4].HeaderText = "Vencimento";
                dgvParcelas.Columns[4].Width = 250;
                   
            }*/
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
            int ComCod = Convert.ToInt32(txtCodigo.Text);
            DateTime data = dtpPagto.Value;
            bllp.EfetuaPagamentoParcela(ComCod, pcoCod, data);

            BLLParcelasCompra bll2p = new BLLParcelasCompra(cx);
            dgvParcelas.DataSource = bllp.Localizar(ComCod);
            btPagar.Enabled = false;
            dgvParcelas.Columns[0].HeaderText = "Parcela";
            dgvParcelas.Columns[1].Visible = false;
            dgvParcelas.Columns[2].HeaderText = "Valor da parcela";
            dgvParcelas.Columns[3].HeaderText = "Pago em";
            dgvParcelas.Columns[4].HeaderText = "Vencimento";
           
        }

        private void dgvParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btPagar.Enabled = false;
            this.pcoCod = 0;
            if (e.RowIndex >= 0 && dgvParcelas.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
            {
                btPagar.Enabled = true;
                this.pcoCod = Convert.ToInt32(dgvParcelas.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
