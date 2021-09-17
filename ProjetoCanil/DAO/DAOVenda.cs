using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.DAO
{
    class DAOVenda
    {

        string con = "Server=localhost;Database=ProjetoCanil;User Id=ProjetoCanil;Password=123;";

        public Venda GetVendaPorIDCachorro(int idCachorro)
        {
            Venda venda = new Venda();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM VENDA ";
                    Query += "WHERE IDCachorro = '" + idCachorro + "' ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            venda.IDVenda = Convert.ToInt32(odbcDataReader["IDVenda"]);
                            venda.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            venda.IDPessoa = Convert.ToInt32(odbcDataReader["IDPessoa"]);
                            venda.IDReserva = Convert.ToInt32(odbcDataReader["IDReserva"]);
                            venda.DataCompra = Convert.ToDateTime(odbcDataReader["DataCompra"]);
                            venda.Valor = Convert.ToDouble(odbcDataReader["Valor"]);
                        }

                        return venda;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool CadastraVenda(Venda venda)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " ";
                    Query += "INSERT INTO VENDA ";
                    Query += "VALUES ((SELECT MAX(IDVenda)+1 FROM VENDA), "; //ID
                    Query += " '" + venda.IDCachorro + "', ";
                    Query += " '" + venda.IDPessoa + "', ";

                    if (venda.IDReserva != 0)
                        Query += " '" + venda.IDReserva+ "', ";
                    else
                        Query += " null, ";

                    Query += " '" + venda.DataCompra + "', ";
                    Query += " '" + venda.Valor+ "'); ";

                    //ATUALIZA DONO CACHORRO
                    Query += "UPDATE CACHORRO ";
                    Query += "  SET IDDono = '" + venda.IDPessoa + "' ";
                    Query += "      WHERE IDCachorro = '" + venda.IDCachorro + "' ;";


                    //if (venda.IDReserva != 0)
                    // {
                    //        Query += " DELETE FROM RESERVA ";
                    //        Query += " WHERE IDReserva = '" + venda.IDReserva + "' ;";
                    //}
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
