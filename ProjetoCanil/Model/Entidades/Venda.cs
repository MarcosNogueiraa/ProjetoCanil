using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Venda
    {
        int IDVenda { get; set; }
        int IDCachorro { get; set; }
        int IDPessoa { get; set; }
        int IDReserva { get; set; }
        DateTime DataCompra { get; set; }

        public Venda(int iDVenda, int iDCachorro, int iDPessoa, int iDReserva, DateTime dataCompra)
        {
            IDVenda = iDVenda;
            IDCachorro = iDCachorro;
            IDPessoa = iDPessoa;
            IDReserva = iDReserva;
            DataCompra = dataCompra;
        }

        public Venda(int iDVenda, int iDCachorro, int iDPessoa, DateTime dataCompra)
        {
            IDVenda = iDVenda;
            IDCachorro = iDCachorro;
            IDPessoa = iDPessoa;
            DataCompra = dataCompra;
        }
    }
}
