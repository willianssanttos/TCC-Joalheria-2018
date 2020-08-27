﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloTipoPagamento
    {
         public ModeloTipoPagamento()
        {
            this.TpaCod = 0;
            this.TpaNome = "";
        }

        public ModeloTipoPagamento(int tpacod, String nome)
        {
            this.TpaCod = tpacod;
            this.TpaNome = nome;
        }

        private int tpa_cod;
        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }
        private String tpa_nome;
        public String TpaNome
        {
            get { return this.tpa_nome; }
            set { this.tpa_nome = value; }
        }
    }
}
