using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using DAO;
using System.Data;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
   public class BLLCliente
    {
       private DaoConexao conexao;
       public BLLCliente(DaoConexao cx)
       {
           this.conexao = cx;
       }
       public void Incluir(ModeloCliente modelo)
       {
           if (modelo.CliNome.Trim().Length == 0)
           {
               throw new Exception("O nome do cliente é obrigatório");
           }
           if (modelo.CliCpfCnpj.Trim().Length == 0)
           {
               throw new Exception("O CPF/CNPJ do cliente é obrigatório");
           }

           if (modelo.CliTipo == "Fisica")
           {
               //cpf
               if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
               {
                   throw new Exception("O CPF invalido");
               }
           }
           else
           {
               //cnpj
              
           }

               if (modelo.CliRgIe.Trim().Length == 0)
               {
                   throw new Exception("O RG/IE do cliente é obrigatório");
               }
               if (modelo.CliFone.Trim().Length == 0)
               {
                   throw new Exception("O telefone do cliente é obrigatório");
               }
               string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
               + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
               + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
               Regex re = new Regex(strRegex);
               if (!re.IsMatch(modelo.CliEmail))
               {
                   throw new Exception("Digite um email válido.");
               }
          

               DaoCliente DALobj = new DaoCliente(conexao);
               DALobj.Incluir(modelo);
           }
      
       public void Alterar(ModeloCliente modelo)
       {
           if (modelo.CliNome.Trim().Length == 0)
           {
               throw new Exception("O nome do cliente é obrigatório");
           }
           if (modelo.CliCpfCnpj.Trim().Length == 0)
           {
               throw new Exception("O CPF/CNPJ do cliente é obrigatório");
           }

           //verificar CPF/CNPJ

           if (modelo.CliRgIe.Trim().Length == 0)
           {
               throw new Exception("O RG/IE do cliente é obrigatório");
           }
           if (modelo.CliFone.Trim().Length == 0)
           {
               throw new Exception("O telefone do cliente é obrigatório");
           }
           string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
              + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
              + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
           Regex re = new Regex(strRegex);
           if (!re.IsMatch(modelo.CliEmail))
           {
               throw new Exception("Digite um email válido.");
           }

           DaoCliente DALobj = new DaoCliente(conexao);
           DALobj.Alterar(modelo);
       }
       
       public void Excluir(int codigo)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           DALobj.Excluir(codigo);
       }

       public DataTable Localizar(String valor)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           return DALobj.Localizar(valor);
       }

       public DataTable LocalizarPorNome(String valor)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           return DALobj.LocalizarPorNome(valor);
       }

       public DataTable LocalizarPorCPFCNPJ(String valor)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           return DALobj.LocalizarPorCPFCNPJ(valor);
       }

       public ModeloCliente CarregaModeloCliente(int codigo)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           return DALobj.CarregaModeloCliente(codigo);
       }

       public ModeloCliente CarregaModeloCliente(string cpfcnpj)
       {
           DaoCliente DALobj = new DaoCliente(conexao);
           return DALobj.CarregaModeloCliente(cpfcnpj);
       }
    }
}
