using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double cuota;
            double desc = 0;
            Console.WriteLine("Ingrese la edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            
            char sn1 = 's';
            char sn2 = 'n';

            if (edad >= 65)
            {
                desc = 800 * 0.40;
                cuota = 800 - desc;
                Console.WriteLine("La cuota es de 800 euros menos el descuento de {0} hace un total de {1}", desc, cuota);
                Console.WriteLine("Su descuento es de un 40%");
            }
            else if (edad < 21)
            {
                Console.WriteLine("Si sus padres son socios del club presione 's' si no 'n' ");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == sn1 || sn == sn2)
                {
                    if (sn == sn1)
                    {
                        desc = 800 * 0.45;
                        cuota = 800 - desc;
                        Console.WriteLine("La cuota menos el descuento hace un total de {0}. ", cuota);
                        Console.WriteLine("Su desceunto es de un 45%");
                    }
                    else 
                    {
                        desc = 800 * 0.25;
                        cuota = 800 - desc;
                        Console.WriteLine("La cuota menos el descuento hace un total de {0}. ", cuota);
                        Console.WriteLine("Su descuneto es de un 25%");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Favor de ingresar solo 's' o 'n' para el tipo de descuento.");
                }
            }

            else
            {
                Console.WriteLine("La persona no cuenta con ninguna clase de descuento. El monto a pagar es de 800 euros");
            }
        }
    }
}
