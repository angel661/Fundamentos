using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult = 1;
            Console.WriteLine("Ingrese un dígito de inicio.");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un dígito para el final de la sucesión.");
            int fin = Convert.ToInt32(Console.ReadLine());
            if (ini < fin)
            {
                while (ini <= fin)
                {
                    mult = mult * ini;
                    ini++;

                }
                Console.WriteLine("El producto de los números es {0}: ", mult);
            }
            else
            {
                Console.WriteLine("El primer dígito debe ser mayor al primero.");
            }
        }
    }
}
