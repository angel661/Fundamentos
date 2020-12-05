using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_POO.Clases
{
    class Fraccion
    {
        public double Dig1 { get; set; }
        public double Dig2 { get; set; }
        public Fraccion(double dig1, double dig2)
        {
            this.Dig1 = dig1;
            this.Dig2 = dig2;
        }
        public double suma()
        {
            return Dig1 + Dig2;
        }
        public double resta()
        {
            if (Dig1>Dig2)
            {
                return Dig1 - Dig2;
            }
            else
            {
                return Dig2 - Dig1;
            }
        }
        public double multiplicacion() 
        {
            return Dig1 * Dig2;
        }
        public double division()
        {
            if (Dig1 > Dig2)
            {
                return Dig1 / Dig2;
            }
            else
            {
                return Dig2 / Dig1;
            }
        }
    }
}
