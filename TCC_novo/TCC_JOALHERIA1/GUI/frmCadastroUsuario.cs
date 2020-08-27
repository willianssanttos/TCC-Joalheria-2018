using BLL;
using DAO;
using Ferramentas;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloCategoria
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            foreach(Control c in pnDados.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            txtCodigo.Clear();
            txtNome.Clear();
            txtLogin.Clear();
            txtGrupo.Clear();
            txtSenha.Clear();

        }

        //Variaveis que guardara as permissões
        //Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.LocalizarNivelAcesso(SessaoUsuario.Session.Instance.UsuID, this.txtNome.ToString());

                

                this.alteraBotoes(1);
            }
            catch
            {

            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente EXCLUIR o registro selecionado ?", "CONFIRMA EXCLUSÃO DE REGISTRO", MessageBoxButtons.YesNo);
                if (resultado.ToString() == "Yes")
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    MessageBox.Show("Registro exclído com sucesso !!", "SUCESSO NA EXCLUSÃO DE REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo vinculado em outra tabela!!!\n\n Contate o Admistrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome = txtNome.Text;
                modelo.UsuLogin = txtLogin.Text;
                modelo.UsuGrupo = txtGrupo.Text;
                modelo.UsuSenha = txtSenha.Text;
                
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma cliente
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado com Sucesso!!!\n\n Código:" + modelo.UsuId.ToString(), "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //alterar uma cliente
                    modelo.UsuId = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado com Sucesso!!!\n\n Código:" + modelo.UsuId.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!!\n\n Contate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaUsuario f = new frmConsultaUsuario();
                f.ShowDialog();
                if (f.codigo != 0)
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                    txtCodigo.Text = modelo.UsuId.ToString();
                    txtNome.Text = modelo.UsuNome;
                    txtLogin.Text = modelo.UsuLogin;
                    txtGrupo.Text = modelo.UsuGrupo;
                    txtSenha.Text = modelo.UsuSenha;
                    this.alteraBotoes(3);
                }
                else
                {
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
                f.Dispose();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel Realizar a Operação!!!\n\n Contate o Administrador do Sistema!!!\n\nErro Ocorrido:" + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir" || this.operacao == "Alterar")
            {
                int r = 0;
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                r = bll.VerificaSeJaExiste(txtLogin.Text);
                if (r > 0)
                {
                    MessageBox.Show("OPPSSS!!!!!! \n \n Quantidade excedida, Permitido apenas 1 produto", "DUPLICIDADE DE REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLogin.Focus();
                    return;
                }
            }           
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
