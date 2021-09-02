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

        public Vacina(int iDVacina, string nomeVacina, DateTime dataFabricacao, string lote)
        {
            IDVacina = iDVacina;
            NomeVacina = nomeVacina;
            DataFabricacao = dataFabricacao;
            Lote = lote;
        }
    }
}
