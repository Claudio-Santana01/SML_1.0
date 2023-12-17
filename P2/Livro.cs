using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Resenha { get; set; }
        public byte[] Capa { get; set; } // Tipo de dado para armazenar imagens
        public string Genero { get; set; }
        public string Status { get; set; }
        public decimal Nota { get; set; }
        public bool Favoritar { get; set; }
    }
}
