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
    public class BLLParcelasVenda
    {
        private DaoConexao conexao;
        
        public BLLParcelasVenda(DaoConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {

            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void EfetuaRecebimentoParcela(int venCod, int pveCod, DateTime dtRecebimento)
        {
            if (pveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (venCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (dtRecebimento != null)
            {
                DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
                DALobj.EfetuaRecebimentoParcela(venCod, pveCod, dtRecebimento);
            }
            else
            {
                throw new Exception("Data do recebimento obrigatória");
            }

        }
         
        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }
         
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }
         
        public void ExcluirTodasAsParcelas(int comcod)
        {
             if (comcod <= 0)
             {
                 throw new Exception("O código da parcela é obrigatório");
             }

             DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
             DALobj.ExcluirTodasAsParcelas(comcod);
         }
         
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
            return DALobj.Localizar(comcod);
        }
        
        public ModeloParcelasVenda CarregaModeloPrcelasVenda(int PveCod, int VenCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }


            if (VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DaoParcelasVenda DALobj = new DaoParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(PveCod,VenCod);
        }
    }
}
