using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, aux = 1; 
            Console.WriteLine("Ingrese un número para sabar su factorial.");
            int num = Convert.ToInt32(Console.ReadLine());
            while (cont <= num)
            {
                aux = aux * cont;
                cont++;
            }
            Console.WriteLine("El factorial de {0} es: {1}", num, aux);
        }
    }
}
