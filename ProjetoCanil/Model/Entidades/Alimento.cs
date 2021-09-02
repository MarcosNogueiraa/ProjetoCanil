using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Alimento
    {
        public int IDAlimento { get; set; }
        public string Tipo{ get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        public Alimento(int iDAlimento, string tipo, string nome, string fabricante)
        {
            IDAlimento = iDAlimento;
            Tipo = tipo;
            Nome = nome;
            Fabricante = fabricante;
        }

        public Alimento(int iDAlimento, string tipo, string nome)
        {
            IDAlimento = iDAlimento;
            Tipo = tipo;
            Nome = nome;
        }

        public Alimento(int iDAlimento, string nome)
        {
            IDAlimento = iDAlimento;
            Nome = nome;
        }
    }
}
