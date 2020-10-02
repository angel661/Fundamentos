using System;
using System.ComponentModel;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio1
            //Console.WriteLine("Ingrese su edad.");
            //int edad = Convert.ToInt32(Console.ReadLine());
            //if (edad < 18 && edad > 0)
            //{
            //    Console.WriteLine("Es menor de edad.");
            //}
            //else
            //{
            //    Console.WriteLine("Es mayor de edad.");
            //}

            //Ejercicio2
            //Console.WriteLine("Digite un número.");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num < 25)
            //{
            //    Console.WriteLine("El número {0} es menor a 25.", num);
            //}
            //else if (num > 25)
            //{
            //    Console.WriteLine("El número {0} es mayor a 25.", num);

            //}
            //else
            //{
            //    Console.WriteLine("El número {0} es igual a 25.", num);

            //}

            //Ejercicio3
            Console.WriteLine("Ingresa el nombre y apellidos de dos personas.");
            string[] nombre = new string[2];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese los apellidos y nombre del {0}°;", i+1);
                nombre[i] = Convert.ToString(Console.ReadLine());

            }
            int index = 0;
            bool permuta = true;
            int iteracionIni = 1;
            int iteracionFin = nombre.Length - 1;
            int direccion = 1;
            while (permuta)
            {
                permuta = false;
                while ((direccion == 1 && index < iteracionFin) || (direccion == -1 && index > iteracionIni))
                {
                    index = index + direccion;
                    if (nombre[index].CompareTo(nombre[index - 1]) < 0)
                    {
                        String aux = nombre[index];
                        nombre[index] = nombre[index - 1];
                        nombre[index - 1] = aux;
                        permuta = true;
                    }
                }
                if (direccion == 1)
                {
                    iteracionFin--;
                }
                else
                {
                    iteracionIni++;
                }
                direccion = -direccion;
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
        }
    }
}
