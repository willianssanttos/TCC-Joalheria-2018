using DAO;
using Ferramentas;
using MODELO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFuncionario
    {
         private DaoConexao conexao;

         public BLLFuncionario(DaoConexao cx)
       {
           this.conexao = cx;
       }
       public void Incluir(ModeloFuncionario modelo)
       {
           if (modelo.FunNome.Trim().Length == 0)
           {
               throw new Exception("O nome do Funcionario é obrigatório");
           }
           if (modelo.FunCpf.Trim().Length == 0)
           {
               throw new Exception("O CPF do Funcionario é obrigatório");
           }
           if (Validacao.IsCpf(modelo.FunCpf) == false)
           {
               throw new Exception("O CPF é invalido");
           }

               if (modelo.FunRg.Trim().Length == 0)
               {
                   throw new Exception("O RG do Funcionario é obrigatório");
               }
               if (modelo.FunTelefone.Trim().Length == 0)
               {
                   throw new Exception("O telefone do Funcionario é obrigatório");
               }
               string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
               + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
               + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
               Regex re = new Regex(strRegex);
               if (!re.IsMatch(modelo.FunEmail))
               {
                   throw new Exception("Digite um email válido.");
               }

               DaoFuncionario DALobj = new DaoFuncionario(conexao);
               DALobj.Incluir(modelo);
           }
      
       public void Alterar(ModeloFuncionario modelo)
       {
           if (modelo.FunNome.Trim().Length == 0)
           {
               throw new Exception("O nome do Funcionario é obrigatório");
           }
           if (modelo.FunCpf.Trim().Length == 0)
           {
               throw new Exception("O CNPJ do Funcionario é obrigatório");
           }

           if (Validacao.IsCpf(modelo.FunCpf) == false)
           {
               throw new Exception("O CPF é invalido");
           }

           if (modelo.FunRg.Trim().Length == 0)
           {
               throw new Exception("O RG do Funcionario é obrigatório");
           }
           if (modelo.FunTelefone.Trim().Length == 0)
           {
               throw new Exception("O telefone do Funcionario é obrigatório");
           }

           string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
              + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
              + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
           Regex re = new Regex(strRegex);

           if (!re.IsMatch(modelo.FunEmail))
           {
               throw new Exception("Digite um email válido.");
           }

           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           DALobj.Alterar(modelo);
       }
       
       public void Excluir(int codigo)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           DALobj.Excluir(codigo);
       }

       public DataTable Localizar(String valor)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           return DALobj.Localizar(valor);
       }

       public DataTable LocalizarPorNome(String valor)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           return DALobj.LocalizarPorNome(valor);
       }

       public DataTable LocalizarPorCPF(String valor)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           return DALobj.LocalizarPorCPF(valor);
       }

       public ModeloFuncionario CarregaModeloFuncionario(int codigo)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           return DALobj.CarregaModeloFuncionario(codigo);
       }

       public ModeloFuncionario CarregaModeloFuncionario(string cpf)
       {
           DaoFuncionario DALobj = new DaoFuncionario(conexao);
           return DALobj.CarregaModeloFuncionario(cpf);
       }
    }
}
