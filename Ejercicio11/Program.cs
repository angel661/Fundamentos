using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduzca un número del 1 al 7.");
            int num = Convert.ToInt32(Console.ReadLine());
            int dias = num;
            switch (dias)
            {
                case 1 : Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    break;
            }
        }
    }
}
