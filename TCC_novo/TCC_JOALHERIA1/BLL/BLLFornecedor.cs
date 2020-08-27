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
    public class BLLFornecedor
    {
       private DaoConexao conexao;
       public BLLFornecedor(DaoConexao cx)
       {
           this.conexao = cx;
       }
       public void Incluir(ModeloFornecedor modelo)
       {
           if (modelo.ForNome.Trim().Length == 0)
           {
               throw new Exception("O nome do Fornecedor é obrigatório");
           }
           if (modelo.ForCnpj.Trim().Length == 0)
           {
               throw new Exception("O CNPJ do Fornecedor é obrigatório");
           }
           if (Validacao.IsCnpj(modelo.ForCnpj) == false)
           {
               throw new Exception("O CNPJ é invalido");
           }

               if (modelo.ForIe.Trim().Length == 0)
               {
                   throw new Exception("O IE do Fornecedor é obrigatório");
               }
               if (modelo.ForFone.Trim().Length == 0)
               {
                   throw new Exception("O telefone do Fornecedor é obrigatório");
               }
               string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
               + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
               + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
               Regex re = new Regex(strRegex);
               if (!re.IsMatch(modelo.ForEmail))
               {
                   throw new Exception("Digite um email válido.");
               }
          

               DaoFornecedor DALobj = new DaoFornecedor(conexao);
               DALobj.Incluir(modelo);
           }
      
       public void Alterar(ModeloFornecedor modelo)
       {
           if (modelo.ForNome.Trim().Length == 0)
           {
               throw new Exception("O nome do Fornecedor é obrigatório");
           }
           if (modelo.ForCnpj.Trim().Length == 0)
           {
               throw new Exception("O CNPJ do Fornecedor é obrigatório");
           }

           if (Validacao.IsCnpj(modelo.ForCnpj) == false)
           {
               throw new Exception("O CNPJ é invalido");
           }

           if (modelo.ForIe.Trim().Length == 0)
           {
               throw new Exception("O IE do Fornecedor é obrigatório");
           }
           if (modelo.ForFone.Trim().Length == 0)
           {
               throw new Exception("O telefone do Fornecedor é obrigatório");
           }
           string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
              + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
              + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
           Regex re = new Regex(strRegex);
           if (!re.IsMatch(modelo.ForEmail))
           {
               throw new Exception("Digite um email válido.");
           }

           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           DALobj.Alterar(modelo);
       }
       
       public void Excluir(int codigo)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           DALobj.Excluir(codigo);
       }

       public DataTable Localizar(String valor)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           return DALobj.Localizar(valor);
       }

       public DataTable LocalizarPorNome(String valor)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           return DALobj.LocalizarPorNome(valor);
       }

       public DataTable LocalizarPorCNPJ(String valor)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           return DALobj.LocalizarPorCNPJ(valor);
       }

       public ModeloFornecedor CarregaModeloFornecedor(int codigo)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           return DALobj.CarregaModeloFornecedor(codigo);
       }

       public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
       {
           DaoFornecedor DALobj = new DaoFornecedor(conexao);
           return DALobj.CarregaModeloFornecedor(cnpj);
       }
    }
}
