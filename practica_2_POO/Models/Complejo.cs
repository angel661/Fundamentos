using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_POO
{
    public class Complejo
    {
        public double Real { get; set; }
        public double Imaginario { get; set; }
        public Complejo()
        {
            Real = 0;
            Imaginario = 0;
        }
        public Complejo(double real,double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }
        public static Complejo sumar(Complejo c1,Complejo c2)
        {
            Complejo a = new Complejo();
            a.Real = c1.Real + c2.Real;
            a.Imaginario = c1.Imaginario + c2.Imaginario;
            return a;
        }
        public static Complejo restar(Complejo c1, Complejo c2)
        {
            Complejo a = new Complejo();
            a.Real = c1.Real - c2.Real;
            a.Imaginario = c1.Imaginario - c2.Imaginario;
            return a;
        }
        public static Complejo multiplicar(Complejo c1, Complejo c2)
        {
            Complejo a = new Complejo();
            a.Real = c1.Real * c2.Real - c1.Imaginario * c2.Imaginario;
            a.Imaginario = c1.Real*c2.Imaginario+ c1.Imaginario*c2.Real;
            return a;
        }
        public static Complejo dividir(Complejo c1, Complejo c2)
        {
            Complejo a = new Complejo();
            a.Real = (c1.Real * c2.Real - c1.Imaginario * c2.Imaginario)/(c2.Real*c2.Real+c2.Imaginario*c2.Imaginario);
            a.Imaginario =  (c1.Imaginario * c2.Real- c1.Real * c2.Imaginario )/ (c2.Real * c2.Real + c2.Imaginario * c2.Imaginario);
            return a;
        }
        public string ToString()
        {
            return "(" + Real + " , " + Imaginario + " )";
        }
    }
}
