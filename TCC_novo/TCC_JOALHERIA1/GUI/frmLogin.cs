using BLL;
using DAO;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wmsg, int wparam, int Ipardm);

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Os Campos (Usuário e Senha) São de Preenchimento Obrigatório!!! \n\n" +
                        "Preencha os Dados e Clique novamente em Logar!!!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarUsuarioLogin(txtUsuario.Text, txtSenha.Text);

                if (tabela.Rows.Count == 1)
                {
                    SessaoUsuario.Session.Instance.UsuID = Convert.ToInt32(tabela.Rows[0][0].ToString());
                    SessaoUsuario.Session.Instance.UsuNome = (tabela.Rows[0][2].ToString());
                    SessaoUsuario.Session.Instance.UsuGrupo = (tabela.Rows[0][3].ToString());
                    MessageBox.Show("Seja bem Vindo ao Sistema!");
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha estão incorretos");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Um Erro ocorreu ao Processar os dados!\n Tente mais tarde!!!");
            }
        }

        private void chkMostrar_OnChange(object sender, EventArgs e)
        {
            if (this.chkMostrar.Checked)
            {
                this.txtSenha.isPassword = false;
            }
            else
            {
                this.txtSenha.isPassword = true;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (CaracterEspecial.VerificaCaracter(txtUsuario.Text) != "OK")
            {
                txtUsuario.Focus();
                MessageBox.Show("um Caracter Não Permitido foi Inscrito!!!\n\n Remova e prosiga com a Operação!", "Caracter Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmLogar_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
