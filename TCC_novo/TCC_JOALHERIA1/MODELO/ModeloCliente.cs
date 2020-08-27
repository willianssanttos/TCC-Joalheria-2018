using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloCliente
    {
        //construtores
        public ModeloCliente() //clitipo 0=> fisica 1=> juridica
        {
            this.CliCod = 0;
            this.CliTipo = "";
            this.Clidatacadastro = DateTime.Now;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliDtnascimento = DateTime.Now;
            this.CliSexo = "";
            this.CliRsocial = "";
            this.CliCep = "";
            this.CliLogradouro = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCelular = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }
        public ModeloCliente(int cod, string tipo, DateTime datacadastro, string nome, string cpfcnpj,
                             string rgie, DateTime dtnascimento, string sexo, string rsocial, 
                             string cep, string logradouro, string bairro, string fone, string celular, 
                             string email, string endnumero, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliTipo = tipo;
            this.Clidatacadastro = datacadastro;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfcnpj;
            this.CliRgIe = rgie;
            this.CliDtnascimento = dtnascimento;
            this.CliSexo = sexo;
            this.CliRsocial = rsocial;
            this.CliCep = cep;
            this.CliLogradouro = logradouro;
            this.CliBairro = bairro;
            this.CliFone = fone;
            this.CliCelular = celular;
            this.CliEmail = email;
            this.CliEndNumero = endnumero;
            this.CliCidade = cidade;
            this.CliEstado = estado;
        }
        //propriedades da classe

        private int cli_cod;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }
        private string cli_tipo;

        public string CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo  = value; }
        }
        private DateTime cli_datacadastro;

        public DateTime Clidatacadastro
        {
            get { return this.cli_datacadastro; }
            set { this.cli_datacadastro = value; }
        }
        private string cli_nome;

        public string CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }
        private string cli_cpfcnpj;

        public string CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }
        private string cli_rgie;

        public string CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private DateTime cli_dtnascimento;

        public DateTime CliDtnascimento
        {
            get { return this.cli_dtnascimento; }
            set { this.cli_dtnascimento = value; }
        }
        private string cli_sexo;

        public string CliSexo
        {
            get { return this.cli_sexo; }
            set { this.cli_sexo = value; }
        }
        private string cli_rsocial;

        public string CliRsocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }
        private string cli_cep;

        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }
        private string cli_logradouro;

        public string CliLogradouro
        {
            get { return this.cli_logradouro; }
            set { this.cli_logradouro = value; }
        }
        private string cli_bairro;

        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }
        private string cli_fone;

        public string CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }
        private string cli_cel;

        public string CliCelular
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }
        private string cli_email;

        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }
        private string cli_endnumero;

        public string CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }
        private string cli_cidade;

        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }
        private string cli_estado;

        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    }
}
