using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    class PrescricaoMedica
    {
        int IDPrescricao { get; set; }
        int IDVeterinario{ get; set; }
        string Descricao { get; set; }
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }

        public PrescricaoMedica(int iDPrescricao, int iDVeterinario, string descricao, DateTime dataInicio, DateTime dataFim)
        {
            IDPrescricao = iDPrescricao;
            IDVeterinario = iDVeterinario;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public PrescricaoMedica(int iDPrescricao, int iDVeterinario, string descricao, DateTime dataInicio)
        {
            IDPrescricao = iDPrescricao;
            IDVeterinario = iDVeterinario;
            Descricao = descricao;
            DataInicio = dataInicio;
        }
    }
}
