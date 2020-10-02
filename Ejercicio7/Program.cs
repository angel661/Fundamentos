using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número cualquiera.");
            int num = Convert.ToInt32(Console.ReadLine());
            int mod;
            int cont = 0;
            while (num > 0)
            {
                mod = num % 10;
                num = num / 10;
                cont++;
            }
            Console.WriteLine("La cantidad de dígitos ingresado es {0}", cont) ;
        }
    }
}
