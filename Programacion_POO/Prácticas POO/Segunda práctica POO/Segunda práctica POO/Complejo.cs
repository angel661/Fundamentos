using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Segunda_práctica_POO
{
    class Complejo
    {
        public Complex Sumar(Complex numero1, Complex numero2)
        {
            Complex respuesta = numero1 + numero2;
            return respuesta;
        }
        public Complex Restar(Complex numero1, Complex numero2)
        {
            Complex respuesta = numero1 - numero2;
            return respuesta;
        }
        public Complex Multiplicar(Complex numero1, Complex numero2)
        {
            Complex respuesta = numero1 * numero2;
            return respuesta;
        }
        public Complex Dividir(Complex numero1, Complex numero2)
        {
            Complex respuesta = numero1 / numero2;
            return respuesta;
        }
    }
}
