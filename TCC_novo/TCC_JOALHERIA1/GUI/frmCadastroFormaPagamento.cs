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
    public partial class frmCadastroFormaPagamento : GUI.frmModeloCategoria
    {
        public frmCadastroFormaPagamento()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroFormaPagamento_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "Inserir";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento f = new frmConsultaFormaPagamento();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                ModeloTipoPagamento modelo = bll.CarregaModeloTipoPagamento(f.codigo);
                txtCodigo.Text = modelo.TpaCod.ToString();
                txtNome.Text = modelo.TpaNome;
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
                    BLLTipoPagamento bll = new BLLTipoPagamento(cx);
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
                ModeloTipoPagamento modelo = new ModeloTipoPagamento();
                modelo.TpaNome = txtNome.Text;
                //obj para gravar os dados no banco
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                BLLTipoPagamento bll = new BLLTipoPagamento(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.TpaCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.TpaCod = Convert.ToInt32(txtCodigo.Text);
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
    }
}
