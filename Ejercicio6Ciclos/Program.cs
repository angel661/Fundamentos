using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, sum = 0; 
            while (cont < 100)
            {
                cont++;
                sum = sum + cont;
            }
            Console.WriteLine(sum);
        }
    }
}
