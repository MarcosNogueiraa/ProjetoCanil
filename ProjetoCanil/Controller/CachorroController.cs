using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.Controller
{
    public class CachorroController
    {
        DAOCachorro daocachorro = new DAOCachorro();
        public void CadastraCachorro(Cachorro cachorro)
        {
            if (daocachorro.CadastraCachorro(cachorro))
                MessageBox.Show("Cachorro cadastrado com sucesso");
        }

        public List<Cachorro> GetCachorros()
        {
            return daocachorro.GetCachorros();
        }

        public Cachorro GetCachorroPorID(int id)
        {
            return daocachorro.GetCachorroPorID(id);
        }

        public void AtualizaCachorro(Cachorro cachorro)
        {
            daocachorro.AtualizaCachorro(cachorro);
            MessageBox.Show("Cachorro atualizado com sucesso");

        }
        public string GetNomeCachorroPorID(int id)
        {
           return daocachorro.GetNomeCachorroPorID(id);
        }

        public void ExcluiCachorroPorID(int id)
        {
            daocachorro.ExcluiCachorroPorID(id);
            MessageBox.Show("Cachorro excluído com sucesso");

        }
    }

}
