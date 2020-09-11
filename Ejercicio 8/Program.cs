using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos dígitos");
            int dig1 = Convert.ToInt32(Console.ReadLine());
            int dig2 = Convert.ToInt32(Console.ReadLine());
            if (dig1>dig2)
            {
                Console.WriteLine("El mayor es {0}.", dig1);
            }
            else if (dig2>dig1)
            {
                Console.WriteLine("El mayor es {0}.", dig2);
            }
            else
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}
