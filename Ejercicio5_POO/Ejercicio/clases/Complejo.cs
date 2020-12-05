using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.clases
{
    class Complejo
    {
        public double Dig1 { get; set; }
        public double Dig2 { get; set; }

        public Complejo(double dig1, double dig2)
        {
            this.Dig1 = dig1;
            this.Dig2 = dig2;
        }
        public static Complejo operator +(Complejo dig1, Complejo dig2)
        {
            return new Complejo((dig1.Dig1 + dig2.Dig1), (dig1.Dig2 + dig2.Dig2));
        }
        public static Complejo operator -(Complejo dig1, Complejo dig2)
        {
            return new Complejo((dig1.Dig1 - dig2.Dig1), (dig1.Dig2 - dig2.Dig2)); ;
        }
        public double multiplicacion()
        {
            return Dig1 * Dig2;
        }
        public double division() 
        {
            if (Dig1>Dig2)
            {
                return Dig1 / Dig2;
            }
            else
            {
                return Dig2 / Dig1;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} + ({1}x)", Dig1, Dig2);
        }
    }
}
