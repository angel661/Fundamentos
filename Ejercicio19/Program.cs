using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el importe bruto.");
            int bruto = Convert.ToInt32(Console.ReadLine());
            double neto, imp;
            if (bruto > 15000 && bruto > 0)
            {
                imp = bruto * 0.16;
                neto = bruto + imp;
                Console.WriteLine("Se le aplica un impuesto del 15% que da un total de {0}.", neto);
            }
            else
            {
                imp = bruto * 0.10;
                neto = bruto + imp;
                Console.WriteLine("Se le aplica un impuesto del 10% que da un total de {0}.", neto);
            }
            
        }
    }
}
