using BLL;
using DAO;
using MODELO;
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
    public partial class frmCadastroNivelAcesso : Form
    {
    
        public frmCadastroNivelAcesso()
        {
            InitializeComponent();
        }
        string operacao = "";
        int UsuId = 0;
        string UsuLoginPesquisado = "";
        string UsuNomePesquisado = "";

        public void alterabotao(int op)
        {
            btAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btLocalizar.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            dgvDados.Enabled = false;
            gbMarcarTodos.Enabled = false;
            btExcluir.Enabled = false;

            if (op == 1)
            {
                btnLocalizar.Enabled = true;
                btLocalizar.Enabled = true;
                btCancelar.Enabled = false;
            }
            if (op == 2)
            {
                dgvDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
                gbMarcarTodos.Enabled = true;

            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btCancelar.Enabled = true;
                btExcluir.Enabled = true;
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                //Verifica se tem usuário com o ID digitado
                BLLUsuario bllTesteUsuario = new BLLUsuario(cx);
                if (bllTesteUsuario.Localizar(Convert.ToInt32(txtCodigo.Text)).Rows.Count <= 0)
                {
                    MessageBox.Show("Atenção!!! O Código digitado não corresponde a nenhum cadastro de Usuário!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Focus();
                    txtCodigo.Text = "";
                    return;
                }

                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                DataTable tabela = new DataTable();
                tabela = bll.Localizar(Convert.ToInt32(txtCodigo.Text));
                int tPerm = 0;
                tPerm = tabela.Rows.Count;
                if (tPerm > 0)
                {
                    //Carrega as Permissções que o usuário ja possui no BD
                    for (int x = 0; x < tPerm;)
                    {
                        dgvDados.Rows.Add();
                        dgvDados.Rows[x].Cells[0].Value = tabela.Rows[x][0];
                        dgvDados.Rows[x].Cells[1].Value = tabela.Rows[x][1];
                        dgvDados.Rows[x].Cells[2].Value = tabela.Rows[x][2];
                        dgvDados.Rows[x].Cells[3].Value = tabela.Rows[x][3];
                        dgvDados.Rows[x].Cells[4].Value = tabela.Rows[x][4];
                        dgvDados.Rows[x].Cells[5].Value = tabela.Rows[x][5];
                        dgvDados.Rows[x].Cells[6].Value = tabela.Rows[x][6];
                        dgvDados.Rows[x].Cells[7].Value = tabela.Rows[x][7];
                        x++;
                    }
                    UsuId = Convert.ToInt32(tabela.Rows[0][10]);
                    UsuNomePesquisado = Convert.ToString(tabela.Rows[0][8]);
                    UsuLoginPesquisado = Convert.ToString(tabela.Rows[0][9]);
                    tabela.Dispose();
                    this.alterabotao(3);

                }
                else
                {
                    //Preenche as variaveis com o nome do Usuarios Recem cadastrados e sem permissão 
                    BLLUsuario bllUsuario = new BLLUsuario(cx);
                    DataTable dtUsuario = new DataTable();
                    dtUsuario = bllUsuario.Localizar(Convert.ToInt32(txtCodigo.Text));
                    UsuId = Convert.ToInt32(dtUsuario.Rows[0][0]);
                    UsuNomePesquisado = Convert.ToString(dtUsuario.Rows[0][1]);
                    UsuLoginPesquisado = Convert.ToString(dtUsuario.Rows[0][2]);
                    dtUsuario.Dispose();


                    //Carregar Permissao Default
                    IDictionary<String, string> strPerm = new Dictionary<string, string>()
              {
                //Cadastro dos Formularios
                {"frmCadastroCliente", "Cadastro de Clientes"},
                {"frmCadastroUsuario", "Cadastar Usuario"},
                {"frmCadastroNivelAcesso", "Cadastrar as Permissões do Acesso do Usuários"},
                {"frmCadastroFuncionario", "Cadastro de Funcionario"},
                {"frmCadastroProduto", "Cadastro de Produto"},
                {"frmCadastroSubCategoria", "Cadastro de SunCategoria"},
                {"frmCadastroUnidadeDeMedida", "Cadastro de Unidade de Medida"},
                {"frmCaixaDeFrente", "Caixa de Frente"},
                {"frmConfiguraçaoBancoDados", "Configuração do Banco de Dados"},
                {"frmConsultaCliente", "Consulta de Clientes"},
                {"frmCadastroCategoria", "Cadastro de Categoria"},
                {"frmConsultaCategoria", "Consulta de Categoria"},
                {"frmConsultaFuncionario", "Consulta de Funcionario"},
                {"frmConsultaProduto", "Consulta de Produto"},
                {"frmConsultaSubCategoria", "Consulta de SubCategoria"},
                {"frmConsultaUnidadeDeMedida", "Consulta de  Unidade de Medida"},
                {"frmConsultaUsuario", "Consulta de Usuario"},
                {"frmConsultaVenda", "Consulta das Venda"},
                {"frmRecebimentoVenda", "Recebimento das Vendas"},
                {"frmTodosCadastros", "Todos os Cadastros"},
                {"frmFerramentas", "Configuções do Sistema"},
                {"frmRelatorios", "Todos os Relatório"},
                {"frmMovimentacaoVenda", "Movimentaçãp venda"},
                {"frmEnviarEmail", "Enviar Email para cliente"},
                {"frmRelatorioCliente", "Relatório clientes"},
                {"frmRelatorioFuncionario", "Relatório funcionario"},
                {"frmRelatorioProduto", "Relatório produto"},
                {"frmRelatorioVenda", "Relatório Venda"},
                
             };

                    int i = 0;
                    foreach (string Perm in strPerm.Keys)
                    {
                        dgvDados.Rows.Add();
                        dgvDados.Rows[i].Cells[1].Value = Perm;
                        dgvDados.Rows[i].Cells[2].Value = strPerm[Perm];
                        if (Perm == "frmCadastroUsuario" || Perm == "frmCadastroNivelAcesso")
                        {
                            dgvDados.Rows[i].Cells[3].Value = "true";
                        }
                        else
                        {
                            dgvDados.Rows[i].Cells[3].Value = "false";
                        }
                        dgvDados.Rows[i].Cells[4].Value = "false";
                        dgvDados.Rows[i].Cells[5].Value = "false";
                        dgvDados.Rows[i].Cells[6].Value = "false";
                        dgvDados.Rows[i].Cells[7].Value = "false";
                        i++;
                    }
                    this.operacao = "inserir";
                    this.alterabotao(2);
                    MessageBox.Show("Ateção!!!,\n As Configurações Padrões(Default) Foram Carregadas para o Usuário!!!\n\n" +
                        "Realize as Devidas Alterações e Clique em Salvar, para que o Usuário tenha acesso ao Sistema", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtNomePesquisado.Text = UsuNomePesquisado + "(" + UsuLoginPesquisado + ")";
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCadastroNivelAcesso_Load(object sender, EventArgs e)
        {
            this.alterabotao(1);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterabotao(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Volta os botões para o estado inicial
            this.alterabotao(1);
            dgvDados.Rows.Clear();
            UsuId = 0;
            UsuLoginPesquisado = "";
            UsuNomePesquisado = "";
            txtCodigo.Clear();
            txtNomePesquisado.Clear();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                ModeloNivelAcesso modelo = new ModeloNivelAcesso();
                BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                if (this.operacao == "alterar")
                {
                    //Excluir as Permissões dos Usuario
                    BLLNivelAcesso bllExcluir = new BLLNivelAcesso(cx);
                    bllExcluir.ExcluirTudo(UsuId);
                }
                int x = dgvDados.RowCount;
                //Preencher o Modelo e gravar no BD
                for (int i = 0; i < x; i++)
                {
                    modelo.UsuId = Convert.ToInt32(UsuId);
                    modelo.NomeNivelfrm = Convert.ToString(dgvDados.Rows[i].Cells[1].Value);
                    modelo.DescricaoNivel = Convert.ToString(dgvDados.Rows[i].Cells[2].Value);
                    modelo.BloqueadoNivel = Convert.ToString(dgvDados.Rows[i].Cells[3].Value);
                    modelo.InserirNivel = Convert.ToString(dgvDados.Rows[i].Cells[4].Value);
                    modelo.AlterarNivel = Convert.ToString(dgvDados.Rows[i].Cells[5].Value);
                    modelo.ExcluirNivel = Convert.ToString(dgvDados.Rows[i].Cells[6].Value);
                    modelo.ImprimirNivel = Convert.ToString(dgvDados.Rows[i].Cells[7].Value);     
                    bll.Incluir(modelo);

                }
                MessageBox.Show("As permissões foram Cadastradas com sucesso!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.alterabotao(1);
                this.dgvDados.Rows.Clear();
                this.txtCodigo.Text = "";
                this.operacao = "";
                this.UsuId = 0;
                this.UsuLoginPesquisado = "";
                this.UsuNomePesquisado = "";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void chMBLO_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for(int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[3].Value = chMBLO.Checked;
            }
        }

        private void chMINS_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[4].Value = chMINS.Checked;
            }
        }

        private void chMALT_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[5].Value = chMALT.Checked;
            }
        }

        private void chMEXC_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[6].Value = chMEXC.Checked;
            }
        }

        private void chMIMP_CheckedChanged(object sender, EventArgs e)
        {
            int x = dgvDados.RowCount;
            for (int i = 0; i < x; i++)
            {
                dgvDados.Rows[i].Cells[7].Value = chMIMP.Checked;
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCodigo.Text = f.codigo.ToString();
                btnLocalizar_Click(sender, e);
                this.alterabotao(3);
            }
            else
            {
                this.alterabotao(1);
            }
            f.Dispose();
            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(dgvDados.Rows[0].Cells[0].Value) <= 0)
                {
                    dgvDados.Rows.Clear();
                    return;
                }
                DialogResult d = MessageBox.Show("Deseja excluir Todos as Permissões do Usuário Pesquisado?" +
                "\n\nAtenção!!! Sem as Permissões, o usuário não conseguira Acessar o Sistema", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
                if(d.ToString() == "Yes")
                {
                    DaoConexao cx = new DaoConexao(DadosDeConexao.StringDeConexao);
                    BLLNivelAcesso bll = new BLLNivelAcesso(cx);
                    bll.ExcluirTudo(UsuId);
                    dgvDados.Rows.Clear();
                    this.alterabotao(1);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Impossivel excluir o registro. \n O registro esta sem utilizado em outro local.");
                this.alterabotao(3);
            }
        }

        private void iconeencerar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
