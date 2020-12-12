using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO
{
    class Libro
    {
        public long ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public Libro(long isbn, string titulo, string autor, int numero)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numero;
        }

        public string ToString()
        {
            return "El libro " + Titulo + " con " + ISBN + " creado por "
                + Autor + " tiene " + NumeroPaginas + " paginas";
        }
        public static String MayorPaginas(Libro n1, Libro n2)
        {
            string mayor = "";
            if (n1.NumeroPaginas > n2.NumeroPaginas)
            {
                Console.WriteLine("el quew tiene mas paginas es " + n1.Titulo + " con " + n1.NumeroPaginas);
                mayor = "el mayor es" + n1.Titulo + " con " + n1.NumeroPaginas;
            }
            else
            {
                Console.WriteLine("el quew tiene mas paginas es " + n2.Titulo + " con " + n2.NumeroPaginas);
                mayor = "el mayor es" + n2.Titulo + " con " + n2.NumeroPaginas;
            }
            return mayor;
        }
    }
}
