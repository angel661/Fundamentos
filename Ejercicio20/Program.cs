using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento = 0, aux;
            Console.WriteLine("Ingrese la cantidad de años que lleva en la empresa para calcular su aumento.");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad > 10)
            {
                aux = 40000 * 0.10;
                aumento = 40000 + aux;
            }
            else if(cantidad <= 10 && cantidad >5)
            {
                aux = 40000 * 0.07;
                aumento = 40000 + aux;
            }
            else if (cantidad <= 5 && cantidad > 3)
            {
                aux = 40000 * 0.05;
                aumento = 400000 + aux;
            }
            else
            {
                aux = 40000 * 0.03;
                aumento = 40000 + aux;
            }
            Console.WriteLine("Su sueldo más ele aumento es {0}", aumento);
        }
    }
}
