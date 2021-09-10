using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Pessoa
    {
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public int RG { get; set; }
        public int CPF { get; set; }
        public int CEP { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public int Celular { get; set; }

    }
}
