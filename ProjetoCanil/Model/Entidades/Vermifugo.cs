using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Vermifugo
    {
        public int IDVermifugo { get; set; }
        public string NomeVermifugo { get; set; }
        public string Tipo { get; set; }

        public Vermifugo(int iDVermifugo, string nomeVermifugo, string tipo)
        {
            IDVermifugo = iDVermifugo;
            NomeVermifugo = nomeVermifugo;
            Tipo = tipo;
        }
    }
}
