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
    public class BLLParcelasCompra
    {
        private DaoConexao conexao;
        
        public BLLParcelasCompra(DaoConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {

            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void EfetuaPagamentoParcela(int ComCod, int PcoCod, DateTime dtpagto)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }
            if (dtpagto != null)
            {
                DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
                DALobj.EfetuaPagamentoParcela(ComCod, PcoCod, dtpagto);
            }
            else
            {
                throw new Exception("Data de pagamento obrigatória");
            }

        }
         
        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }

            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
            DALobj.Alterar(modelo);
        }
         
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
            DALobj.Excluir(modelo);
        }
         
        public void ExcluirTodasAsParcelas(int comcod)
        {
             if (comcod <= 0)
             {
                 throw new Exception("O código da parcela é obrigatório");
             }

             DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
             DALobj.ExcluirTodasAsParcelas(comcod);
         }
         
        public DataTable Localizar(int comcod)
        {
            if (comcod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }

            DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
            return DALobj.Localizar(comcod);
        }
        
        public ModeloParcelasCompra CarregaModeloPrcelasCompra(int PcoCod, int ComCod)
        {
            if (PcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }


            if (ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DaoParcelasCompra DALobj = new DaoParcelasCompra(conexao);
            return DALobj.CarregaModeloParcelasCompra(PcoCod,ComCod);
        }
    }
}
