using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else
            {
                Console.WriteLine("El número es negativo.");
            }
        }
    }
}
