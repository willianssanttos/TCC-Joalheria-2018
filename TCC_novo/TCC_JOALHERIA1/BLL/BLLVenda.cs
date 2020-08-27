using DAO;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVenda
    {
         private DaoConexao conexao;

         public BLLVenda(DaoConexao cx)
        {
            this.conexao = cx;
        }

         public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenData == DateTime.Now)
            {
                throw new Exception("A data da venda não corresponde a data atual");
            }
            if (modelo.VenNParcelas <= 0)
            {
                throw new Exception("O número de parcelas de ser maior do que zero");
            }
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O codigo do cliente deve ser informado");
            }
            if (modelo.VenTotal <=0)
            {
                throw new Exception("O valor da venda deve ser informado");
            }
             if (modelo.VenNFiscal <= 0)
             {
                 throw new Exception("O número da nota fiscal deve ser informado");
             }

            DaoVenda DALobj = new DaoVenda(conexao);
            DALobj.Incluir(modelo);
        }

         public void Alterar(ModeloVenda modelo)
         {

             if (modelo.VenCod <= 0)
             {
                 throw new Exception("O código da venda de ser maior do que zero");
             }
             if (modelo.VenNParcelas <= 0)
             {
                 throw new Exception("O número de parcelas de ser maior do que zero");
             }
             if (modelo.CliCod <= 0)
             {
                 throw new Exception("O codigo do cliente deve ser informado");
             }
             if (modelo.VenTotal <= 0)
             {
                 throw new Exception("O valor da venda deve ser informado");
             }

             DaoVenda DALobj = new DaoVenda(conexao);
             DALobj.Alterar(modelo);
         }

         public void Excluir(int codigo)
         {
             if (codigo <= 0)
             {
                 throw new Exception("O número deve ser maior do que zero");
             }

             DaoVenda DALobj = new DaoVenda(conexao);
             DALobj.Excluir(codigo);
         }

        public Boolean CancelarVenda(int codigo)
         {
            if (codigo <= 0)
             {
                 throw new Exception("O número deve ser maior do que zero");
             }

             DaoVenda DALobj = new DaoVenda(conexao);
             return DALobj.CancelarVenda(codigo);
            
         }

        public DataTable Localizar(int codigo)
        {
            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar()
        {
            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.Localizar();
        }

        public DataTable Localizar(String nome)
        {
            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.Localizar(nome);
        }

        public DataTable LocalizarPorParcelasEmAberto()
        {

            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.LocalizarPorParcelasEmAberto();
        }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            if (Codigo <= 0)
            {
                throw new Exception("O número deve ser maior do que zero");
            }

            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(Codigo);
        }

         public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DaoVenda DALobj = new DaoVenda(conexao);
            return DALobj.Localizar(dtinicial, dtfinal);
        }

         public ModeloVenda CarregaModeloVenda(int codigo)
         {
             if (codigo <= 0)
             {
                 throw new Exception("O número deve ser maior do que zero");
             }

             DaoVenda DALobj = new DaoVenda(conexao);
             return DALobj.CarregaModeloVenda(codigo);
         }
    }
}
