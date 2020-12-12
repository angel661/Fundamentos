using System;

namespace practica_2_POO
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPag { get; set; }
        public string Editorial { get; set; }
        public int PrestadoLibros { get; set; }
        public int TotaLibro { get; set; }

        public Libro(string titulo, string autor, int numero, string editorial, int prestado, int total)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPag = numero;
            Editorial = editorial;
            PrestadoLibros = prestado;
            TotaLibro = total;
        }
        public bool Prestamos()
        {
            bool prestamos = true;
            if (PrestadoLibros < TotaLibro)
            {
                PrestadoLibros++;
                Console.WriteLine("se presto un libro");
            }
            else
            {
                prestamos = false;
            }
            return prestamos;

        }
        public bool Devolucion()
        {
            bool devuelto = true;
            if (PrestadoLibros == 0)
            {
                devuelto = false;
            }
            else
            {
                PrestadoLibros--;
                Console.WriteLine("SE DEVOLVIO UN LIBRO");
            }
            return devuelto;
        }

        public string ToString()
        {
            return "NOMBRE DEL LIBRO ES " + Titulo + ",EL AUTOR ES " + Autor +
                " Y TIENE " + NumeroPag + " NUMERO DE PRESTADOS " + PrestadoLibros + " NUMERO DE LIBROS " + TotaLibro; ;
        }
    }
}
