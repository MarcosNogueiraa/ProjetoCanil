using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Vacina
    {
        public int IDVacina { get; set; }
        public string NomeVacina { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Lote { get; set; }

    }
}
