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
    public class DaoParcelasCompra
    {
        private DaoConexao conexao;

        public DaoParcelasCompra(DaoConexao cx)
        {
            this.conexao = cx;
        }
        
        public void Incluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelasvenda(ven_cod, pve_cod, pve_datavecto, pve_valor, pve_datapagto) values (@ven_cod,@pve_cod, @pve_datavecto,@pve_valor,@pve_datapagto);";
            cmd.Parameters.AddWithValue("@pve_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pve_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pve_datapagto", System.Data.SqlDbType.Date);
            if (modelo.PcoDataVecto == null)
            {
                cmd.Parameters["@pve_datapagto"].Value = DBNull.Value;
               
            }
            else
            {
                cmd.Parameters["@pve_datapagto"].Value = modelo.PcoDataVecto;
            }
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void EfetuaPagamentoParcela(int ComCod, int PcoCod, DateTime dtpagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelascompra set pco_datapagto = @pco_datapagto where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@pco_datapagto"].Value = dtpagto.Date;

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelascompra set pco_valor = @pco_valor, pco_datapagto = @pco_datapagto," +
                "pco_datavecto = @datavecto where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@pco_valor", modelo.PcoValor);
            cmd.Parameters.Add("@pco_datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters.Add("@pco_datavecto", System.Data.SqlDbType.Date);
            if (modelo.PcoDataPagto == null)
            {
                cmd.Parameters["@pco_datapagto"].Value = DBNull.Value;

            }
            else
            {
                cmd.Parameters["@pco_datapagto"].Value = modelo.PcoDataPagto;
            }

            cmd.Parameters["@pco_datavecto"].Value = modelo.PcoDataVecto;
                       

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
        
        public void Excluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra " +
                "where pco_cod = @pco_cod and com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@pco_cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", modelo.ComCod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodasAsParcelas(int comcod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra " +
                "where com_cod = @com_cod;";
            cmd.Parameters.AddWithValue("@com_cod", comcod);
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from parcelascompra where com_cod =" +
            comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelascompra where pco_cod = @pco_cod and com_cod = @com_cod ;";
            cmd.Parameters.AddWithValue("@pco_cod", PcoCod);
            cmd.Parameters.AddWithValue("@com_cod", ComCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = PcoCod;
                modelo.ComCod = ComCod;
                modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
                modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);

            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
    }
}
