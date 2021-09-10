using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjetoCanil.DAO
{
    class DAOPessoa
    {
        string con = "Server=localhost;Database=ProjetoCanil;User Id=ProjetoCanil;Password=123;";

        public string GetNomePessoaPorID(int id)
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT NOME FROM PESSOA ";
                    Query += "WHERE IDPessoa = '"+ id +"' ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            pessoa.Nome = Convert.ToString(odbcDataReader["Nome"]);
                        }

                        return !string.IsNullOrEmpty(pessoa.Nome) ? pessoa.Nome : "";

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }



        }

    }
}
