using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.DAO
{
    class DAOReserva
    {
        string con = "Server=localhost;Database=ProjetoCanil;User Id=ProjetoCanil;Password=123;";

        public Reserva GetReservaPorIDCachorro(int idCachorro)
        {
            Reserva reserva = new Reserva();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM RESERVA ";
                    Query += "WHERE IDCachorro = '" + idCachorro + "' ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            reserva.IDReserva = Convert.ToInt32(odbcDataReader["IDReserva"]);
                            reserva.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            reserva.IDComprador = Convert.ToInt32(odbcDataReader["IDPessoa"]);
                            reserva.ValorAdiantamento = Convert.ToDouble(odbcDataReader["ValorAdiantamento"]);
                        }

                        return reserva;

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Reserva GetReservaPorID(int idReserva)
        {
            Reserva reserva = new Reserva();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM RESERVA ";
                    Query += "WHERE IDReserva = '" + idReserva + "' ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            reserva.IDReserva = Convert.ToInt32(odbcDataReader["IDReserva"]);
                            reserva.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            reserva.IDComprador = Convert.ToInt32(odbcDataReader["IDPessoa"]);
                            reserva.ValorAdiantamento = Convert.ToDouble(odbcDataReader["ValorAdiantamento"]);
                        }

                        return reserva;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Reserva> GetReservas()
        {
            List<Reserva> ListaReserva = new List<Reserva>();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM RESERVA ";
                    Query += "WHERE IDReserva NOT IN(SELECT ISNULL(IDReserva,0) FROM VENDA) ";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            Reserva reserva = new Reserva();
                             
                            reserva.IDReserva = Convert.ToInt32(odbcDataReader["IDReserva"]);
                            reserva.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            reserva.IDComprador = Convert.ToInt32(odbcDataReader["IDPessoa"]);
                            reserva.ValorAdiantamento = Convert.ToDouble(odbcDataReader["ValorAdiantamento"]);
                            
                            ListaReserva.Add(reserva);
                        }

                        return ListaReserva;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool CadastraReserva(Reserva reserva)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " ";
                    Query += "INSERT INTO Pessoa ";
                    Query += "VALUES ((SELECT MAX(IDPessoa)+1 FROM RESERVA), "; //ID
                    Query += " '" + reserva.IDCachorro + "', ";
                    Query += " '" + reserva.IDComprador + "', ";
                    Query += " '" + reserva.ValorAdiantamento + "') ";

                    //MessageBox.Show(Query);

                    //VALUES(000001, null, null, 000001, 'Fred', '21/03/2018', '12345678');

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }
}
