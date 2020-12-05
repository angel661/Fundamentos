using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librería.Libro;

namespace Ejercicio_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("123-1233-12356 ", "100 Años de Soledad ", "Gabriel García Márquez ", 341);
            Libro libro2 = new Libro("321-9423-51051 ", "El Principito ", "Antoine de Saint-Exupéry ", 246);

            Console.WriteLine(libro1);
            Console.WriteLine(libro2);

            if (libro1.NumeroPaginas > libro2.NumeroPaginas)
            {
                Console.WriteLine("El libro {0} tiene más páginas.", libro1.Titulo);
            }
            else if (libro1.NumeroPaginas < libro2.NumeroPaginas)
            {
                Console.WriteLine("El libro {0} tiene más páginas.", libro2.Titulo);
            }
            else
            {
                Console.WriteLine("Tienene el mismo número de páginas.");
            }
        }
    }
}
