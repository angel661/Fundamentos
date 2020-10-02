using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el dígito desde donde quiere que empiece.");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dígito hasta donde termina la sucesión de números.");
            int fin = Convert.ToInt32(Console.ReadLine());
            if (ini < fin)
            {
                while (ini <= fin)
                {
                    Console.WriteLine(ini);
                    ini++;
                }
            }
            else
            {
                Console.WriteLine("El primer dígito ingresado debe ser menor al segundo");
            }
            
        }
    }
}
