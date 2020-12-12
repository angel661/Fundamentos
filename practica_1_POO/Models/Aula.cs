using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public int NumeroEst { get; set; }
        public Profesor profesor;
        public List<Estudiante> estudiante;
        public string materia;
        public int maxEstu = 20;
        public Aula()
        {
            Id = 1;
            profesor = new Profesor();
            estudiante =new List<Estudiante>();
            materia = Constantes.materias[Metodos.GenerarNumerosAlatorios(0,2)];

        }
        public void CrearEstudiantes()
        {
            for (int index = 0; index < estudiante.Count; index++)
            {
                estudiante[index] = new Estudiante();
            }
        }
        public bool AsistenciaEstudiantes()
        {
            int cuenntaAsistencia = 0;
            for (int index = 0; index < estudiante.Count; index++)
            {
                if (estudiante[index].asistencia)
                {
                    cuenntaAsistencia++;
                }
            }
            Console.WriteLine("hay" + cuenntaAsistencia + " estudientes");
            return cuenntaAsistencia >= ((int)(estudiante.Count / 2));
        }
        public bool darClase()
        {
            if (!profesor.asistencia)
            {
                Console.WriteLine("El profesor no esta, no se puede dar clase");
                return false;
            }
            else if (!profesor.Materia.Equals(materia))
            {
                Console.WriteLine("La materia del profesor y del aula no es la misma, no se puede dar clase");
                return false;
            }
            else if (!AsistenciaEstudiantes())
            {
                Console.WriteLine("La asistencia no es suficiente, no se puede dar clase");
                return false;
            }

            Console.WriteLine("Se puede dar clase");
            return true;
        }
        public void notas()
        {

            int chicosApro = 0;
            int chicasApro = 0;

            for (int i = 0; i < estudiante.Count; i++)
            {

                //Comprobamos si el alumno esta aprobado
                if (estudiante[i].calificacion >= 5)
                {
                    //Segun el sexo, aumentara uno o otro
                    if (estudiante[i].Sexo == "H")
                    {
                        chicosApro++;
                    }
                    else
                    {
                        chicasApro++;
                    }

                    Console.WriteLine(estudiante[i].toString());

                }

            }

            Console.WriteLine("Hay " + chicosApro + " chicos y " + chicasApro + " chicas aprobados/as");

        }
    }
}
