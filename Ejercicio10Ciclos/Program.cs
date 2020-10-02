using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, sum = 0, aux = 0;
            while (cont <= 100)
            {
                
                if (cont % 2 != 0)
                {
                    aux++;
                }
                sum = sum + cont;
                cont = cont + 2;
                
            }
            Console.WriteLine("La sumatoria de los números impares es: {0}", sum);
            Console.WriteLine("Hay {0} números impares.", aux);
        }
    }
}
