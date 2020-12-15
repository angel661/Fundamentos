using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion de equivalencias
            float Metros, pies, pulgadas, millas;
            Console.Write("Por favor, ingrese Cantidad de Metros a Calcular: ");
            Metros = float.Parse(Console.ReadLine());

            pies = Metros / (0.3048f);
            pulgadas = Metros / (0.0254f);
            millas = Metros / (1609.344f);
            Console.WriteLine("La Cantidad de pies es: {0}", pies);
            Console.WriteLine("La Cantidad de pulgada es: {0}", pulgadas);
            Console.WriteLine("La Cantidad de millas es: {0}", millas);
            Console.ReadKey();
        }
    }
    
}
