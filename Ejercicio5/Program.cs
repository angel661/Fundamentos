using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese fecha, mes y año en ese orden.");
            int dia = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            int año = Convert.ToInt32(Console.ReadLine());
            if (dia >0 && dia<=31 && mes > 0 && mes <= 12 && año >0 && año <= 2020)
            {
                Console.WriteLine("La fecha ({0}/{1}/{2}) ingresada es correcta.", dia, mes, año);
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es valida.");
            }

        }
    }
}
