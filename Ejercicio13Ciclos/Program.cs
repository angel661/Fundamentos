using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el dígito desde donde quiere que inicie.");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dígito hasta donde quiere que termine la sucesión de números.");
            int fin = Convert.ToInt32(Console.ReadLine());
            if (ini < fin)
            {
                if (ini % 2 != 0)
                {
                    while (ini <= fin)
                    {
                        Console.WriteLine(ini);
                        ini = ini + 2; ;   
                    }
                }
                else
                {
                    for (int i = ini+1; i < fin; i++)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }
            }
            else
            {
                Console.WriteLine("El primer dígito ingresado debe ser mayor al segundo.");
            }

        }
    }
}
