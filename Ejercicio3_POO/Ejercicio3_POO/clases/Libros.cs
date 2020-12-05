using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_POO.clases
{
    class Libros
    {
        private int Prestamo;
        private int Devolucion;
        public Libros (int prestamo, int devolucion)
        {
            this.Prestamo = prestamo;
            this.Devolucion = devolucion;
        }
        public int prestamo { get => Prestamo; set => Prestamo = value; }
        public int devolucion { get => Devolucion; set => Devolucion = value; }

        public override string ToString()
        {
            return "El prestamo es de "+ prestamo +" y la devolucion es "+ devolucion + " dejando un saldo de "+ (prestamo-devolucion);
        }
    }
}
