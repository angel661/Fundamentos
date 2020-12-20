using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.AulaConEstudiantes
{
    class Aula
    {
        public Aula(int identificador, int capacidad, string materia)
        {
            Identificador = identificador;
            Capacidad = capacidad;
            Materia = materia;
            ProfesorEncargado = "0";
            Alumnado.Clear();
        }

        public void AsignarProfesor(profesor profesor1, int alumnado)
        {
            if(profesor1.MateriaPropia() == Materia && profesor1.Disponible == true)
            {
                ProfesorEncargado = profesor1.NombrePropio();
            }
            else
            {
                Console.WriteLine("El Profesor se encuentra ocupado o pertenece a otra materia");
            }
        }
        public void PasarClases(int alumnado)
        {
            if (alumnado > Capacidad * 0.5 && alumnado <= Capacidad)
            {
                if(ProfesorEncargado != "0")
                {
                    Console.WriteLine("Se pueden pasar clases");
                    Console.WriteLine("Asignar al alumnado:");
                    for(int i = 0; i < alumnado; i++)
                    {
                        Console.WriteLine("Alumno------------");
                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad:");
                        int edad = 22;
                        while(edad < 0 || edad > 20)
                        {
                            edad = Convert.ToInt32(Console.ReadLine());
                            if(edad < 0 || edad > 20)
                            {
                                Console.WriteLine("Introduzca una edad Validad");
                            }
                        }
                        Console.WriteLine("Sexo:");
                        string sexo = Console.ReadLine();
                        Console.WriteLine("Nota:");
                        float nota = 100;
                        while (nota < 0 || nota > 10)
                        {
                            nota = Convert.ToInt32(Console.ReadLine());
                            if (nota < 0 || nota > 10)
                            {
                                Console.WriteLine("Introduzca una nota Validad");
                            }
                        }
                        alumno AlumnoNuevo = new alumno(nombre,edad,sexo,nota);

                        Alumnado.Add(AlumnoNuevo);
                    }
                }
                else
                {
                    Console.WriteLine("Falta asignar un profesor");
                }
            }
            else
            {
                Console.WriteLine("No se cumple el rango de alumnos necesario o permitido en el aula");
                Console.Write("Capacidad: {0}", Capacidad);
                if (ProfesorEncargado != "0")
                {
                    Console.Write("Profesor Encargado: {0}", ProfesorEncargado);
                }
                else
                {
                    Console.Write("No Hay profesor");
                }
                Console.WriteLine();
            }
        }
        public void MostrarNotas()
        {
            if (Alumnado.Capacity > 0) { 
            foreach (alumno Alumno in Alumnado)
            {
                if (Alumno.Sexo == "Femenino")
                {
                    string estado;
                    float nota = Alumno.MostrarNota();
                    if (nota < 5.1)
                    {
                        estado = "REPROBADO";
                    }
                    else
                    {
                        estado = "APROBADO";
                    }
                    Console.WriteLine("Nombre: {0}, status:{1}", Alumno.Nombre, estado);
                }
            }
            foreach (alumno Alumno in Alumnado)
            {
                if (Alumno.Sexo == "Masculino")
                {
                    string estado;
                    float nota = Alumno.MostrarNota();
                    if (nota < 5.1)
                    {
                        estado = "REPROBADO";
                    }
                    else
                    {
                        estado = "APROBADO";
                    }
                    Console.WriteLine("Nombre: {0}, status:{1}", Alumno.Nombre, estado);
                }
            }
            }
            else
            {
                Console.WriteLine("NO hay alumnado");            
            }
        }
        public override string ToString()
        {
            return string.Format("Identificar: {0}, Capacidad:{1}, Materia:{2}", Identificador, Capacidad, Materia);
        }
        int Identificador { get; set; }
        int Capacidad { get; set; }
        string Materia { get; set; }
        string ProfesorEncargado { get; set; }
        List<alumno> Alumnado = new List<alumno>();
    }
}
