using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO
{
    class Libro
    {
        public Libro(string isbn, string titulo, string autor, int numeroPaginas)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
        string ISBN { get; set; }
        string Titulo{ get; set; }
        string Autor { get; set; }
        public int NumeroPaginas { set; get; }

        public override string ToString()
        {
            return string.Format("El libro {0} con ISBN: {1} creado por el autor: {2} tiene paginas {3}",Titulo,ISBN,Autor,NumeroPaginas);
        }
    }
}
