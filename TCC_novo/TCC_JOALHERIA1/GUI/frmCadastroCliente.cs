using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ferramentas;
using MODELO;
using DAO;
using BLL;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloCategoria
    {
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
           
        }

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if(txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtCpfCnpj.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if(txtTexto.Text.Length == 7)
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

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtCpfCnpj.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }
        public frmCadastroCliente()
        {
            InitializeComponent();
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
            txtRgie.Clear();
            txtCpfCnpj.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtCel.Clear();
            txtBairro.Clear();
            txtSexo.Clear();
            rbFisica.Checked = true;
            lbValorIncorreto.Visible = false;
            
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                if (modelo.CliTipo == "FISICA")
                {
                    rbFisica.Checked = true;

                }
                else
                {
                    rbJuridica.Checked = true;
                }
                txtdatacadastro.Value = modelo.Clidatacadastro;
                txtNome.Text = modelo.CliNome;
                txtCpfCnpj.Text = modelo.CliCpfCnpj;
                txtRgie.Text = modelo.CliRgIe;
                txtdtnascimento.Value = modelo.CliDtnascimento;
                txtSexo.Text = modelo.CliSexo;
                txtRsocial.Text = modelo.CliRsocial;
                txtCep.Text = modelo.CliCep;
                txtLogradouro.Text = modelo.CliLogradouro;
                txtBairro.Text = modelo.CliBairro;
                txtFone.Text = modelo.CliFone;
                txtCel.Text = modelo.CliCelular;
                txtEmail.Text = modelo.CliEmail;
                txtEndNumero.Text = modelo.CliEndNumero;
                txtCidade.Text = modelo.CliCidade;
                txtEstado.Text = modelo.CliEstado;
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
                   BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.Clidatacadastro = txtdatacadastro.Value;
                modelo.CliNome = txtNome.Text;
                modelo.CliCpfCnpj = txtCpfCnpj.Text;
                modelo.CliRgIe = txtRgie.Text;
                modelo.CliDtnascimento = txtdtnascimento.Value;
                modelo.CliSexo = txtSexo.Text;
                modelo.CliRsocial = txtRsocial.Text;
                modelo.CliCep = txtCep.Text.Replace("-","");
                modelo.CliLogradouro = txtLogradouro.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliCelular = txtCel.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEndNumero = txtEndNumero.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                if(rbFisica.Checked == true)
                {
                    modelo.CliTipo = "FISICA"; //Pessoa Fisica
                    modelo.CliRsocial = "";
                }
                else
                {
                    modelo.CliTipo = "JURIDICA"; //Pessoa juridica
                }
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma cliente
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " +modelo.CliCod.ToString());

                }
                else
                {
                    //alterar uma cliente
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        //Variaveis que guardara as permissões
       // Boolean perInserir = false; Boolean perAlterar = false; Boolean perExcluir = false; Boolean perImprimir = false;

        private void frmCadastroCliente_Load(object sender, EventArgs e)
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

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFisica.Checked == true)
            {
                lbRsocial.Visible = false;
                txtRsocial.Visible = false;
                lbCPFCNPJ.Text = "CPF";
                lbRgIe.Text = "RG";
            }
            else
            {
                lbRsocial.Visible = true;
                txtRsocial.Visible = true;
                lbCPFCNPJ.Text = "CNPJ";
                lbRgIe.Text = "IE";
            }
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
           if(rbJuridica.Checked == true)
           {
               lbnasc.Visible = false;
               txtdtnascimento.Visible = false;
               lbsexo.Visible = false;
               txtSexo.Visible = false;
           }
           else
           {
               lbnasc.Visible = true;
               txtdtnascimento.Visible = true;
               lbsexo.Visible = true;
               txtSexo.Visible = true;
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

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (rbFisica.Checked == true)
            {
                //cpf
                if(Validacao.IsCpf(txtCpfCnpj.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(txtCpfCnpj.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }

            }
        }

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CPF;
                if (rbFisica.Checked == false) edit = Campo.CNPJ;
                Formatar(edit, txtCpfCnpj);
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtdtnascimento_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
