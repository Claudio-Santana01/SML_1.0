using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace P2
{
    public static class ConectarBD
    {
        public static SqlConnection ObterConexao()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VAIO\\Desktop\\P2.1\\P2\\SML 1.0.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection conexao = new SqlConnection(connectionString);
            return conexao;
        }

    }
}
