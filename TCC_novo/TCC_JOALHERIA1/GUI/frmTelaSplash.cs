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
    public partial class frmTelaSplash : Form
    {
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(tempo.Value < 100)
            {
                tempo.Value = tempo.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
