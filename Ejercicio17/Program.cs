using System;
using System.Diagnostics;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vf = false;
            Console.WriteLine("1) Archivo.");
            Console.WriteLine("2) Buscar.");
            Console.WriteLine("3) Salir.");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1 || num == 2 || num == 3)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Entrando a archivo.");
                        vf = false;
                        break;
                    case 2:
                        Console.WriteLine("Entrando al buscador.");
                        vf = false;
                        break;
                    case 3:
                        Console.WriteLine("Saliendo.");
                        vf = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("El número ingresado tiene que ser 1, 2 o 3.");
            }
        }
    }
}
