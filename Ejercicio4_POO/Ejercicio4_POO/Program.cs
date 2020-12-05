using Ejercicio4_POO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion fraccion1 = new Fraccion((10/2), (5/3));
            Fraccion fraccion2 = new Fraccion((8/2), (18/10));
            
            Console.WriteLine("Suma: {0}", fraccion1.suma());
            Console.WriteLine("Resta: {0}", fraccion1.resta());
            Console.WriteLine("Multiplicación: {0}", fraccion1.multiplicacion());
            Console.WriteLine("División: {0}", fraccion1.division());

            Console.WriteLine("Suma: {0}", fraccion2.suma());
            Console.WriteLine("Resta: {0}", fraccion2.resta());
            Console.WriteLine("Multiplicación: {0}", fraccion2.multiplicacion());
            Console.WriteLine("División: {0}", fraccion2.division());
        }
    }
}
