using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            string no = "n";
            do
            { 
                Console.WriteLine("Desea salir (S/N)");
                string palabra = Console.ReadLine();
                if (no.Equals (palabra))
                {
                    cont++;
                }
                else
                {
                    cont = 0;
                }
            } while (cont!=0);
            
            
        }
    }
}
