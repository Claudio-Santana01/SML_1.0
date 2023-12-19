using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class LivroDAO
    {
        public bool SalvarLivroNoBanco(Livro novolivro)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VAIO\\Desktop\\P2.1\\P2\\SML 1.0.mdf\";Integrated Security=True;Connect Timeout=30")) // Verificar a connection
                {
                    connection.Open();

                    string query = "INSERT INTO Livros (Titulo, Autor, Resenha, Genero, Status, Nota, Favoritar, Capa) " +
                                   "VALUES (@Titulo, @Autor, @Resenha, @Genero, @Status, @Nota, @Favoritar, @Capa)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", novolivro.Titulo);
                        command.Parameters.AddWithValue("@Autor", novolivro.Autor);
                        command.Parameters.AddWithValue("@Resenha", novolivro.Resenha);
                        command.Parameters.AddWithValue("@Genero", novolivro.Genero);
                        command.Parameters.AddWithValue("@Status", novolivro.Status);
                        command.Parameters.AddWithValue("@Nota", novolivro.Nota);
                        command.Parameters.AddWithValue("@Favoritar", novolivro.Favoritar);
                        command.Parameters.AddWithValue("@Capa", novolivro.Capa);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Livro> ObterTodosLivros()
        {
            return ObterLivros("SELECT Capa, Titulo, Autor, Resenha, Genero, Status, Nota, Favorito FROM Livros");
        }
        public List<Livro> ObterLivrosFavoritos()
        {
            return ObterLivros("SELECT Capa, Titulo, Autor, Resenha, Genero, Status, Nota, Favorito FROM Livros WHERE Favorito = 1");
        }

        private List<Livro> ObterLivros(string query)
        {
            List<Livro> livros = new List<Livro>();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VAIO\\Desktop\\P2.1\\P2\\SML 1.0.mdf\";Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livro livro = new Livro
                            {
                                Capa = (byte[])reader["Capa"],
                                Titulo = reader["Titulo"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                Resenha = reader["Resenha"].ToString(),
                                Genero = reader["Genero"].ToString(),
                                Status = reader["Status"].ToString(),
                                Nota = Convert.ToDecimal(reader["Nota"]),
                                Favoritar = Convert.ToBoolean(reader["Favoritar"])
                            };

                            livros.Add(livro);
                        }
                    }
                }
            }

            return livros;
        }
    }
}

