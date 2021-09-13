using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    public class Reserva
    {
        public int IDReserva { get; set; }
        public int IDCachorro { get; set; }
        public int IDComprador { get; set; }
        public double ValorAdiantamento { get; set; }
    }
}
