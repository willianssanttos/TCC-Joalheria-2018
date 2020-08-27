using BLL;
using DAO;
using Ferramentas;
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
    public partial class frmFormaDePagamento : Form
    {
        public double totalVenda = 0; 

        public frmFormaDePagamento()
        {
            InitializeComponent();
        }

        public frmFormaDePagamento(string texto)
        {
            InitializeComponent();
            lblTotal.Text = texto;          
        }

        private void frmFormaDePagamento_Load(object sender, EventArgs e)
        {
            lblNome.Text = SessaoUsuario.Session.Instance.UsuNome;
            //this.alteraBotoes(1);
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTpagto.DataSource = bll.Localizar("");
            cbTpagto.DisplayMember = "tpa_nome";
            cbTpagto.ValueMember = "tpa_cod";

            cbNParcelas.SelectedIndex = 0;
        }

 
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmFormaDePagamento_Enter(object sender, EventArgs e)
        {
            
            
        }

                
        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {

                   
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbTpagto_EnabledChanged(object sender, EventArgs e)
        {
           
        }
    }
}
