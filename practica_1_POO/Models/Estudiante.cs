using practica_1_POO.Superclase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO.Models
{
    public  class Estudiante : Persona
    {
        public int calificacion { get; set; }
        public Estudiante()
        {
            calificacion = Metodos.GenerarNumerosAlatorios(0, 10);
        
        }
        public void disponibilidad()
        {
            int prob = Metodos.GenerarNumerosAlatorios(0, 100);
            if (prob < 50)
            {
                asistencia = false;
            }
            else
            {
                asistencia = true;
            }
        }
        public string toString()
        {
            return "NOmbre" + Nombre + "Sexo" + Sexo + "";
        }
       
    }
}
