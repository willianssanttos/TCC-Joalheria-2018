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
    public partial class frmRelatorioProduto : Form
    {
        public frmRelatorioProduto()
        {
            InitializeComponent();
        }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'JOALHERIADataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.JOALHERIADataSet.produto);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
