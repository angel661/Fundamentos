using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class Persona
    {
        public Persona(Fecha fechaNacimiento, string nombre)
        {
            FechaNacimiento = fechaNacimiento;
            Nombre = nombre;
        }
        Fecha FechaNacimiento { get; set; }
        string Nombre { get; set; }
    }
}
