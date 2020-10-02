using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int primero = 0;
            int segundo = 1;
            int sum=0;
            while (cont <= 25)
            {
                primero = segundo;
                segundo = sum;
                sum = primero + segundo;
                Console.WriteLine(segundo);
                cont++;
            }
        }
    }
}
