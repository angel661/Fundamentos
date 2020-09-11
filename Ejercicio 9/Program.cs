using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número para determinar si es par o impar");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}
