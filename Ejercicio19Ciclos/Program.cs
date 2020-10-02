using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número que quiere multiplicar");
            int num = Convert.ToInt32(Console.ReadLine());
            int cont = 0, mult = 0, aux=0;
            while (cont <= 10)
            {
                mult = num * cont;
                Console.WriteLine("{0} x {1} = {2}", num, cont, mult);
                cont++;
            }
        }
    }
}
