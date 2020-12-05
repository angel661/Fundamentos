using Ejercicio3_POO.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Libros libro = new Libros(150, 100);
            Console.WriteLine(libro.ToString());
        }
    }
}
