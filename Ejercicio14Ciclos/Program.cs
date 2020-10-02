using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Ingrese un dígito de inicio.");
            int ini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un dígito para el final de la sucesión.");
            int fin = Convert.ToInt32(Console.ReadLine());
            if (ini < fin)
            {
                while (ini <= fin)
                {
                    sum = sum + ini;
                    ini++;
                    
                }
                Console.WriteLine("La sumatoria de los números es {0}: ", sum);
            }
            else
            {
                Console.WriteLine("El primer dígito debe ser mayor al primero.");
            }
        }
    }
}
