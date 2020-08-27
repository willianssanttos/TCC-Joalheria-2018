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
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'JOALHERIADataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.JOALHERIADataSet.funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
