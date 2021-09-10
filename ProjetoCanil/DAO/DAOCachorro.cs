using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCanil.DAO
{
    class DAOCachorro
    {

        //string con = "Driver={Microsoft ODBC for Oracle}; Server=localhost;Uid=xe;Pwd=123;";
        //string con = "Driver=C:\\app\\Marcos\\product\\18.0.0\\dbhomeXE\\odbc\\mesg\\oraodbcus.msb; Server=localhost,1521; Database=ProjetoCanil; Uid=xe; Pwd=123;";
        string con = "Server=localhost;Database=ProjetoCanil;User Id=ProjetoCanil;Password=123;";
        public string GetNomeCachorroPorID(int id) 
        {        
            Cachorro cachorro = new Cachorro();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT NOME FROM CACHORRO ";
                    Query += "WHERE IDCachorro = '" + id + "' ;";


                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            cachorro.Nome = Convert.ToString(odbcDataReader["Nome"]);
                        }

                        return !string.IsNullOrEmpty(cachorro.Nome) ? cachorro.Nome : "";

                    }
                }
            }
            catch (Exception ex)
            {
                throw ;
            }



        }

        public Boolean CadastraCachorro(Cachorro cachorro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " ";
                    Query += "INSERT INTO Cachorro ";
                    Query += "VALUES ((SELECT MAX(IDCachorro)+1 FROM CACHORRO), "; //ID
                    Query += " '" + cachorro.IDPai + "', " ;
                    Query += " '" + cachorro.IDMae + "', ";
                    Query += " '" + cachorro.IDDono + "', ";
                    Query += " '" + cachorro.Nome + "', ";
                    Query += " '" + cachorro.DataNasc + "', ";
                    Query += " '" + cachorro.Pedigree + "'); ";

                    MessageBox.Show(Query);

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
