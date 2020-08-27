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
    public class BLLFormaPagamento
    {
        private DaoConexao conexao;
        public BLLFormaPagamento(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFormaPagamento modelo)
        {
            if (modelo.FpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da forma de pagamento é obrigatório");
            }
            //modelo.FpaNome = modelo.FpaNome.ToUpper();

            DaoFormaPagamento Daoobj = new DaoFormaPagamento(conexao);
            Daoobj.Incluir(modelo);
        }
        public void Alterar(ModeloFormaPagamento modelo)
        {
            if (modelo.FpaCod <= 0)
            {
                throw new Exception("O código da forma de pagamento é obrigatório");
            }
            if (modelo.FpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da forma de pagamento é obrigatório");
            }
            //modelo.FpaNome = modelo.FpaNome.ToUpper();

            DaoFormaPagamento Daoobj = new DaoFormaPagamento(conexao);
            Daoobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DaoFormaPagamento Daoobj = new DaoFormaPagamento(conexao);
            Daoobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DaoFormaPagamento Daoobj = new DaoFormaPagamento(conexao);
            return Daoobj.Localizar(valor);
        }
        public ModeloFormaPagamento CarregaModeloFormaPagamento(int codigo)
        {
            DaoFormaPagamento Daoobj = new DaoFormaPagamento(conexao);
            return Daoobj.CarregaModeloFormaPagamento(codigo);
        }
    }
}
