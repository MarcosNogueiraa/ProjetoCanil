using ProjetoCanil.Logs;
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
        LogCadastro logCadastro = new LogCadastro();

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

        public List<Cachorro> GetCachorros()
        {
            List<Cachorro> ListaCachorro = new List<Cachorro>();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM CACHORRO ";


                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {

                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            Cachorro cachorro = new Cachorro();

                            cachorro.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            cachorro.IDPai = Convert.ToInt32(odbcDataReader["IDPai"]);
                            cachorro.IDMae = Convert.ToInt32(odbcDataReader["IDMae"]);
                            cachorro.IDDono = Convert.ToInt32(odbcDataReader["IDDono"]);
                            cachorro.Nome = Convert.ToString(odbcDataReader["Nome"]);
                            cachorro.DataNasc = Convert.ToDateTime(odbcDataReader["DataNasc"]);
                            cachorro.Pedigree = Convert.ToString(odbcDataReader["Pedigree"]);

                            ListaCachorro.Add(cachorro);
                        }

                        return ListaCachorro;

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Cachorro GetCachorroPorID(int id)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT * FROM CACHORRO ";
                    Query += "WHERE IDCachorro = '" + id + "' ;";



                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        Cachorro cachorro = new Cachorro();

                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {

                            cachorro.IDCachorro = Convert.ToInt32(odbcDataReader["IDCachorro"]);
                            cachorro.IDPai = Convert.ToInt32(odbcDataReader["IDPai"]);
                            cachorro.IDMae = Convert.ToInt32(odbcDataReader["IDMae"]);
                            cachorro.IDDono = Convert.ToInt32(odbcDataReader["IDDono"]);
                            cachorro.Nome = Convert.ToString(odbcDataReader["Nome"]);
                            cachorro.DataNasc = Convert.ToDateTime(odbcDataReader["DataNasc"]);
                            cachorro.Pedigree = Convert.ToString(odbcDataReader["Pedigree"]);

                        }

                        return cachorro;

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ExcluiCachorroPorID(int id)
        {
            Cachorro cachorro = new Cachorro();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "DELETE FROM CACHORRO ";
                    Query += "WHERE IDCachorro = '" + id + "' ;";


                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                    }
                }

                logCadastro.Log("Cachorro " + cachorro.Nome + " excluído.");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void AtualizaCachorro(Cachorro cachorro)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "UPDATE CACHORRO ";
                    Query += "SET IDPai =  '" + cachorro.IDPai.ToString() + "' , ";
                    Query += "    IDMae =  '" + cachorro.IDMae.ToString() + "' , ";
                    Query += "    IDDono =  '" + cachorro.IDDono.ToString() + "' , ";
                    Query += "    Nome =  '" + cachorro.Nome.ToString() + "' , ";
                    Query += "    DataNasc =  '" + cachorro.DataNasc.ToString() + "' , ";
                    Query += "    Pedigree =  '" + cachorro.Pedigree.ToString() + "'  ";        
                    Query += "WHERE IDCachorro = "+ cachorro.IDCachorro.ToString() + " ;";


                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                    }
                    logCadastro.Log("Cachorro " + cachorro.Nome + " atualizado.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool CadastraCachorro(Cachorro cachorro)
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

                    // MessageBox.Show(Query);

                    //VALUES(000001, null, null, 000001, 'Fred', '21/03/2018', '12345678');

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                    }
                    logCadastro.Log("Cachorro " + cachorro.Nome + " cadastrado.");

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
