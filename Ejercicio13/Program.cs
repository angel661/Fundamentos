using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3 || num1 != num2 && num1 != num3)
            {
                if (num1 >= num2 && num1 >= num3)
                {
                    Console.Write(num1);
                }
                
                if (num1==num2)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else if (num1 == num3)
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
                else if (num1 == num2 && num1 == 3)
                {
                    Console.WriteLine(num2 + num3);
                }
                else if(num1 != num2 && num1 != num3)
                {
                    Console.WriteLine(num1);
                }
            }
            if (num2 >= num1 && num1 >= num3 || num2 != num1 && num2 != num3)
            {
                if (num2 >= num1 && num1 >= num3)
                {
                    Console.Write(num2);
                }
                
                else if (num2 == num1)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else if (num2 == num3)
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
                else if (num2 == num1 && num2 == 3)
                {
                    Console.WriteLine(num1 + num3);
                }
                else if (num2 != num1 && num2 != num3)
                {
                    Console.WriteLine(num2);
                }
            }
            
            if (num3 >= num1 && num3 >= num2 || num3 != num1 && num3 != num2)
            {
                if (num3 >= num1 && num3 >= num2)
                {
                    Console.Write(num3);
                }
                else if (num3 == num1)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else if (num3 == num2)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
                else if (num3 == num1 && num3 == 2)
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (num3 != num1 && num3 != num2)
                {
                    Console.WriteLine(num3);
                }
            }
        }
    }
}
