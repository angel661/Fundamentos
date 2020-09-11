using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            string cad1, cad2, cad3;
            int a1 = 1, a2 = 2, a3 = 3, a4 = 5, a5 = 5;
            string cad4, cad5, cad6;
            Console.WriteLine("Ingrese un valor por teclado");
            cad4 = Console.ReadLine();
            Console.WriteLine(cad4);
            Console.WriteLine("Ingrese un valor por teclado");
            cad4 = Console.ReadLine();
            Console.WriteLine(cad4);
            Console.WriteLine("Ingrese un valor por teclado");
            cad4 = Console.ReadLine();
            Console.WriteLine(cad4);
            Console.WriteLine("Ingrese un valor númerico");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número que ingreso es: {0}", a);
            long b1 = a1, b2 = a2, b3 = a3, b4 = a4, b5 = a5;
            cad1 = "1001"; cad2 = "1002"; cad3 = "1003"; cad4 = "1004"; cad5 = "1005";
            a1 = Convert.ToInt32(cad1);
            a2 = Convert.ToInt32(cad2);
            a3 = Convert.ToInt32(cad3);
            a4 = Convert.ToInt32(cad4);
            a5 = Convert.ToInt32(cad5);
            Console.WriteLine("Ingrese dos numeros");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b) Console.WriteLine("El primer numero es mayor");
            else Console.WriteLine("El segundo numero es mayor");
            Console.WriteLine("Ingrese un numero");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("El numero {0} es par", a);
            else Console.WriteLine("El numero {0} es impar", a);
            Console.WriteLine("Ingrese un numero");
            a = Convert.ToInt32(Console.ReadLine());
            b = 0;
            if (a % 3 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 3", a);
                b = 1;
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 5", a);
                b = 1;
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("El numero {0} es multiplo de 7", a);
                b = 1;
            }
            if (b == 0) Console.WriteLine("El numero {0} no es multiplo ni de 3, 5, 7", a);
        }
    }
}
