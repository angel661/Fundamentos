using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.Cine
{
    class Pelicula
    {
        Pelicula(string titulo, int duracion, int edadMin, string director)
        {
            Titulo = titulo;
            Duracion = duracion;
            EdadMin = EdadMin;
            Director = director;
        }
        string Titulo { get; set; }
        int Duracion { get; set; }
        int EdadMin { get; set; }
        string Director { get; set; }
        public int Miedadmin()
        {
            return EdadMin;
        }
    }
}
