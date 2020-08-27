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
    public class BLLNivelAcesso
    {
        private DaoConexao conexao;

        public BLLNivelAcesso(DaoConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloNivelAcesso modelo)
        {
            if (modelo.DescricaoNivel.Trim().Length == 0)
            {
                throw new Exception("A Descrição é obrigatório!!!");
            }
         
            DaoNivelAcesso DALobj = new DaoNivelAcesso(conexao);
            DALobj.Incluir(modelo);
        }
       
        public void ExcluirTudo(int codigo)
        {
            DaoNivelAcesso DALobj = new DaoNivelAcesso(conexao);
            DALobj.ExcluirTudo(codigo);
        }
        public DataTable Localizar(int codigo)
        {
            DaoNivelAcesso DALobj = new DaoNivelAcesso(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable LocalizarNivelAcesso(int idUsuario, string NomeFormulario)
        {
            DaoNivelAcesso DALobj = new DaoNivelAcesso(conexao);
            return DALobj.LocalizarNivelAcesso(idUsuario, NomeFormulario);
        }
        public ModeloNivelAcesso CarregaModeloNivelAcesso(int codigo)
        {
            DaoNivelAcesso DALobj = new DaoNivelAcesso(conexao);
            return DALobj.CarregaModeloNivelAcesso(codigo);
        }
    }
}
