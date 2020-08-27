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
using System.Threading;
using Ferramentas;
using DAO;
using BLL;
using GUI.Properties;


namespace GUI
{
    public partial class frmMenu : Form
    {
        private bool isCollapsed;
        private bool isCollapsed1;
        public frmMenu()
        {
            InitializeComponent();
        }

       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

        private void AbrirForms(object forms)
        {
            if (this.panelcenter.Controls.Count > 0)
                this.panelcenter.Controls.RemoveAt(0);
            Form fh = forms as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcenter.Controls.Add(fh);
            this.panelcenter.Tag = fh;
            fh.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (SessaoUsuario.Session.Instance.UsuGrupo != "Administrador")
            {
                rela.Visible = false;
                btnFuncionario.Visible = false;
                ferra.Visible = false; 
            }
            else
            {
                /*if (SessaoUsuario.Session.Instance.UsuGrupo != "Gerente")
                {
                    btnRelatorio.Visible = false;
                    btnFerramentas.Visible = false;
                }  */                  
            }
            lblUsuario.Text = SessaoUsuario.Session.Instance.UsuNome;
            lblNivel.Text = SessaoUsuario.Session.Instance.UsuGrupo;
            timer1.Enabled = true;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
              if (isCollapsed1)
                {
                    cads.Image = Resources.Collapse_Arrow_20px;
                    panelDropDown.Height += 15;
                    if (panelDropDown.Size == panelDropDown.MaximumSize)
                    {
                        timer2.Stop();
                        isCollapsed1 = false;
                    }
                }
                else
                {
                    cads.Image = Resources.Expand_Arrow_20px;
                    panelDropDown.Height -= 15;
                    if (panelDropDown.Size == panelDropDown.MinimumSize)
                    {
                        timer2.Stop();
                        isCollapsed1 = true;
                    }
                }              
          }

        private void btnCadastro_Click(object sender, EventArgs e)
        {           
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmCadastroCliente");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmCadastroCliente());
                tabela.Dispose();
            }
        }

        private void cads_Click(object sender, EventArgs e)
        {           
            timer2.Start();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {            
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmCadastroFuncionario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmCadastroFuncionario());
                tabela.Dispose();
            }
        }

  

        private void btnConsultas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMovimentaçao_Click(object sender, EventArgs e)
        {
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmMovimentacaoVenda");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmMovimentacaoVenda());
                tabela.Dispose();
            }
        }

        private void btnConsuVenda_Click(object sender, EventArgs e)
        {
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmConsultaVenda");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmConsultaVenda());
                tabela.Dispose();
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {           
            timer2.Start();
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY, SW, SH;
        private void iconemaxizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconerestaurar.Visible = true;
            iconemaxizar.Visible = false;
        }

        private void iconerestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconerestaurar.Visible = false;
            iconemaxizar.Visible = true;
        }

        private void iconeminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                ferra.Image = Resources.Collapse_Arrow_20px;
                panel3.Height += 15;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                ferra.Image = Resources.Expand_Arrow_20px;
                panel3.Height -= 15;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {           
            timer3.Start();
        }

        private void rela_Click(object sender, EventArgs e)
        {            
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                rela.Image = Resources.Collapse_Arrow_20px;
                panel4.Height += 15;
                if (panel4.Size == panel4.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                rela.Image = Resources.Expand_Arrow_20px;
                panel4.Height -= 15;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {            
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmBackupBancoDeDados");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmBackupBancoDeDados());
                tabela.Dispose();
            }
        }

        private void btnConfiguraçao_Click(object sender, EventArgs e)
        {            
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmConfiguraçaoBancoDados");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmConfiguraçaoBancoDados());
                tabela.Dispose();
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmEnviarEmail");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmEnviarEmail());
                tabela.Dispose();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btCons_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                rela.Image = Resources.Collapse_Arrow_20px;
                panel5.Height += 15;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                rela.Image = Resources.Expand_Arrow_20px;
                panel5.Height -= 15;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnConCli_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmConsultaCliente");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmConsultaCliente());
                tabela.Dispose();
            }
        }

        private void btnConFun_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmConsultaFuncionario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmConsultaFuncionario());
                tabela.Dispose();
            }
        }

        private void btnConPro_Click(object sender, EventArgs e)
        {
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmConsultaProduto");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmConsultaProduto());
                tabela.Dispose();
            }
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmTodosCadastros f = new frmTodosCadastros();
            f.ShowDialog();
            f.Close();
        }

        private void cadUsuario_Click(object sender, EventArgs e)
        {
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmCadastroUsuario");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmCadastroUsuario());
                tabela.Dispose();
            }
        }

        private void cadNivel_Click(object sender, EventArgs e)
        {
            panelcenter.BringToFront();
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            DataTable tabela = new DataTable();
            tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, "frmCadastroNivelAcesso");
            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("Atenção O usuário não possui permissões Cadastradas para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            if (Convert.ToBoolean(tabela.Rows[0][4]) == true)
            {
                MessageBox.Show("Atenção O usuário não possui permissões de acesso para esse Formulario!!!\n\n Contate o administrador e Solicite a Permissão!");
                tabela.Dispose();
                return;
            }
            else
            {
                AbrirForms(new frmCadastroNivelAcesso());
                tabela.Dispose();
            }            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente f = new frmRelatorioCliente();
            f.ShowDialog();
            f.Close();
        }

        private void btnreven_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda f = new frmRelatorioVenda();
            f.ShowDialog();
            f.Close();
        }

        private void btnrepro_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto f = new frmRelatorioProduto();
            f.ShowDialog();
            f.Close();
        }

        private void btnreFun_Click(object sender, EventArgs e)
        {
            frmRelatorioFuncionario f = new frmRelatorioFuncionario();
            f.ShowDialog();
            f.Close();
        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultaWEB f = new frmConsultaWEB();
            f.ShowDialog();
            f.Close();
        }
    }
}
