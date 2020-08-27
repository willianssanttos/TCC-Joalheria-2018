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
    public class DaoFormaPagamento
    {
        private DaoConexao conexao;
        public DaoFormaPagamento(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFormaPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into formapagamento(fpa_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.FpaNome);
            conexao.Conectar();
            modelo.FpaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloFormaPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update formapagamento set fpa_nome = @nome where fpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.FpaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.FpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from formapagamento where fpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from formapagmento where fpa_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFormaPagamento CarregaModeloFormaPagamento(int codigo)
        {
            ModeloFormaPagamento modelo = new ModeloFormaPagamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from formapagamento where fpa_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.FpaCod = Convert.ToInt32(registro["fpa_cod"]);
                modelo.FpaNome = Convert.ToString(registro["fpa_nome"]);      
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
