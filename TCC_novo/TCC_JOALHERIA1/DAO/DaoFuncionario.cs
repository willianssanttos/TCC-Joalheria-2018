using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoFuncionario
    {
        private DaoConexao conexao;

        public DaoFuncionario(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFuncionario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into funcionario(fun_datacadastro, fun_nome, fun_datanascimento, fun_cpf, fun_rg,"+
                                           "fun_sexo, fun_telefone, fun_celular, fun_email, fun_escolaridade, fun_dataadmissao, fun_carfun, fun_cep, fun_logradouro, fun_bairro," +
                                           "fun_cidade, fun_estado, fun_endnumero) values (@fun_datacadastro, @fun_nome, @fun_datanascimento, @fun_cpf, @fun_rg," +
                                           "@fun_sexo, @fun_telefone, @fun_celular, @fun_email, @fun_escolaridade, @fun_dataadmissao, @fun_carfun, @fun_cep, @fun_logradouro, @fun_bairro," +
                                           "@fun_cidade, @fun_estado, @fun_endnumero); select @@IDENTITY;";
            cmd.Parameters.Add("@fun_datacadastro", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_datacadastro"].Value = modelo.Fundatacadastro;
            cmd.Parameters.AddWithValue("@fun_nome", modelo.FunNome);
            cmd.Parameters.Add("@fun_datanascimento", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_datanascimento"].Value = modelo.Fundatanascimento;
            cmd.Parameters.AddWithValue("@fun_cpf", modelo.FunCpf);
            cmd.Parameters.AddWithValue("@fun_rg", modelo.FunRg);
            cmd.Parameters.AddWithValue("@fun_sexo", modelo.FunSexo);
            cmd.Parameters.AddWithValue("@fun_telefone", modelo.FunTelefone);
            cmd.Parameters.AddWithValue("@fun_celular", modelo.FunCelular);
            cmd.Parameters.AddWithValue("@fun_email", modelo.FunEmail);
            cmd.Parameters.AddWithValue("@fun_escolaridade", modelo.FunEscolaridade);
            cmd.Parameters.Add("@fun_dataadmissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_dataadmissao"].Value = modelo.Fundataadmissao;
            cmd.Parameters.AddWithValue("@fun_carfun", modelo.FunCarFun);
            cmd.Parameters.AddWithValue("@fun_cep", modelo.FunCep);
            cmd.Parameters.AddWithValue("@fun_logradouro", modelo.FunLogradouro);
            cmd.Parameters.AddWithValue("@fun_bairro", modelo.FunBairro);           
            cmd.Parameters.AddWithValue("@fun_cidade", modelo.FunCidade);
            cmd.Parameters.AddWithValue("@fun_estado", modelo.FunEstado);
            cmd.Parameters.AddWithValue("@fun_endnumero", modelo.FunEndNumero);
            conexao.Conectar();
            modelo.FunCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloFuncionario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update funcionario set fun_datacadastro = @fun_datacadastro, fun_nome = @fun_nome, fun_datanascimento = @fun_datanascimento, fun_cpf = @fun_cpf, fun_rg = @fun_rg," +
                                           "fun_sexo = @fun_sexo, fun_telefone = @fun_telefone, fun_celular = @fun_celular, fun_email = @fun_email, fun_escolaridade = @fun_escolaridade, fun_dataadmissao = @fun_dataadmissao, fun_carfun = @fun_carfun, fun_cep = @fun_cep, fun_logradouro = @fun_logradouro, fun_bairro = @fun_bairro," +
                                           "fun_cidade = @fun_cidade, fun_estado = @fun_estado, fun_endnumero = @fun_endnumero where fun_cod = @fun_cod;";
            cmd.Parameters.Add("@fun_datacadastro", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_datacadastro"].Value = modelo.Fundatacadastro;
            cmd.Parameters.AddWithValue("@fun_nome", modelo.FunNome);
            cmd.Parameters.Add("@fun_datanascimento", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_datanascimento"].Value = modelo.Fundatanascimento;
            cmd.Parameters.AddWithValue("@fun_cpf", modelo.FunCpf);
            cmd.Parameters.AddWithValue("@fun_rg", modelo.FunRg);
            cmd.Parameters.AddWithValue("@fun_sexo", modelo.FunSexo);
            cmd.Parameters.AddWithValue("@fun_telefone", modelo.FunTelefone);
            cmd.Parameters.AddWithValue("@fun_celular", modelo.FunCelular);
            cmd.Parameters.AddWithValue("@fun_email", modelo.FunEmail);
            cmd.Parameters.AddWithValue("@fun_escolaridade", modelo.FunEscolaridade);
            cmd.Parameters.Add("@fun_dataadmissao", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@fun_dataadmissao"].Value = modelo.Fundataadmissao;
            cmd.Parameters.AddWithValue("@fun_carfun", modelo.FunCarFun);
            cmd.Parameters.AddWithValue("@fun_cep", modelo.FunCep);
            cmd.Parameters.AddWithValue("@fun_logradouro", modelo.FunLogradouro);
            cmd.Parameters.AddWithValue("@fun_bairro", modelo.FunBairro);
            cmd.Parameters.AddWithValue("@fun_cidade", modelo.FunCidade);
            cmd.Parameters.AddWithValue("@fun_estado", modelo.FunEstado);
            cmd.Parameters.AddWithValue("@fun_endnumero", modelo.FunEndNumero);
            cmd.Parameters.AddWithValue("@fun_cod", modelo.FunCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from funcionario where fun_cod = @fun_cod;";
            cmd.Parameters.AddWithValue("@fun_cod", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from funcionario where fun_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {
            return Localizar(valor);
        }

        public DataTable LocalizarPorCPF(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from funcionario where fun_cpf like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo)
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcionario where fun_cod = @fun_cod";
            cmd.Parameters.AddWithValue("@fun_cod", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FunCod = Convert.ToInt32(registro["fun_cod"]);
                modelo.Fundatacadastro = Convert.ToDateTime(registro["fun_datacadastro"]);
                modelo.FunNome = Convert.ToString(registro["fun_nome"]);
                modelo.Fundatanascimento = Convert.ToDateTime(registro["fun_datanascimento"]);
                modelo.FunCpf = Convert.ToString(registro["fun_cpf"]);
                modelo.FunRg = Convert.ToString(registro["fun_rg"]);
                modelo.FunSexo = Convert.ToString(registro["fun_sexo"]);
                modelo.FunTelefone = Convert.ToString(registro["fun_telefone"]);
                modelo.FunCelular = Convert.ToString(registro["fun_celular"]);
                modelo.FunEmail = Convert.ToString(registro["fun_email"]);
                modelo.FunEscolaridade = Convert.ToString(registro["fun_escolaridade"]);
                modelo.Fundataadmissao = Convert.ToDateTime(registro["fun_dataadmissao"]);
                modelo.FunCarFun = Convert.ToString(registro["fun_carfun"]);
                modelo.FunCep = Convert.ToString(registro["fun_cep"]);
                modelo.FunLogradouro = Convert.ToString(registro["fun_logradouro"]);
                modelo.FunBairro = Convert.ToString(registro["fun_bairro"]);                            
                modelo.FunCidade = Convert.ToString(registro["fun_cidade"]);
                modelo.FunEstado = Convert.ToString(registro["fun_estado"]);
                modelo.FunEndNumero = Convert.ToString(registro["fun_endnumero"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloFuncionario CarregaModeloFuncionario(string cpf)
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcionario where fun_cpf = @fun_cpf";
            cmd.Parameters.AddWithValue("@fun_cpf", cpf);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FunCod = Convert.ToInt32(registro["fun_cod"]);
                modelo.Fundatacadastro = Convert.ToDateTime(registro["fun_datacadastro"]);
                modelo.FunNome = Convert.ToString(registro["fun_nome"]);
                modelo.Fundatanascimento = Convert.ToDateTime(registro["fun_datanascimento"]);
                modelo.FunCpf = Convert.ToString(registro["fun_cpf"]);
                modelo.FunRg = Convert.ToString(registro["fun_rg"]);
                modelo.FunSexo = Convert.ToString(registro["fun_sexo"]);
                modelo.FunTelefone = Convert.ToString(registro["fun_telefone"]);
                modelo.FunCelular = Convert.ToString(registro["fun_celular"]);
                modelo.FunEmail = Convert.ToString(registro["fun_email"]);
                modelo.FunEscolaridade = Convert.ToString(registro["fun_escolaridade"]);
                modelo.Fundataadmissao = Convert.ToDateTime(registro["fun_dataadmissao"]);
                modelo.FunCarFun = Convert.ToString(registro["fun_carfun"]);
                modelo.FunCep = Convert.ToString(registro["fun_cep"]);
                modelo.FunLogradouro = Convert.ToString(registro["fun_logradouro"]);
                modelo.FunBairro = Convert.ToString(registro["fun_bairro"]);
                modelo.FunCidade = Convert.ToString(registro["fun_cidade"]);
                modelo.FunEstado = Convert.ToString(registro["fun_estado"]);
                modelo.FunEndNumero = Convert.ToString(registro["fun_endnumero"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
