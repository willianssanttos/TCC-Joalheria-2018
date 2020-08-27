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
    public class BLLUnidadeDeMedida
    {
        private DaoConexao conexao;
        public BLLUnidadeDeMedida(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            Daoobj.Incluir(modelo);
        }
        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            Daoobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            Daoobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            return Daoobj.Localizar(valor);
        }
        public int VerificaUnidadeDeMedida(String valor) //0 - não existe || numero > 0 existe
        {
            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            return Daoobj.VerificaUnidadeDeMedida(valor);
        }
        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DaoUnidadeDeMedida Daoobj = new DaoUnidadeDeMedida(conexao);
            return Daoobj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
