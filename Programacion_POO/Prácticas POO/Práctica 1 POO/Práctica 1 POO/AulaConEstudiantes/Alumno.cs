using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.AulaConEstudiantes
{
    public class alumno : persona
    {
        public alumno(string nombre, int edad, string sexo, float nota)
            :base(nombre,edad,sexo)
        {
            Nota = nota;
        }
        float Nota { get; set; }
        public float MostrarNota()
        {
            return Nota;
        }
    }
}
