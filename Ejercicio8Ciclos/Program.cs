using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, sum = 0;
            while (cont < 100)
            {
                sum = sum + cont;
                cont = cont + 2;
                
            }
            Console.WriteLine("La sumatoria de los número impares es: {0}", sum);
        }
    }
}
