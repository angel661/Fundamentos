using System;

namespace Practica2Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Escribir un programa, que reciba una edad como entero por parámetro y muestre un mensaje por pantalla si es mayor de edad o no.

            //int edad;
            //Console.WriteLine("Por favor, Ingrese su edad: ");
            //edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("Ud; es mayor de edad ");
            //}
            //else
            //{
            //    Console.WriteLine("es menor de edad ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();


            // 2.Escribir un programa, que reciba un entero por parámetro y muestre un mensaje por pantalla que indique si es mayor o menor que 25.


            //int edad;
            //Console.WriteLine("Por favor, ingrese su edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());
            //if (edad > 25)
            //{
            //    Console.WriteLine("Ud es, Mayor a 25");
            //}
            //else
            //{
            //    Console.WriteLine("Ud. tiene {0} por tanto es, Menor a 25", edad);
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            
            
            /*3.Realiza un programa, que pida el nombre y los apellidos
                de dos personas y los escriba ordenados alfabéticamente, 
               teniendo en cuenta los dos apellidos, y si fuese necesario, el nombre */

            string nombre1;
            string nombre2;
            Console.Write("Ingrese nombre y apellido:");
            nombre1 = Console.ReadLine();
            Console.Write("Ingrese nombre y apellido:");
            nombre2 = Console.ReadLine();

            string[] nombres = { nombre1, nombre2 };
            int length = nombres.Length;
            Array.Sort(nombres);
            Console.WriteLine("Array ordenado:\n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
