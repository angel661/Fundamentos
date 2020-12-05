using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Raices
{
    public class Raices
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Raices(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void obtenerRaices()
        {
            double raiz1, raiz2;
            try
            {
                raiz1 = (-B + Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
                Console.WriteLine("Primera raiz:" + raiz1);
            }
            catch
            {

                Console.WriteLine("Primera raiz imaginaria");
            }
            try
            {
                raiz2 = (B - Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
                Console.WriteLine("Segunda raiz:" + raiz2);
            }
            catch
            {
                Console.WriteLine("Segunda raiz imaginaria");
            }
        }

        public void obtenerRaiz()
        {
            double raiz1, raiz2;
            try
            {
                raiz1 = (-B + Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
                raiz2 = (B - Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
                if (raiz1 == raiz2)
                {
                    Console.WriteLine("Raices iguales: " + raiz1);
                }
                else
                {
                    Console.WriteLine("Raices diferentes.");
                }
            }
            catch
            {

                Console.WriteLine("Alguna raiz es imaginaria.");
            }
        }
        public double getDiscriminante()
        {
            double disc = B * B - 4 * A * C;
            return disc;
        }

        public bool tieneRaices()
        {
            if (getDiscriminante()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool tieneRaiz() 
        {
            if (getDiscriminante()==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void calcular() 
        {
            if (tieneRaices())
            {
                obtenerRaices();
            }
            else if (tieneRaiz())
            {
                obtenerRaiz();
            }
            else
            {
                Console.WriteLine("Raices imaginarias");
            }
        }
    }
}
