using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Homepage : Form
    {
        int nroCapa = 0;
        private int qtdCapa = 0;
        private List<byte[]> capas;
        public Homepage()
        {
            InitializeComponent();
            qtdCapa = ObterQuantidadeCapasDoBanco();
            capas = ObterCapasDoBanco();
        }
        private int ObterQuantidadeCapasDoBanco()
         {
             try
             {
                 using (SqlConnection connection = new SqlConnection("sua_string_de_conexao"))
                 {
                     connection.Open();

                     string query = "SELECT COUNT(*) FROM Capas";

                     using (SqlCommand command = new SqlCommand(query, connection))
                     {
                         // ExecuteScalar retorna a primeira coluna da primeira linha no resultado da consulta
                         return Convert.ToInt32(command.ExecuteScalar());
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Erro ao obter quantidade de capas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return 0;
             }
         }
        private void lnkl_direita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
            nroCapa = (nroCapa + 1) % capas.Count;
            ExibirCapa(nroCapa);
        }

         private void lnkl_esquerda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
            nroCapa = (nroCapa - 1 + capas.Count) % capas.Count;
            ExibirCapa(nroCapa);
        }
 

        private List<byte[]> ObterCapasDoBanco()
        {
            List<byte[]> capas = new List<byte[]>();

            try
            {
                using (SqlConnection connection = new SqlConnection("sua_string_de_conexao"))
                {
                    connection.Open();

                    string query = "SELECT Capa FROM Capas";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0)) // Verifica se o campo Capa não é nulo
                                {
                                    byte[] capa = (byte[])reader["Capa"];
                                    capas.Add(capa);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter capas do banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return capas;
        }

        private void ExibirCapa(int indice)
        {
            if (capas.Count > 0 && indice >= 0 && indice < capas.Count)
            {
                using (MemoryStream ms = new MemoryStream(capas[indice]))
                {
                    pbox_capas.Image = Image.FromStream(ms);
                }
            }
        }

        private void adicionarLeituraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AdicionarLivro novaLeitura = new AdicionarLivro();
            novaLeitura.ShowDialog();
        }

        private void visualizarLeiturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizar_Livros verLivros = new Visualizar_Livros();
            verLivros.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Favoritos meusFavoritos = new Favoritos();   
            meusFavoritos.ShowDialog();*/
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FazerLogout();

            // Volte para a página de login
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Hide();
            this.Close();
        }
        private void ExibirLivroSelecionado()
        {
           /* // Obtém os dados do livro selecionado (substitua isso com a lógica apropriada)
            byte[] capaLivro = ObterCapaLivroSelecionado();
            string tituloLivro = ObterTituloLivroSelecionado();

            // Cria e configura o controle LivroControl
            ExibirLivro livroControl = new ExibirLivro();
            livroControl.LivroExibir(capaLivro, tituloLivro);

            panelLivros.Controls.Add(livroControl);*/
        }
        private void FazerLogout()
        {
           
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


