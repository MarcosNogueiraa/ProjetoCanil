using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class VermifugoCachorro
    {
        int IDCachorro { get; set; }
        int IDVermifugo { get; set; }
        int IDVetResponsavel { get; set; }
        int IDPrescricao { get; set; }
        DateTime DataVermifugo { get; set; }

        public VermifugoCachorro(int iDCachorro, int iDVermifugo, int iDVetResponsavel, int iDPrescricao, DateTime dataVermifugo)
        {
            IDCachorro = iDCachorro;
            IDVermifugo = iDVermifugo;
            IDVetResponsavel = iDVetResponsavel;
            IDPrescricao = iDPrescricao;
            DataVermifugo = dataVermifugo;
        }

        public VermifugoCachorro(int iDCachorro, int iDVermifugo, int iDVetResponsavel, DateTime dataVermifugo)
        {
            IDCachorro = iDCachorro;
            IDVermifugo = iDVermifugo;
            IDVetResponsavel = iDVetResponsavel;
            DataVermifugo = dataVermifugo;
        }

        public VermifugoCachorro(int iDCachorro, int iDVermifugo, int iDVetResponsavel)
        {
            IDCachorro = iDCachorro;
            IDVermifugo = iDVermifugo;
            IDVetResponsavel = iDVetResponsavel;
        }
    }
}
