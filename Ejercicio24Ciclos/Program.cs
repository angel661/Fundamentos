using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int mult = 0;
            int sum = 0;
            while (cont <= 100)
            {
                mult = cont * cont;
                sum = sum + mult;
                cont++;
            }
            
            Console.WriteLine("La suma de los cuadrados de los 100 primeros números es {0}", sum);
        }
    }
}
