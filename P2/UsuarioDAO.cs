using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P2
{
    internal class UsuarioDAO
    {
        private string connectionString;

        public UsuarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool InserirUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Usuario (Nome, Email, Senha, [DataNascimento], Telefone) VALUES (@Nome, @Email, @Senha, @DataNascimento, @Telefone)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", usuario.Nome);
                        command.Parameters.AddWithValue("@Email", usuario.Email);
                        command.Parameters.AddWithValue("@Senha", usuario.Senha);
                        command.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                        command.Parameters.AddWithValue("@Telefone", usuario.Telefone);

                        int rowsAffected = command.ExecuteNonQuery();

                      
                        return rowsAffected > 0;
                 
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir usuário: {ex.Message}");
                return false;
            }
        }
    }
}
