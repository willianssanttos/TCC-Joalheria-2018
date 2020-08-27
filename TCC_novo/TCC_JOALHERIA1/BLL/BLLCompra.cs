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
    public class BLLCompra
    {
        private DaoConexao conexao;
        
        public BLLCompra (DaoConexao cx)
        {
            this.conexao = cx;
        }

         public void Incluir(ModeloCompra modelo)
        {
            if (modelo.ComData == DateTime.Now)
            {
                throw new Exception("A data da compra não corresponde a data atual");
            }
            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O número de parcelas de ser maior do que zero");
            }
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O codigo do fornecedor deve ser informado");
            }
            if (modelo.ComTotal <=0)
            {
                throw new Exception("O valor da compra deve ser informado");
            }

            DaoCompra DALobj = new DaoCompra(conexao);
            DALobj.Incluir(modelo);
        }

         public void Alterar(ModeloCompra modelo)
         {

             if (modelo.ComCod <=0)
             {
                 throw new Exception("O código da compra de ser maior do que zero");
             }
             if (modelo.ComNParcelas <= 0)
             {
                 throw new Exception("O número de parcelas de ser maior do que zero");
             }
             if (modelo.ForCod <= 0)
             {
                 throw new Exception("O codigo do fornecedor deve ser informado");
             }
             if (modelo.ComTotal <= 0)
             {
                 throw new Exception("O valor da compra deve ser informado");
             }

             DaoCompra DALobj = new DaoCompra(conexao);
             DALobj.Alterar(modelo);
         }

        public void Excluir(int codigo)
         {
             DaoCompra DALobj = new DaoCompra(conexao);
             DALobj.Excluir(codigo);
         }

         public DataTable Localizar(int codigo)
        {
            DaoCompra DALobj = new DaoCompra(conexao);
            return DALobj.Localizar(codigo);
        }

         public DataTable Localizar()
         {
             DaoCompra DALobj = new DaoCompra(conexao);
             return DALobj.Localizar();
         }

        public DataTable LocalizarPorParcelasEmAberto()
         {

             DaoCompra DALobj = new DaoCompra(conexao);
             return DALobj.LocalizarPorParcelasEmAberto();
         }

        public int QuantidadeParcelasNaoPagas(int Codigo)
        {
            DaoCompra DALobj = new DaoCompra(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(Codigo);
        }

         public DataTable Localizar(String nome)
         {
             DaoCompra DALobj = new DaoCompra(conexao);
             return DALobj.Localizar(nome);
         }

        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
         {
             DaoCompra DALobj = new DaoCompra(conexao);
             return DALobj.Localizar(dtinicial, dtfinal);
         }

         public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DaoCompra DALobj = new DaoCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}
