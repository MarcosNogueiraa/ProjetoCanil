using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Model.Entidades
{
    public class Cachorro
    {
       public int IDCachorro { get; set;}
       public int IDPai { get; set;}
       public  int IDMae { get; set;}
       public int IDDono { get; set;}
       public string Nome { get; set;}
       public DateTime DataNasc { get; set;}
       public string Pedigree { get; set;}

    }
}
