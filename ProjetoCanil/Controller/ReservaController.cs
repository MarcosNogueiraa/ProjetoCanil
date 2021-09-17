using ProjetoCanil.DAO;
using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCanil.Controller
{
    class ReservaController
    {
        DAOReserva daoreserva = new DAOReserva();

        public List<Reserva> GetReservas()
        {
            List<Reserva> ListaReserva = daoreserva.GetReservas();
            return ListaReserva;
        }

        public Reserva GetReservaPorID(int id)
        {
            Reserva reserva = daoreserva.GetReservaPorID(id);
            return reserva;
        }
    }
}
