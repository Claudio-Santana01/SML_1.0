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
using System.Windows.Forms.VisualStyles;

namespace P2
{
    public partial class AdicionarLivro : Form
    {
        public AdicionarLivro()
        {
            InitializeComponent();
        }

        private void AdicionarLivro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro novoLivro = new Livro()
                {
                    Titulo = txt_titulo.Text,
                    Autor = txt_autor.Text,
                    Resenha = txt_resenha.Text,
                    Genero = comboBoxGenero.SelectedItem?.ToString(),
                    Status = comboBoxStatus.SelectedItem?.ToString(),
                    Nota = numericUpDownNota.Value,
                    Favoritar = radioButtonFavoritar.Checked,
                };

                if (pictureBoxCapa.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxCapa.Image.Save(ms, pictureBoxCapa.Image.RawFormat);
                        novoLivro.Capa = ms.ToArray();
                    }
                }

                LivroDAO livroDAO = new LivroDAO();
                bool sucesso = livroDAO.SalvarLivroNoBanco(novoLivro); // Passa o objeto novoLivro para o método

                if (sucesso)
                {
                    MessageBox.Show("Livro Adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao Adicionar Livro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Adicionar Livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnInserirCapa_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Selecione uma imagem para a capa do livro";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Define a imagem selecionada no PictureBox
                    pictureBoxCapa.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
    }
