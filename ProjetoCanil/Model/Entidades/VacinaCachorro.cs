using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class VacinaCachorro
    {
        int IDCachorro { get; set; }
        int IDVacina { get; set; }
        int IDVetResponsavel{ get; set; }
        int IDPrescricao { get; set; }
        DateTime DataVacina{ get; set; }
        public VacinaCachorro(int iDCachorro, int iDVacina, int iDVetResponsavel, int iDPrescricao, DateTime dataVacina)
        {
            IDCachorro = iDCachorro;
            IDVacina = iDVacina;
            IDVetResponsavel = iDVetResponsavel;
            IDPrescricao = iDPrescricao;
            DataVacina = dataVacina;
        }
        public VacinaCachorro(int iDCachorro, int iDVacina, int iDVetResponsavel, DateTime dataVacina)
        {
            IDCachorro = iDCachorro;
            IDVacina = iDVacina;
            IDVetResponsavel = iDVetResponsavel;
            DataVacina = dataVacina;
        }

    }
}
