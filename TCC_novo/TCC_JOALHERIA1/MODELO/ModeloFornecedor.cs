using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFornecedor
    {
         public ModeloFornecedor() //clitipo 0=> fisica 1=> juridica
        {
            this.ForCod = 0;
            this.Fordatacadastro = DateTime.Now;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRsocial = "";
            this.ForCep = "";
            this.ForLogradouro = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCelular = "";
            this.ForEmail = "";
            this.ForEndNumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }
        public ModeloFornecedor(int cod, DateTime datacadastro, string nome, string cnpj,   
                             string ie, string rsocial, string cep, string logradouro, string bairro, string fone, string celular, 
                             string email, string endnumero, string cidade, string estado)
        {
            this.ForCod = cod;
            this.Fordatacadastro = datacadastro;
            this.ForNome = nome;
            this.ForCnpj = cnpj;
            this.ForIe = ie;
            this.ForRsocial = rsocial;
            this.ForCep = cep;
            this.ForLogradouro = logradouro;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCelular = celular;
            this.ForEmail = email;
            this.ForEndNumero = endnumero;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }
        //propriedades da classe

        private int for_cod;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }
   
        private DateTime for_datacadastro;

        public DateTime Fordatacadastro
        {
            get { return this.for_datacadastro; }
            set { this.for_datacadastro = value; }
        }
        private string for_nome;

        public string ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }
        private string for_cnpj;

        public string ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }
        private string for_ie;

        public string ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private string for_rsocial;

        public string ForRsocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }
        private string for_cep;

        public string ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }
        private string for_logradouro;

        public string ForLogradouro
        {
            get { return this.for_logradouro; }
            set { this.for_logradouro = value; }
        }
        private string for_bairro;

        public string ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }
        private string for_fone;

        public string ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }
        private string for_cel;

        public string ForCelular
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }
        private string for_email;

        public string ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }
        private string for_endnumero;

        public string ForEndNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }
        private string for_cidade;

        public string ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }
        private string for_estado;

        public string ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }
    }
}
