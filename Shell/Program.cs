using System;
using System.Net.Http;
using System.Numerics;

namespace Shell
{
    class Program
    {
        int[] array;
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo de Ordenamiento SHELL");
            Console.WriteLine("Ingrese el tamaño del arreglo.");
            int cant = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[cant];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Digite el {0}° número: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Shell(array);
            imprimir(array); 
        }

        public static int Shell(int[] array)
        {
            int salto = 0, i = 0, j = 0, aux = 0;
            salto = array.Length / 2;
            while (salto > 0)
            {
                i = 1;
                while (i != 0)
                {
                    i = 0;
                    j = 1;
                    while (j <= (array.Length - salto))
                    {
                        if (array[j - 1] > array[(j - 1) + salto])
                        {
                            aux = array[(j - 1) + salto];
                            array[(j - 1) + salto] = array[j - 1];
                            array[j - 1] = aux;
                            i = 1;

                        }
                        j++;
                    }
                }
                salto = salto / 2;
            }
            return array[(j - 1) + salto];
        }
        public static void imprimir(int[]  array) 
        {
            Console.WriteLine();
            Console.WriteLine("Orden ascendente.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}
