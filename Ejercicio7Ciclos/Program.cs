using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, sum = 0;
            while (cont < 100)
            {
                cont = cont + 2;
                sum = sum + cont;
            }
            Console.WriteLine("La sumatoria de los número pares es: {0}",sum);
        }
    }
}
