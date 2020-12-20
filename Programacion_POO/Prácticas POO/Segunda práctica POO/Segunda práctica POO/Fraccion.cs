using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class Fraccion
    {
        public int MCD(int a, int b)
        {
            if (b == 0) return a;
            return MCD(b, a % b);
        }
        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }
        public void Sumar(Fraccion fraccion)
        {
            int mcd = MCD(Denominador, fraccion.Denominador);
            Numerador = ((fraccion.Denominador * Numerador) + (fraccion.Numerador * Denominador)) / mcd;
            Denominador = (Denominador * fraccion.Denominador) / mcd;
        }
        public void Restar(Fraccion fraccion)
        {
            int mcd = MCD(Denominador, fraccion.Denominador);
            Numerador = ((fraccion.Denominador * Numerador) - (fraccion.Numerador * Denominador)) / mcd;
            Denominador = (Denominador * fraccion.Denominador) / mcd;
        }
        public void Multiplicar(Fraccion fraccion)
        {
            Numerador = Numerador * fraccion.Numerador;
            Denominador = Denominador * fraccion.Denominador;
        }
        public void Dividir(Fraccion fraccion)
        {
            Numerador = Numerador * fraccion.Denominador;
            Denominador = Denominador * fraccion.Numerador;
        }
        int Numerador { get; set; }
        int Denominador { get; set; }
    }
}
