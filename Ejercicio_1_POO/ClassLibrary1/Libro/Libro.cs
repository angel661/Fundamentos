using System;
using System.Collections.Generic;
using System.Text;

namespace Librería.Libro
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Libro(string isbn, string titulo, string autor, int numeropaginas) 
        {
            this.Titulo = titulo;
            this.Isbn = isbn;
            this.Autor = autor;
            this.NumeroPaginas = numeropaginas;
        }

        public override string ToString()
        {
            return "El libro " + Titulo + "con Isbn " + Isbn + "creado por el autor " + Autor + "tiene " + NumeroPaginas + "páginas." ;
        }
    }
}
