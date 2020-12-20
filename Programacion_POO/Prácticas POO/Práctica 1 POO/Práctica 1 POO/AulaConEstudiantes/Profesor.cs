using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.AulaConEstudiantes
{
    class profesor:persona
    {
        public profesor(string nombre, int edad, string sexo, string materia)
            : base(nombre, edad, sexo)
        {
            Materia = materia;
            Disponible = true;
        }
        public string MateriaPropia()
        {
            return Materia;
        }
        public string NombrePropio()
        {
            return Nombre;
        }
        string Materia { get; set; }
        public bool Disponible { get; set; }
    }
}
