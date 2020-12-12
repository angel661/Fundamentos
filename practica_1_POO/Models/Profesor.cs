using practica_1_POO.Superclase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO.Models
{
    public  class Profesor:Persona
    {
        public string Materia { get; set; }

        public Profesor()
        {
            Materia = Constantes.materias[Metodos.GenerarNumerosAlatorios(0, 2)]; 
        }
        public void disponibilidad()
        {
            int prob = Metodos.GenerarNumerosAlatorios(0, 100);
            if (prob < 20)
            {
                asistencia = false;
            }
            else
            {
                asistencia = true;
            }
        }
    }
}
