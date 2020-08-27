using DAO;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
         private DaoConexao conexao;

         public BLLUsuario(DaoConexao cx)
        {
            this.conexao = cx;
        }

         public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.UsuLogin.Trim().Length == 0)
            {
                throw new Exception("O Login deve ser informado");
            }
            if (modelo.UsuGrupo.Trim().Length == 0)
            {
                throw new Exception("O Grupo de Login deve ser informado");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O Nome deve ser informado");
            }
            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A Senha deve ser informado");
            }
           
            DaoUsuario DALobj = new DaoUsuario(conexao);
            DALobj.Incluir(modelo);
        }

         public void Alterar(ModeloUsuario modelo)
         {

             if (modelo.UsuId <= 0)
             {
                 throw new Exception("O codigo do usuario deve ser informado");
             }

             if (modelo.UsuLogin.Trim().Length == 0)
             {
                 throw new Exception("O Login deve ser informado");
             }
             if (modelo.UsuGrupo.Trim().Length == 0)
             {
                 throw new Exception("O Grupo de Login deve ser informado");
             }
             if (modelo.UsuNome.Trim().Length == 0)
             {
                 throw new Exception("O Nome deve ser informado");
             }
             if (modelo.UsuSenha.Trim().Length == 0)
             {
                 throw new Exception("A Senha deve ser informado");
             }
        
             DaoUsuario DALobj = new DaoUsuario(conexao);
             DALobj.Alterar(modelo);
         }

        public void Excluir(int codigo)
         {
             DaoUsuario DALobj = new DaoUsuario(conexao);
             DALobj.Excluir(codigo);
         }

        public DataTable Localizar(int codigo)
        {
            DaoUsuario DALobj = new DaoUsuario(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar(String nome)
        {
            DaoUsuario DALobj = new DaoUsuario(conexao);
            return DALobj.Localizar(nome);
        }

        public DataTable LocalizarUsuarioLogin(string login, string senha)
        {
            DaoUsuario DALobj = new DaoUsuario(conexao);
            return DALobj.LocalizarUsuarioLogin(login, senha);
        }

         public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DaoUsuario DALobj = new DaoUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }

         public int VerificaSeJaExiste(string valor)
         {
             DaoUsuario dal = new DaoUsuario(conexao);
             return dal.VerificaSeJaExiste(valor);
         }
    }
}
