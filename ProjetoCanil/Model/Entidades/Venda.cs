using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Venda
    {
        public int IDVenda { get; set; }
        public int IDCachorro { get; set; }
        public int IDPessoa { get; set; }
        public int IDReserva { get; set; }
        public DateTime DataCompra { get; set; }
        public double Valor{ get; set; }
    }
}
