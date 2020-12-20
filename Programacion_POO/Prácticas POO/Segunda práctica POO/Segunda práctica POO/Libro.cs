using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class Libro
    {
        public Libro(string nombre, bool prestado)
        {
            Nombre = nombre;
            Prestado = false;
        }
        public void Prestamo(string nombre)
        {
            string prestado = nombre;
            Prestado = true;
        }
        public void Devolucion()
        {
            Prestado = false;
        }
        public override string ToString()
        {
            return string.Format("Nombre del libro: , paginas:, status");
        }
        string Nombre { get; set; }
        bool Prestado { get; set; }
    }
}
