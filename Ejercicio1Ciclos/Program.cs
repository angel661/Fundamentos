using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            do
            {
                Console.WriteLine("Ingrese un dígito para identificar si es primo");
                int numpri = Convert.ToInt32(Console.ReadLine());
                if (numpri % 2 != 0 && numpri / 1 == numpri && numpri > 1 || numpri == 2)
                {
                    if (numpri % 3 !=0 || numpri ==3)
                    {
                        Console.WriteLine("El númeor {0} es primo", numpri);
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("El númeor {0} no es primo", numpri);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("El númeor {0} no es primo", numpri);
                    Console.WriteLine();
                }
            } while (cont != 1);

        }
    }
}
