using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class Cuenta
    {
        public Cuenta(Cuenta CuentaAnterior)
        {
            Dinero = CuentaAnterior.Dinero;
        }
        public Cuenta(int dinero)
        {
            Dinero = dinero;
        }
        int Dinero { get; set; }

        public void Ingreso(int ingreso)
        {
            Dinero = Dinero + ingreso;
        }
        public void Reintegro(int Reintegro)
        {
            Dinero = Dinero + Reintegro;
        }
        public Cuenta transferencia(int transferencia, Cuenta SegundaCuenta)
        {
            Dinero = Dinero - transferencia;
            SegundaCuenta.Dinero = SegundaCuenta.Dinero + transferencia;
            return SegundaCuenta;
        }
    }
}
