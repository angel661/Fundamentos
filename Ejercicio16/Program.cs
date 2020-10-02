using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            Console.WriteLine("Digite 3 números.");
            int[] num = new int[3];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = num[0] + num[1];
            if (num[2] == suma)
            {
                Console.WriteLine("EL tercer dígito {0} es igual a la suma de los dos primeros. Suma = {1}",num[2], suma);
            }
        }
    }
}
