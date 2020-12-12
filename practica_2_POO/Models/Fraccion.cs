using System;

namespace practica_2_POO
{
    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }


        public Fraccion()
        {
            Numerador = 0;
            Denominador = 1;
        }
        public Fraccion(int num, int den)
        {
            Numerador = num;
            Denominador = den;
        }
        //sumar fracciones
        public static Fraccion sumar(Fraccion f1,Fraccion f2)
        {
            Fraccion a = new Fraccion();
            a.Numerador =( f1.Numerador * f2.Denominador) + (f2.Numerador * f1.Denominador);
            a.Denominador = f1.Denominador * f2.Denominador;
            a.simplificar();
            return a;
        }


        public static Fraccion restar(Fraccion f1, Fraccion f2)
        {
            Fraccion a = new Fraccion();
            a.Numerador = (f1.Numerador * f2.Denominador) - (f2.Numerador * f1.Denominador);
            a.Denominador = f1.Denominador * f2.Denominador;
            a.simplificar();
            return a;
        }


        public static Fraccion multiplicar(Fraccion f1, Fraccion f2)
        {
            Fraccion a = new Fraccion();
            a.Numerador = (f1.Numerador * f2.Numerador);
            a.Denominador = f1.Denominador * f2.Denominador;
            a.simplificar();
            return a;
        }
        public static Fraccion division(Fraccion f1, Fraccion f2)
        {
            Fraccion a = new Fraccion();
            a.Numerador = (f1.Numerador * f2.Denominador);
            a.Denominador = f1.Denominador * f2.Numerador;
            a.simplificar();
            return a;
        }




        public int mcd()
        {
            int u = Math.Abs(Numerador);
            int v = Math.Abs(Denominador);
            if (v == 0)
            {
                return u;
            }
            int r;
            while (v != 0)
            {
                r = u % v;
                u = v;
                v = r;
            }
            return u;
        }


        public void simplificar()
        {
            int n = mcd();
            Numerador = Numerador / n;
            Denominador = Denominador / n;
        }


        public string ToString()
        {
     
            return Numerador + "/" + Denominador;
        }

    }
}
