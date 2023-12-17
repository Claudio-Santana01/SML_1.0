using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linklb_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro usuarios = new Cadastro();
            usuarios.ShowDialog();
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = txtb_usuario.Text;
            string senha = mtxt_senha.Text;

            if (AutenticarUsuario(usuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                Homepage homepage = new Homepage();
                homepage.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário inválido. Tente novamente.");
            }
        }
        private bool AutenticarUsuario(string usuario, string senha)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VAIO\\Desktop\\P2.1\\P2\\bin\\Debug\\SML 1.0.mdf\";Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para verificar as credenciais do usuário
                string query = "SELECT * FROM Usuario WHERE Nome = @Nome AND Senha = @Senha";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    Console.WriteLine(connection);
                    command.Parameters.AddWithValue("@Nome", usuario);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        return reader.HasRows;
                    }

                }
            }
        }
    }
}
