using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.Controller
{
    class PessoaController
    {
        DAOPessoa daopessoa = new DAOPessoa();

        public void CadastraPessoa(Pessoa pessoa)
        {
            if (daopessoa.CadastraPessoa(pessoa))
                MessageBox.Show("Pessoa cadastrada com sucesso");
        }

        public string GetNomePessoaPorID(int id)
        {
            return daopessoa.GetNomePessoaPorID(id);
        }

    }
}
