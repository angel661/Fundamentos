using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO.Superclase
{
    public  class Persona
    {
        public bool asistencia;
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool Asistencia { get { return asistencia; } set { asistencia = value; }
        
    }
        public string[] NombreMujeres = { "laura", "maria", "sandra", "paola", "morelia" };
        public string[] NombreHombres = { "juan", "luis", "marcos", "josue", "alejandro" };
        public int hombre = 0;
        public int mujer = 1;
        
        public Persona()
        {
            int determinarSexo = Metodos.GenerarNumerosAlatorios(0, 1);
            if (determinarSexo == hombre)
            {
                Nombre = NombreHombres[Metodos.GenerarNumerosAlatorios(0, 4)];
                Sexo = "H";

            }
            else
            {
                Nombre = NombreMujeres[Metodos.GenerarNumerosAlatorios(0, 4)];
                Sexo = "M";

            }
          
        }
       
    }
}
