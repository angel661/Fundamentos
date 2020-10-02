using System;
using System.Globalization;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número del 1 al 5.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 2 || num  % 2 != 0 && num % 3 != 0 && num != 1)
            {
                Console.WriteLine("El número {0} es primo.", num);
            }
            else
            {
                Console.WriteLine("El número {0} no es primo.", num);
            }
        }
    }
}
