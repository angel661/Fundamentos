using System;

namespace practica03ejerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Que pida un numero y diga si es primo
            //int valor1 = 0, numero;
            //Console.Write("Por favor, ingrese un numero: \t ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < (numero + 1); i++)
            //{
            //    if (numero % i == 0)
            //    {
            //        valor1++;
            //    }
            //}
            //if (valor1 != 2)
            //{
            //    Console.WriteLine(numero + " No es primo");
            //}
            //else
            //{
            //    Console.WriteLine(numero + " Si es primo ");
            //}
            //Console.ReadLine();
            //Console.ReadKey();


            //2
            //muestra numeros de 1 a 100
            //Console.WriteLine("se muestra los numeros de 1 a 100");
            //int numero;
            //numero = 1;
            //while (numero <= 100)
            //{
            //    Console.Write(numero);
            //    Console.Write(" - ");
            //    numero = numero + 1;
            //}

            //Console.ReadLine();
            //Console.ReadKey();


            //3
            //muestra numeros de 100 a 1
            //Console.WriteLine("numeros de 100 a 1 decreciente");
            //for (int numeros = 100; numeros >= 1; numeros--)
            //{
            //    Console.Write(numeros);
            //    Console.Write(" - ");
            //}
            //Console.ReadLine();
            //Console.ReadKey();

            //4
            //muestra numeros pares en 100
            //Console.WriteLine("numeros pares de 1 a 100");
            //for (int numero = 2; numero <= 100; numero += 2)
            //{
            //    Console.Write(numero);
            //    Console.Write("-");
            //}

            //Console.ReadLine();
            //Console.ReadKey();

            //5
            //muestra numeros impares

            Console.Write("Por favor, ingrese un numero para mostrar impares hasta el numero ingresado: \t");
            int numero = Convert.ToInt32(Console.ReadLine());
            int cantidad = 0;
            for (int x = 1; x <= numero; x++)
            {
                int y = x % 2;
                if (y != 0)
                {
                    cantidad = cantidad + 1;
                    Console.Write(x);
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Total de numeros impares: " + cantidad);

            Console.ReadKey();




        }
    }
}
