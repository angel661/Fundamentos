using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("1) Metros a Kilómetros.");
            Console.WriteLine("2) Metros a Centímertros.");
            Console.WriteLine("3) Metros a Milímetros.");
            Console.WriteLine();
            Console.WriteLine("Seleccione una de las opciones.");
            
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1 || num == 2 || num ==3)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Ingrese el dígito que quiere convertir de metros a kílometros.");
                        double km = Convert.ToInt32(Console.ReadLine());
                        km = km / 1000;
                        Console.WriteLine("Resultado = {0} km", km);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el dígito que quiere convertir de metros a centímetros.");
                        int cm = Convert.ToInt32(Console.ReadLine());
                        cm = cm * 100;
                        Console.WriteLine("Resultado = {0} cm", cm);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el dígito que quiere convertir de metros a milímetros.");
                        int mm = Convert.ToInt32(Console.ReadLine());
                        mm = mm * 1000;
                        Console.WriteLine("Resultado = {0} mm", mm);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Favor de ingresar solo una de las 3 opciones.");
            }
        }
    }
}
