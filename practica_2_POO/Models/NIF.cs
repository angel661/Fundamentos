using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_POO
{
    class NIF
    {
        public int NumeroDNI { get; set; }
        public char Letra { get; set; }

        public NIF(int numero)
        {
            NumeroDNI = numero;
            Letra = calcularLetra();
        }
        private char calcularLetra()
        {
            char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X',
                                'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
            return letras[NumeroDNI % 23];
        }
        public string ToString()
        {
            return NumeroDNI + " - " + calcularLetra();
        }

    }
}
