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
    public class BLLCategoria
    {
        private DaoConexao conexao;
        public BLLCategoria(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DaoCategoria DALobj = new DaoCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DaoCategoria DALobj = new DaoCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DaoCategoria DALobj = new DaoCategoria(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DaoCategoria DALobj = new DaoCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable loadComboBox()
        {
            DaoCategoria DALobj = new DaoCategoria(conexao);
            return DALobj.loadComboBox();
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DaoCategoria DALobj = new DaoCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
