using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO
{
    class NumerosFeos
    {
        NumerosFeos()
        {
            long dos = 30, tres = 19, cinco = 13;
            long max = dos * tres * cinco;
            long[] Lista = new long[max];
            long x = 0; ;
            long pos = 0;
            for (int i = 0; i < dos; i++)
            {
                for (int j = 0; j < tres; j++)
                {
                    for (int k = 0; k < cinco; k++)
                    {
                        long aux = (long)(Math.Pow(2, i) * Math.Pow(3, j) * Math.Pow(5, k));
                        Lista[pos] = aux;
                        pos++;
                        if (aux < 1) x++;
                    }
                }
            }
            Array.Sort(Lista);
            Console.WriteLine("The 1500’th ugly number is {0}.", Lista[1499 + x]);
        }
    }
}
