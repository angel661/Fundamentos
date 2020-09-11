using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingres un número");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 ==0)
            {
                Console.WriteLine("El número es multiplo de 3");
                if (num % 5 == 0 )
                {
                    Console.WriteLine("Tambien es multiplo de 5");
                }
                else if (num % 7 == 0)
                {
                    Console.WriteLine("Tambien es multiplo de 7");
                }
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("El número es multiplo de 5");
                if (num % 3 == 0)
                {
                    Console.WriteLine("Tambien es multiplo de 3");
                }
                else if (num % 7 ==0)
                {
                    Console.WriteLine("Tambien es multiplo de 7");
                }
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("El número es multiplo de 7");
                if (num % 5 == 0)
                {
                    Console.WriteLine("Tambien es multiplo de 5");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Tambien es multiplo de 3");
                }
            }
        }   
    }
}
