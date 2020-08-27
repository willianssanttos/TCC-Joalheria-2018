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
    public class BLLItensVenda
    { 
        
        private DaoConexao conexao;

        public BLLItensVenda(DaoConexao cx)
        {
            this.conexao = cx;
        }
       
        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior de que zero");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior de que zero");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodosOsItens(int vencod)
        {
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            DALobj.ExcluirTodosOsItens(vencod);
        }
        
        public DataTable Localizar(int vencod)
        {
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            return DALobj.Localizar(vencod);
        }

         public ModeloItensVenda CarregaModeloItensVenda(int ItvCod, int VenCod, int ProCod)
        {
            DaoItensVenda DALobj = new DaoItensVenda(conexao);
            return DALobj.CarregaModeloItensVenda(ItvCod, VenCod, ProCod);
        }
         
    }
}
