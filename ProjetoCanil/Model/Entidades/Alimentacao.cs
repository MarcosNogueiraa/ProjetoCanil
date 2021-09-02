using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class Alimentacao
    {
        public int IDCachorro { get; set; } //number(6),
        public string IDAlimento { get; set; }//varchar2(60),
        public int IDPrescricao { get; set; } //number(9),
        public float Quantidade { get; set; } //number(9),
        public string UnidadeMedida { get; set; } //varchar2(3),

        public Alimentacao(int iDCachorro, string iDAlimento, int iDPrescricao, float quantidade, string unidadeMedida)
        {
            IDCachorro = iDCachorro;
            IDAlimento = iDAlimento;
            IDPrescricao = iDPrescricao;
            Quantidade = quantidade;
            UnidadeMedida = unidadeMedida;
        }

        public Alimentacao(int iDCachorro, string iDAlimento, float quantidade, string unidadeMedida)
        {
            IDCachorro = iDCachorro;
            IDAlimento = iDAlimento;
            Quantidade = quantidade;
            UnidadeMedida = unidadeMedida;
        }
    }
}
