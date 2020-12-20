using System;
using System.Collections.Generic;
using System.Text;
using Segunda_práctica_POO.ClaseEmpleado;

namespace Segunda_práctica_POO.ClaseEmpleado
{
    public class Empleado:AtributoDeClase
    {
        public Empleado(string nombre, string cargo)
            : base(nombre)
        {
            Cargo = cargo;
        }
        static string Cargo { get; set; }
    }
}
