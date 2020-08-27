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
    public partial class frmCadastroFuncionario : GUI.frmModeloCategoria
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

         public enum Campo
        {
            CPF = 1,           
        }

         public void Formatar(Campo Valor, TextBox txtTexto)
         {
             switch (Valor)
             {
                 case Campo.CPF:
                     txtTexto.MaxLength = 14;
                     if (txtTexto.Text.Length == 3)
                     {
                         txtTexto.Text = txtCpf.Text + ".";
                         txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                     }
                     else if (txtTexto.Text.Length == 7)
                     {
                         txtTexto.Text = txtTexto.Text + ".";
                         txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                     }
                     else if (txtTexto.Text.Length == 11)
                     {
                         txtTexto.Text = txtTexto.Text + "-";
                         txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                     }
                     break;
             }
         }
         public void LimpaTela()
         {
             txtCodigo.Clear();
             txtNome.Clear();
             txtEmail.Clear();
             txtEndNumero.Clear();
             txtEstado.Clear();
             txtFone.Clear();
             txtLogradouro.Clear();
             txtRg.Clear();
             txtCpf.Clear();
             txtCidade.Clear();
             txtCep.Clear();
             txtCel.Clear();
             txtBairro.Clear();
             txtSexo.Clear();
             txtescolaridade.Clear();
             txtCarFunc.Clear();
             lbValorIncorreto.Visible = false;

         }

         private void btInserir_Click(object sender, EventArgs e)
         {
             this.operacao = "inserir";
             this.alteraBotoes(2);
         }

         private void btLocalizar_Click(object sender, EventArgs e)
         {
             frmConsultaFuncionario f = new frmConsultaFuncionario();
             f.ShowDialog();
             if (f.codigo != 0)
             {
                 DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                 BLLFuncionario bll = new BLLFuncionario(cx);
                 ModeloFuncionario modelo = bll.CarregaModeloFuncionario(f.codigo);
                 txtCodigo.Text = modelo.FunCod.ToString();
                 txtdtcadastro.Value = modelo.Fundatacadastro;
                 txtNome.Text = modelo.FunNome;
                 txtdtnascimento.Value = modelo.Fundatanascimento;
                 txtCpf.Text = modelo.FunCpf;
                 txtRg.Text = modelo.FunRg;
                 txtSexo.Text = modelo.FunSexo;
                 txtFone.Text = modelo.FunTelefone;
                 txtCel.Text = modelo.FunCelular;
                 txtEmail.Text = modelo.FunEmail;
                 txtescolaridade.Text = modelo.FunEscolaridade;
                 txtdtadmisao.Value = modelo.Fundataadmissao;
                 txtCarFunc.Text = modelo.FunCarFun;
                 txtCep.Text = modelo.FunCep;
                 txtLogradouro.Text = modelo.FunLogradouro;
                 txtBairro.Text = modelo.FunBairro;
                 txtCidade.Text = modelo.FunCidade;
                 txtEstado.Text = modelo.FunEstado;
                 txtEndNumero.Text = modelo.FunEndNumero;
                 alteraBotoes(3);
             }
             else
             {
                 this.LimpaTela();
                 this.alteraBotoes(1);
             }
             f.Dispose();
            
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
                 DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                 if (d.ToString() == "Yes")
                 {
                     DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                     BLLFuncionario bll = new BLLFuncionario(cx);
                     bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                     this.LimpaTela();
                     this.alteraBotoes(1);
                 }
             }
             catch
             {
                 MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                 this.alteraBotoes(3);
             }
         }

         private void btSalvar_Click(object sender, EventArgs e)
         {
             try
             {
                 //leitura dos dados
                 ModeloFuncionario modelo = new ModeloFuncionario();
                 modelo.Fundatacadastro = txtdtcadastro.Value;
                 modelo.FunNome = txtNome.Text;
                 modelo.Fundatanascimento = txtdtnascimento.Value;
                 modelo.FunCpf = txtCpf.Text;
                 modelo.FunRg = txtRg.Text;
                 modelo.FunSexo = txtSexo.Text;
                 modelo.FunTelefone = txtFone.Text;
                 modelo.FunCelular = txtCel.Text;
                 modelo.FunEmail = txtEmail.Text;
                 modelo.FunEscolaridade = txtescolaridade.Text;
                 modelo.Fundataadmissao = txtdtadmisao.Value;
                 modelo.FunCarFun = txtCarFunc.Text;
                 modelo.FunCep = txtCep.Text.Replace("-", "");
                 modelo.FunLogradouro = txtLogradouro.Text;
                 modelo.FunBairro = txtBairro.Text;                
                 modelo.FunCidade = txtCidade.Text;
                 modelo.FunEstado = txtEstado.Text;
                 modelo.FunEndNumero = txtEndNumero.Text;

                 //obj para gravar os dados no banco
                 DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                 BLLFuncionario bll = new BLLFuncionario(cx);
                 if (this.operacao == "inserir")
                 {
                     //cadastrar uma Forente
                     bll.Incluir(modelo);
                     MessageBox.Show("Cadastro efetuado: Código " + modelo.FunCod.ToString());

                 }
                 else
                 {
                     //alterar uma Forente
                     modelo.FunCod = Convert.ToInt32(txtCodigo.Text);
                     bll.Alterar(modelo);
                     MessageBox.Show("Cadastro alterado");
                 }
                 this.LimpaTela();
                 this.alteraBotoes(1);
             }
             catch (Exception erro)
             {
                 MessageBox.Show(erro.Message);
             }
         }

         private void btCancelar_Click(object sender, EventArgs e)
         {
             this.LimpaTela();
             this.alteraBotoes(1);
         }

         //Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

         private void frmCadastroFuncionario_Load(object sender, EventArgs e)
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

         private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar != (char)8)
             {
                 Campo edit = Campo.CPF;
                 Formatar(edit, txtCpf);
             }
         }

         private void txtCpf_Leave_1(object sender, EventArgs e)
         {

             lbValorIncorreto.Visible = false;

             //cpf
             if (Validacao.IsCpf(txtCpf.Text) == false)
             {
                 lbValorIncorreto.Visible = true;
             }
         }

         private void txtCep_Leave(object sender, EventArgs e)
         {
             if (Validacao.ValidaCep(txtCep.Text) == false)
             {
                 MessageBox.Show("O Cep é invalido");
                 txtBairro.Clear();
                 txtEstado.Clear();
                 txtLogradouro.Clear();
                 txtCidade.Clear();
             }
             else
             {
                 if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                 {
                     txtBairro.Text = BuscaEndereco.bairro;
                     txtEstado.Text = BuscaEndereco.estado;
                     txtCidade.Text = BuscaEndereco.cidade;
                     txtLogradouro.Text = BuscaEndereco.logradouro;
                     txtCep.Text = BuscaEndereco.cep;
                 }
             }
         }

         private void txtCarFunc_TextChanged(object sender, EventArgs e)
         {

         }

         private void label14_Click(object sender, EventArgs e)
         {

         }

         private void iconeencerar_Click(object sender, EventArgs e)
         {
             this.Close();
         }
    }
}
