using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Visualizar_Livros : Form
    {
        public Visualizar_Livros()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
            this.Close();
        }
      

        private void Visualizar_Livros_Load(object sender, EventArgs e)
        {

        }
    }
    
}
