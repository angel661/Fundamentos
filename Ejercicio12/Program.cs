using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 12 para ver el mes correspondiente.");
            int num = Convert.ToInt32(Console.ReadLine());
            int mes = num;
            if (num>0&&num<13)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Enero");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("El número ingresado no debe ser menor a 1 ni mayor a 12");
            }
        }
    }
}
