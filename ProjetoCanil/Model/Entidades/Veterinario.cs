using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Veterinario
    {
        public int IDVeterinario { get; set; }
        public int CRM { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public int Bairro { get; set; }
        public int Rua { get; set; }
        public int NumeroCasa { get; set; }
        public string Celular { get; set; }

    }



}
