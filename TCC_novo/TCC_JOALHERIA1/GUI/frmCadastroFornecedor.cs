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
    public partial class frmCadastroFornecedor : GUI.frmModeloCategoria
    {
        public enum Campo
        {
            CNPJ = 1,
        }

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtCnpj.Text + ".";
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
        public frmCadastroFornecedor()
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
            txtCidade.Clear();
            txtCep.Clear();
            txtCel.Clear();
            txtBairro.Clear();
            lbValorIncorreto.Visible = false;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);  
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtdatacadastro.Value = modelo.Fordatacadastro;
                txtNome.Text = modelo.ForNome;
                txtCnpj.Text = modelo.ForCnpj;
                txtie.Text = modelo.ForIe;
                txtRsocial.Text = modelo.ForRsocial;
                txtCep.Text = modelo.ForCep;
                txtLogradouro.Text = modelo.ForLogradouro;
                txtBairro.Text = modelo.ForBairro;
                txtFone.Text = modelo.ForFone;
                txtCel.Text = modelo.ForCelular;
                txtEmail.Text = modelo.ForEmail;
                txtEndNumero.Text = modelo.ForEndNumero;
                txtCidade.Text = modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;
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
                    BLLFornecedor bll = new BLLFornecedor(cx);
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
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.Fordatacadastro = txtdatacadastro.Value;
                modelo.ForNome = txtNome.Text;
                modelo.ForCnpj = txtCnpj.Text;
                modelo.ForIe = txtie.Text;
                modelo.ForRsocial = txtRsocial.Text;
                modelo.ForCep = txtCep.Text.Replace("-", "");
                modelo.ForLogradouro = txtLogradouro.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForFone = txtFone.Text;
                modelo.ForCelular = txtCel.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForEndNumero = txtEndNumero.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma Forente
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ForCod.ToString());

                }
                else
                {
                    //alterar uma Forente
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
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

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (Validacao.IsCnpj(txtCnpj.Text) == false)
            {
                lbValorIncorreto.Visible = true;
            }

        }
    }
}
