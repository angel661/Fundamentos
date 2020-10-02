using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un dígito para la cantidad de asteriscos.");
            int cant = Convert.ToInt32(Console.ReadLine());
            while (1<=cant)
            {
                Console.Write("* ");
                cant--;
            }
        }
    }
}
