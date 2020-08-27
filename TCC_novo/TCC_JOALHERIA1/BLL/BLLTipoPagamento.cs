using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using DAO;
using System.Data;

namespace BLL
{
    public class BLLTipoPagamento
    {
        private DaoConexao conexao;
        public BLLTipoPagamento(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da forma de pagamento  é obrigatório");
            }
            //modelo.TpaNome = modelo.TpaNome.ToUpper();

            DaoTipoPagamento DALobj = new DaoTipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código da forma de pagamento é obrigatório");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O nome da forma de pagamento é obrigatório");
            }
            //modelo.TpaNome = modelo.TpaNome.ToUpper();

            DaoTipoPagamento DALobj = new DaoTipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DaoTipoPagamento DALobj = new DaoTipoPagamento(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DaoTipoPagamento DALobj = new DaoTipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DaoTipoPagamento DALobj = new DaoTipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPagamento(codigo);
        }
    }
}
