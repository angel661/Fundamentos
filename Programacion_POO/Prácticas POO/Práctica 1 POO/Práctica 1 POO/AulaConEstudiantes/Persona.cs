using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.AulaConEstudiantes
{
    public class persona
    {
        int ausencia = 0;
        public persona(string nombre, int edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Ausencia = ausencia;
        }
        internal string Nombre { get; set; }
        internal int Edad { get; set; }
        internal string Sexo { get; set; }
        private int Ausencia { get; set; }
        public void Ausencias()
        {
            ausencia++;
        }
    }
}
