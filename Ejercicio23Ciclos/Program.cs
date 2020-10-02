using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double div = 0;
            int cont1 = 0;
            int cont2 = 0;
            do
            {
                Console.WriteLine("Ingrese un número.");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                
                if (num > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Se dejará de solicitar números cuando ingrese el número cero.");
                    cont2++;
                }
                else
                {
                    cont1++;
                }
            } while (cont1==0);
            div = sum / cont2;
            Console.WriteLine("La media de los numero ingresados es: {0}", div);
        }
    }
}
