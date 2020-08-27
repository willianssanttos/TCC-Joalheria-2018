using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloFormaPagamento
    {
         public ModeloFormaPagamento()
        {
            this.FpaCod = 0;
            this.FpaNome = "";
        }

         public ModeloFormaPagamento(int fpacod, String nome)
        {
            this.FpaCod = fpacod;
            this.FpaNome = nome;
        }

        private int fpa_cod;
        public int FpaCod
        {
            get { return this.fpa_cod; }
            set { this.fpa_cod = value; }
        }
        private String fpa_nome;
        public String FpaNome
        {
            get { return this.fpa_nome; }
            set { this.fpa_nome = value; }
        }
    }
}
