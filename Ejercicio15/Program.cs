using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor;
            int menor;
            Console.WriteLine("Ingrese 10 números.");
            int[] listnum = new int[10];
            for (int i = 0; i < listnum.Length; i++)
            {
                listnum [i]= Convert.ToInt32(Console.ReadLine());
            }
            mayor = listnum[0];
            menor = listnum[0];
            for (int j = 0; j < listnum.Length; j++)
            {
                if (listnum[j] > mayor)
                {
                    mayor = listnum[j];
                }
                else if(listnum[j]<menor)
                {
                    menor = listnum[j];
                }
            }

            Console.WriteLine("El número mayor es {0}.", mayor);
            Console.WriteLine("El número menor es {0}.", menor);
        }
    }
}
