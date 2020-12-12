using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO
{
    class Raices
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public  Raices(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void ObtenerRaices()
        {
            Console.WriteLine("primera solucion");
            double resultado = (-B + Math.Sqrt(GetDiscriminante()) )/ (2 * A);
            Console.WriteLine(resultado);
            Console.WriteLine("Segunda solucion");
            double resultado1= (-B - Math.Sqrt(GetDiscriminante()) )/ (2 * A);
            Console.WriteLine(resultado1);
        }
        public double GetDiscriminante()
        {
            return Math.Pow(B, 2) -( 4 * A * C);
        }
        public void ObtenerRaiz()
        {
            Console.WriteLine("UNICA SOLUCION");
            double resultado2 = -B / (2 * A);
            Console.WriteLine(resultado2);
            
        }
        public bool tieneRaices()
        {
            return (GetDiscriminante() > 0);
        }
        public bool tieneRaiz()
        {
            return (GetDiscriminante() == 0);
        }
        public void calcular()
        {
            if (tieneRaices())
            {
                ObtenerRaices();
            }
            else if (tieneRaices())
            {
                ObtenerRaiz();
            }
            else
            {
                Console.WriteLine("no tiene raices");
            }
        }

    }
}
