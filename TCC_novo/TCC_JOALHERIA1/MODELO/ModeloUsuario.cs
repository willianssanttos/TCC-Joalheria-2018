using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloUsuario
    {
         public ModeloUsuario()
        {
            this.UsuId = 0;
            this.UsuNome = "";
            this.UsuLogin = "";
            this.UsuGrupo = "";
            this.UsuSenha = "";
        }

         public ModeloUsuario(int usuid, String usunome, String usulogin, String usugrupo, String ususenha)
        {
            this.UsuId = usuid;
            this.UsuNome = usunome;
            this.UsuLogin = usulogin;
            this.UsuGrupo = usugrupo;
            this.UsuSenha = ususenha;
        }

        private int usu_id;
        public int UsuId
        {
            get { return this.usu_id; }
            set { this.usu_id = value; }
        }

        private String usu_nome;
        public String UsuNome
        {
            get { return this.usu_nome; }
            set { this.usu_nome = value; }
        }

        private String usu_login;
        public String UsuLogin
        {
            get { return this.usu_login; }
            set { this.usu_login = value; }
        }

        private String usu_grupo;
        public String UsuGrupo
        {
            get { return this.usu_grupo; }
            set { this.usu_grupo = value; }
        }

        private String usu_senha;
        public String UsuSenha
        {
            get { return this.usu_senha; }
            set { this.usu_senha = value; }
        }
    }
}
