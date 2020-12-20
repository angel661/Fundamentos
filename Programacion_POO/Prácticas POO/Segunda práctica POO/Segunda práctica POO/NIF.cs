using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class NIF
    {
        public NIF(string dni, char letra)
        {
            DNI = dni;
            Letra = letra;
        }
        private void CrearNIF()
        {
            string NuevoNIF = DNI + Letra;
        }
        string DNI { get; set; }
        char Letra { get; set; }
    }
}
