using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DaoTipoPagamento
    {
        private DaoConexao conexao;
        public DaoTipoPagamento(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into formapagamento(tpa_nome) values (@nome);";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            conexao.Conectar();
            modelo.TpaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update formapagamento set tpa_nome = @nome where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from formapagamento where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from formapagamento where tpa_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            ModeloTipoPagamento modelo = new ModeloTipoPagamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from formapagamento where tpa_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.TpaNome = Convert.ToString(registro["tpa_nome"]);      
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
