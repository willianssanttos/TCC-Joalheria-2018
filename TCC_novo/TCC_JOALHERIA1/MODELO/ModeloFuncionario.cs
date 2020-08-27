using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFuncionario
    {
         public ModeloFuncionario() 
        {
            this.FunCod = 0;
            this.Fundatacadastro = DateTime.Now;
            this.FunNome = "";
            this.Fundatanascimento = DateTime.Now;
            this.FunCpf = "";
            this.FunRg = "";
            this.FunSexo = "";
            this.FunTelefone = "";
            this.FunCelular = "";
            this.FunEmail = "";
            this.FunEscolaridade = "";
            this.Fundataadmissao = DateTime.Now;
            this.FunCarFun = "";
            this.FunCep = "";
            this.FunLogradouro = "";
            this.FunBairro = "";          
            this.FunCidade = "";
            this.FunEstado = "";
            this.FunEndNumero = "";

        }
        public ModeloFuncionario(int codigo, DateTime datacadastro, string nome, DateTime datanascimento, string cpf,   
                             string rg, string sexo, string telefone, string celular, string email, string escolaridade, DateTime dataadmissao, string carfun, 
                             string cep, string logradouro, string bairro, string cidade, string estado, string endnumero)
        {
            this.FunCod = codigo;
            this.Fundatacadastro = datacadastro;
            this.FunNome = nome;
            this.Fundatanascimento = datanascimento;
            this.FunCpf = cpf;
            this.FunRg = rg;
            this.FunSexo = sexo;
            this.FunTelefone = telefone;
            this.FunCelular = celular;
            this.FunEmail = email;
            this.FunEscolaridade = escolaridade;
            this.Fundataadmissao = dataadmissao;
            this.FunCarFun = carfun;
            this.FunCep = cep;
            this.FunLogradouro = logradouro;
            this.FunBairro = bairro;                       
            this.FunCidade = cidade;
            this.FunEstado = estado;
            this.FunEndNumero = endnumero;

        }
        //propriedades da classe

        private int Fun_cod;

        public int FunCod
        {
            get { return this.Fun_cod; }
            set { this.Fun_cod = value; }
        }
   
        private DateTime Fun_datacadastro;

        public DateTime Fundatacadastro
        {
            get { return this.Fun_datacadastro; }
            set { this.Fun_datacadastro = value; }
        }
        private string Fun_nome;

        public string FunNome
        {
            get { return this.Fun_nome; }
            set { this.Fun_nome = value; }
        }

        private DateTime Fun_datanascimento;

        public DateTime Fundatanascimento
        {
            get { return this.Fun_datanascimento; }
            set { this.Fun_datanascimento = value; }
        }

        private string Fun_cpf;

        public string FunCpf
        {
            get { return this.Fun_cpf; }
            set { this.Fun_cpf = value; }
        }
        private string Fun_rg;

        public string FunRg
        {
            get { return this.Fun_rg; }
            set { this.Fun_rg = value; }
        }

        private string Fun_sexo;

        public string FunSexo
        {
            get { return this.Fun_sexo; }
            set { this.Fun_sexo = value; }
        }

        private string Fun_telefone;

        public string FunTelefone
        {
            get { return this.Fun_telefone; }
            set { this.Fun_telefone = value; }
        }
        private string Fun_celular;

        public string FunCelular
        {
            get { return this.Fun_celular; }
            set { this.Fun_celular = value; }
        }
        private string Fun_email;

        public string FunEmail
        {
            get { return this.Fun_email; }
            set { this.Fun_email = value; }
        }

        private string Fun_escolaridade;

        public string FunEscolaridade
        {
            get { return this.Fun_escolaridade; }
            set { this.Fun_escolaridade = value; }
        }

        private DateTime Fun_dataadmissao;

        public DateTime Fundataadmissao
        {
            get { return this.Fun_dataadmissao; }
            set { this.Fun_dataadmissao = value; }
        }

        private string Fun_carfun;

        public string FunCarFun
        {
            get { return this.Fun_carfun; }
            set { this.Fun_carfun = value; }
        }

        private string Fun_cep;

        public string FunCep
        {
            get { return this.Fun_cep; }
            set { this.Fun_cep = value; }
        }
        private string Fun_logradouro;

        public string FunLogradouro
        {
            get { return this.Fun_logradouro; }
            set { this.Fun_logradouro = value; }
        }
        private string Fun_bairro;

        public string FunBairro
        {
            get { return this.Fun_bairro; }
            set { this.Fun_bairro = value; }
        }
   
        private string Fun_cidade;

        public string FunCidade
        {
            get { return this.Fun_cidade; }
            set { this.Fun_cidade = value; }
        }
        private string Fun_estado;

        public string FunEstado
        {
            get { return this.Fun_estado; }
            set { this.Fun_estado = value; }
        }

        private string Fun_endnumero;

        public string FunEndNumero
        {
            get { return this.Fun_endnumero; }
            set { this.Fun_endnumero = value; }
        }
    }
}
