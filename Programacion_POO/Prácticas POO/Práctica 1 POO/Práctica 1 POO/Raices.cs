using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO
{
    class Raices
    {
        public Raices(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void obtenerRaices()
        {
            double raiz1 = -B + ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
            double raiz2 = -B - ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
            Console.WriteLine(raiz1);
            Console.WriteLine(raiz2);
        }
        public void obtenerRaiz()
        {
            double raiz = C / B;
            Console.WriteLine(raiz);
        }
        public void getDiscriminante()
        {
            double discriminante = Math.Pow(B, 2) - 4 * A * C;
            Console.WriteLine(discriminante);
        }
        public bool tieneRaices()
        {
            if (A == 0) return false;
            else return true;
        }
        public bool tieneRaiz()
        {
            if (A == 0) return true;
            else return false;
        }
        public void calcular()
        {
            double discriminante = Math.Pow(B, 2) - 4 * A * C;
            if (discriminante < 0) Console.WriteLine("No tiene soluciones");
            else
            {
                double raiz1 = -B + ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                double raiz2 = -B - ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)) / (2 * A));
                Console.WriteLine(raiz1);
                Console.WriteLine(raiz2);
            }
        }
        int A { get; set; }
        int B { get; set; }
        int C { get; set; }
    }
}
