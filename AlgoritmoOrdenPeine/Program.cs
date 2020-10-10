using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOrdenPeine
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vector = {20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
            int[] vector = new int[20];
            Random vector20ram = new Random();
            for (int index=0;index<20;index++)
            {
                vector[index] = vector20ram.Next(20);
            }
            for (int index1 = 0; index1 < 20; index1++)
            {
                Console.Write(" {0}", vector[index1]);
            }
            Console.Write("\n");
            int[] vectorordenado = new int[20];
            vectorordenado = Comb_sort(vector);
            for (int indice = 0; indice < 20; indice++)
            {
                Console.Write(" {0}",vectorordenado[indice]);
            }
        }
        
        public static int[] Comb_sort(int[] vector)
        {
            int gap = 20;
            bool permutación = true;
            int actual;
            
 
            while ((permutación) || (gap > 1))
            {
                
                permutación = false;
                int numedec = Convert.ToInt32(Math.Truncate(gap /1.3));
                gap = numedec;
                //Console.WriteLine("gap {0}", gap);
                if (gap < 1)
                    gap = 1;
                for (actual = 0; actual < 20 - gap; actual++)
                {
                    if (vector[actual] > vector[actual + gap])
                    {
                        permutación = true;
                        // Intercambiamos los dos elementos
                        int temp = vector[actual];
                        vector[actual] = vector[actual + gap];
                        vector[actual + gap] = temp;
                    }
                }
            }
  
            return vector;
        }
        
    }
}
