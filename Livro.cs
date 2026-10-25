using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Biblioteca
{
    internal class Livro
    {
        

        public string Titulo { get;  private set; }
        public string Autor { get; private set; }
        public string Isbn { get; private set; }
        public bool Disponibilidade { get; private set; }

        public Livro(string titulo, string autor, string iSBN)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = iSBN;
            Disponibilidade = true;
        }




    }
}
