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
    public class DaoNivelAcesso
    {
        private DaoConexao conexao;

        public DaoNivelAcesso(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloNivelAcesso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into nivelacesso(usu_id, nome_nivelfrm, descricao_nivel, bloqueado_nivel, inserir_nivel, alterar_nivel, excluir_nivel, imprimir_nivel) values (@usu_id, @nome_nivelfrm, @descricao_nivel, @bloqueado_nivel, @inserir_nivel, @alterar_nivel, @excluir_nivel, @imprimir_nivel); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@usu_id", modelo.UsuId);
            cmd.Parameters.AddWithValue("@nome_nivelfrm", modelo.NomeNivelfrm);
            cmd.Parameters.AddWithValue("@descricao_nivel", modelo.DescricaoNivel);
            cmd.Parameters.AddWithValue("@bloqueado_nivel", modelo.BloqueadoNivel);
            cmd.Parameters.AddWithValue("@inserir_nivel", modelo.InserirNivel);
            cmd.Parameters.AddWithValue("@alterar_nivel", modelo.AlterarNivel);
            cmd.Parameters.AddWithValue("@excluir_nivel", modelo.ExcluirNivel);
            cmd.Parameters.AddWithValue("@imprimir_nivel", modelo.ImprimirNivel);
            conexao.Conectar();
            modelo.NivelId = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
      
        public void ExcluirTudo(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM nivelacesso WHERE usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT n.usu_id, n.nome_nivelfrm, n.descricao_nivel, n.bloqueado_nivel, n.inserir_nivel, n.alterar_nivel, n.excluir_nivel, n.imprimir_nivel," +
                "u.usu_nome, u.usu_login, u.usu_id FROM usuario u inner join nivelacesso n on u.usu_id = n.usu_id where u.usu_id =" + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarNivelAcesso(int idUsuario, string NomeFormulario) //Localizar para apagar a Permissão do Usuario para ser utilizado nos Formularios.
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT n.nivel_id, n.usu_id, u.usu_login, n.nome_nivelfrm, n.bloqueado_nivel, n.inserir_nivel, n.alterar_nivel, n.excluir_nivel," + 
               " n.imprimir_nivel FROM usuario u inner join nivelacesso n on u.usu_id = n.usu_id where n.nome_nivelfrm = '"+ NomeFormulario.ToString() + "' and n.usu_id =" + idUsuario.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloNivelAcesso CarregaModeloNivelAcesso(int codigo)
        {
            ModeloNivelAcesso modelo = new ModeloNivelAcesso();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM nivelacesso WHERE usu_id = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.NivelId = Convert.ToInt32(registro["nivel_id"]);
                modelo.UsuId = Convert.ToInt32(registro["usu_id"]);
                modelo.NomeNivelfrm = Convert.ToString(registro["nome_nivelfrm"]);
                modelo.DescricaoNivel = Convert.ToString(registro["descricao_nivel"]);
                modelo.BloqueadoNivel = Convert.ToString(registro["bloqueado_nivel"]);
                modelo.InserirNivel = Convert.ToString(registro["inserir_nivel"]);
                modelo.AlterarNivel = Convert.ToString(registro["alterar_nivel"]);
                modelo.ExcluirNivel = Convert.ToString(registro["excluir_nivel"]);
                modelo.ImprimirNivel = Convert.ToString(registro["imprimir_nivel"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
