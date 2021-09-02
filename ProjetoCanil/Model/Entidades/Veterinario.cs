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
        public int RG { get; set; }
        public int CPF { get; set; }
        public int CEP { get; set; }
        public int Bairro { get; set; }
        public int Rua { get; set; }
        public int NumeroCasa { get; set; }
        public int Celular { get; set; }

        public Veterinario(int iDVeterinario, int cRM, string nome, int rG, int cPF, int cEP, int bairro, int rua, int numeroCasa, int celular)
        {
            IDVeterinario = iDVeterinario;
            CRM = cRM;
            Nome = nome;
            RG = rG;
            CPF = cPF;
            CEP = cEP;
            Bairro = bairro;
            Rua = rua;
            NumeroCasa = numeroCasa;
            Celular = celular;
        }

        public Veterinario(int iDVeterinario, int cRM, string nome, int cPF, int celular)
        {
            IDVeterinario = iDVeterinario;
            CRM = cRM;
            Nome = nome;
            CPF = cPF;
            Celular = celular;
        }


    }



}
