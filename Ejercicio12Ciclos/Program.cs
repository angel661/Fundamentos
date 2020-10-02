using System;

namespace Ejercicio12
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
                if (ini % 2 != 0)
                {
                    
                    for (int i=ini; i <= fin; i++)
                    {
                        i++;
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    while (ini <= fin)
                    {
                        Console.WriteLine(ini);
                        ini=ini+2;
                    }
                }
            }
            else
            {
                Console.WriteLine("El primer dígito ingresado debe ser menor al segundo");
            }
        }
    }
}
