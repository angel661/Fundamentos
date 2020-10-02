using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, sum = 0, aux = 0;
            while (cont < 100)
            {
                if (cont % 2==0)
                {
                    aux++;
                }
                cont = cont + 2;
                sum = sum + cont;
            }
            Console.WriteLine("La sumatoria de los números pares es: {0}", sum);
            Console.WriteLine("Hay {0} números pares.", aux);
        }
    }
}
