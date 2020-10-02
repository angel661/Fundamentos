using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número cualquiera.");
            int num = Convert.ToInt32(Console.ReadLine());
            int mod;
            int suma = 0;
            while (num > 0)
            {
                mod = num % 10;
                num = num / 10;
                suma = suma + mod;
            }
            Console.WriteLine("La sumatoria de los dígitos del número introdusido somn {0}.", suma);
        }
    }
}
