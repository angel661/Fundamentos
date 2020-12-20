using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.Cine
{
    class Espectador
    {
        Espectador(string nombre, int edad, int dinero)
        {
            Nombre = nombre;
            Edad = edad;
            Dinero = dinero;
        }
        string Nombre { get; set; }
        int Edad { get; set; }
        int Dinero { get; set; }
        public string Minombre()
        {
            return Nombre;
        }
        public int Midinero()
        {
            return Dinero;
        }
        public int Miedad()
        {
            return Edad;
        }
    }
}
