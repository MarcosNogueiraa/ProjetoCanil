using ProjetoCanil.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

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

        public Boolean CadastraPessoa(Pessoa pessoa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " ";
                    Query += "INSERT INTO Pessoa ";
                    Query += "VALUES ((SELECT MAX(IDPessoa)+1 FROM PESSOA), "; //ID
                    Query += " '" + pessoa.Nome+ "', ";
                    Query += " '" + pessoa.CPF+ "', ";
                    Query += " '" + pessoa.RG + "', ";
                    Query += " '" + pessoa.CEP+ "', ";
                    Query += " '" + pessoa.Bairro+ "', ";
                    Query += " '" + pessoa.Rua+ "', ";
                    Query += " '" + pessoa.NumeroCasa+ "', ";
                    Query += " '" + pessoa.Celular+ "') ";

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
