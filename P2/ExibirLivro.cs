using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class ExibirLivro : UserControl
    {
        public ExibirLivro()
        {
            InitializeComponent();
        }
        public void LivroExibir(byte[] capa, string titulo)
        {
            // Configurar o PictureBox com a capa do livro (converte de byte[] para Image)
            using (MemoryStream ms = new MemoryStream(capa))
            {
                pictureBoxCapaExibir.Image = Image.FromStream(ms);
            }

            // Configurar o Label com o título do livro
            lbl_titulo.Text = titulo;
        }
    }
}
