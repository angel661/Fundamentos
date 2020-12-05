using Ejercicio.clases;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo complejo1 = new Complejo(10, 5);
            Complejo complejo2 = new Complejo(8, 18);

            Complejo suma = complejo1 + complejo2;
            Complejo resta = complejo1 - complejo2;

            Console.WriteLine("Sumatoria entre el complejo1 y complejo2: {0}", suma);
            Console.WriteLine("Resta entre complejo1 y complejo2: {0}", resta);

            Console.WriteLine("División complejo1: {0}", complejo1.division());
            Console.WriteLine("División complejo2: {0}", complejo2.division());
            Console.WriteLine("Multiplicación complejo1: {0}", complejo1.multiplicacion());
            Console.WriteLine("Multiplicación complejo2: {0}", complejo2.multiplicacion());
        }
    }
}
