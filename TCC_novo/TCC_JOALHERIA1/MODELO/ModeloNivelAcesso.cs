using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloNivelAcesso
    {
       
        //Construtor vazio
        public ModeloNivelAcesso()
        {
            this.NivelId = 0;
            this.UsuId = 0;
            this.NomeNivelfrm = "";
            this.DescricaoNivel = "";
            this.BloqueadoNivel = "";
            this.InserirNivel = "";
            this.AlterarNivel = "";
            this.ExcluirNivel = "";
            this.ImprimirNivel = "";

        }

        //Conestrutor passando parametros
        public ModeloNivelAcesso(int codigo, int usu, String nome, String descricao, String bloqueado, String inserir, String alterar, String excluir, String imprimir)
        {
            this.NivelId = codigo;
            this.UsuId = usu;
            this.NomeNivelfrm = nome;
            this.DescricaoNivel = descricao;
            this.BloqueadoNivel = bloqueado;
            this.InserirNivel = inserir;
            this.AlterarNivel = alterar;
            this.ExcluirNivel = excluir;
            this.ImprimirNivel = imprimir;
        }

        //Propiedades da classe
        private int nivel_id;

        public int NivelId
        {
            get { return this.nivel_id; }
            set { this.nivel_id = value; }
        }

        private int cod_usu;

        public int UsuId
        {
            get { return this.cod_usu; }
            set { this.cod_usu = value; }
        }

        private string nome_nivelfrm;

        public string NomeNivelfrm
        {
            get { return this.nome_nivelfrm; }
            set { this.nome_nivelfrm = value; }
        }

        private string descricao_nivel;

        public string DescricaoNivel
        {
            get { return this.descricao_nivel; }
            set { this.descricao_nivel = value; }
        }

        private string bloqueado_nivel;

        public string BloqueadoNivel
        {
            get { return this.bloqueado_nivel; }
            set { this.bloqueado_nivel = value; }
        }

        private string inserir_nivel;

        public string InserirNivel
        {
            get { return this.inserir_nivel; }
            set { this.inserir_nivel = value; }
        }

        private string alterar_nivel;

        public string AlterarNivel
        {
            get { return this.alterar_nivel; }
            set { this.alterar_nivel = value; }
        }

        private string excluir_nivel;

        public string ExcluirNivel
        {
            get { return this.excluir_nivel; }
            set { this.excluir_nivel = value; }
        }

        private string imprimir_nivel;

        public string ImprimirNivel
        {
            get { return this.imprimir_nivel; }
            set { this.imprimir_nivel = value; }
        }
    }
}
