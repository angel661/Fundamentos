using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su nota del examen (Del 0 al 10).");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 0 && nota <= 10)
            {
                if (nota < 5)
                {
                    Console.WriteLine("Reprobado");
                }
                else if (nota > 4 && nota < 7)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota >= 7 && nota < 9)
                {
                    Console.WriteLine("Notable");
                }
                else if (nota == 9)
                {
                    Console.WriteLine("Sobresaliente");
                }
                else
                {
                    Console.WriteLine("Excelente");
                }
            }
            else
            {
                Console.WriteLine("La nota no debe ser mayor a 10 ni menor a 0.");
            }
        }
    }
}
