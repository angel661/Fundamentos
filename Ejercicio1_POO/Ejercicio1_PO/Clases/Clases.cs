using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PO.Clases
{
    class Cuenta
    {
        public int Ingreso { get; set; }
        public int Reintegro { get; set; }
        public int Transferencia { get; set; }

        public Cuenta(int ingreso, int reintegro, int transferencia)
        {
            this.Ingreso = ingreso;
            this.Reintegro = reintegro;
            this.Transferencia = transferencia;

        }
    }
}
