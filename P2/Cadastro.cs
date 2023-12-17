using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P2
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxt_confirme_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela '_SML_1_0DataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this._SML_1_0DataSet.Usuario);

        }

        private void data_NascimentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_NascimentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario novoUsuario = new Usuario
                {
                    Nome = nomeTextBox.Text,
                    Email = emailTextBox.Text,
                    DataNascimento = DateTime.ParseExact(data_NascimentoTextBox.Text, "dd/MM/yyyy", null),
                    Telefone = new string(telefoneTextBox.Text.Where(char.IsDigit).ToArray()),
                    Senha =senhaTextBox.Text
                };
            

                UsuarioDAO usuarioDAO = new UsuarioDAO("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VAIO\\Desktop\\P2.1\\P2\\SML 1.0.mdf\";Integrated Security=True;Connect Timeout=30");
                bool sucesso = usuarioDAO.InserirUsuario(novoUsuario);

                if (sucesso)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    login.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linklb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        } 
    }
}
