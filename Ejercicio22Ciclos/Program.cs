using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        { 
            int cont = 0, aux=0;
            double div = 0;
            while (cont <= 10)
            {
                aux = (aux + cont);
                
                cont++;
            }
            div = aux / 10;
            Console.WriteLine("La media es {0}.", div);
        }
    }
}
