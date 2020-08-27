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
    public class DaoUsuario
    {
        private DaoConexao conexao;

        public DaoUsuario(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(usu_nome, usu_login, usu_grupo, usu_senha) values (@usu_nome, @usu_login, @usu_grupo, @usu_senha); select @@IDENTITY;";
            //quando o valor for uma data para dados primitivos
            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            conexao.Conectar();
            modelo.UsuId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set usu_nome = @usu_nome, usu_login = @usu_login, @usu_grupo = usu_grupo, usu_senha = @usu_senha where usu_id = @usu_id;";
            cmd.Parameters.AddWithValue("@usu_id", modelo.UsuId);
            cmd.Parameters.AddWithValue("@usu_nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@usu_login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@usu_grupo", modelo.UsuGrupo);
            cmd.Parameters.AddWithValue("@usu_senha", modelo.UsuSenha);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where usu_id = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_id =" + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_nome like '%" + nome.ToString() + "%' OR usu_login like '%"
                + nome.ToString() + "&'", conexao.ObjetoConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public DataTable LocalizarUsuarioLogin(string usu_login, string usu_senha)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where usu_login ='" + usu_login.ToString() +
            "' COLLATE SQL_Latin1_General_CP1_CS_AS AND usu_senha ='" + usu_senha.ToString() + "'", conexao.StringConexao);
            da.Fill(tabela);
            da.Dispose();
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.UsuId = Convert.ToInt32(registro["usu_id"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuLogin = Convert.ToString(registro["usu_login"]);
                modelo.UsuGrupo = Convert.ToString(registro["usu_grupo"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public int VerificaSeJaExiste(string valor)
        {
            int resposta = 0; //0 - não existe
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao.ObjetoConexao;
            comando.CommandText = "SELECT * FROM usuario WHERE usu_login = @usu_login";
            comando.Parameters.AddWithValue("@usu_login", valor);
            conexao.Conectar();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                resposta = Convert.ToInt32(registro["usu_id"]);
            }
            conexao.Desconectar();
            return resposta;
        }
    }
}
