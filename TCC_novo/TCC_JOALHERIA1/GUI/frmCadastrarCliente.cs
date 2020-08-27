using BLL;
using DAO;
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
    public partial class frmCadastrarCliente : GUI.frmModeloCategoria
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtcli_cod.Clear();
            txtNome.Clear();
            txtcpfcnpj.Clear();
            txtrg.Clear();
            txtEmail.Clear();
            txtFone.Clear();
            txtCelular.Clear();
            txtcep.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEndnumero.Clear();
            txtBairro.Clear();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {

            this.alteraBotoes(1);
            try
            {
                //combo do tipo 
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                txtTipo.DataSource = bll.Localizar("");
                txtTipo.DisplayMember = "cli_tipo";
                txtTipo.ValueMember = "cli_cod";
            }catch{
           
            //combo do sexo
            DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            txtSexo.DataSource = bll.Localizar("");
            txtSexo.DisplayMember = "cli_sexo";
            txtSexo.ValueMember = "cli_cod";
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliRgie = txtrg.Text;
                modelo.CliFone = txtFone.Text;
                modelo.CliEndereco = txtEndereco.Text;
                modelo.CliCpfcnpj = txtcpfcnpj.Text;
                modelo.CliBairro  = txtBairro.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado. Text;
                modelo.CliDatacadastro = txtDatacadastro.Text;
                modelo.CliSexo = txtSexo.Text;
                modelo.CliDtnascimento = txtDtnascimento.Text;
                
                modelo.CliCep = txtcep.Text;
                modelo.CliCel = txtCelular.Text;
                modelo.CliEndnumero = txtEndnumero.Text;
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar um cliente
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());

                }
                else
                {
                    //alterar um cliente
                    modelo.CliCod = Convert.ToInt32(txtcli_cod.Text);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    bll.Excluir(Convert.ToInt32(txtcli_cod.Text));
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
