using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.Controller
{
    class VendaController
    {
        DAOVenda daovenda = new DAOVenda();
        public void CadastraVenda(Venda venda)
        {
            if (daovenda.CadastraVenda(venda)) ;
            MessageBox.Show("Venda cadastrada com sucesso");
        }

    }
}
