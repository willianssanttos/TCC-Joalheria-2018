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
    public class BLLSubCategoria
    {
        private DaoConexao conexao;
        public BLLSubCategoria(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }


            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            Daoobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório");
            }
            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            Daoobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            Daoobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            return Daoobj.Localizar(valor);
        }
        public DataTable LocalizarPorCategoria(int categoria)
        {
            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            return Daoobj.LocalizarPorCategoria(categoria);
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DaoSubCategoria Daoobj = new DaoSubCategoria(conexao);
            return Daoobj.CarregaModeloSubCategoria(codigo);
        }
    }
}
