using Ejercicio1_PO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta(150, 50, 50);
            Console.WriteLine(cuenta1.Ingreso);
            Console.WriteLine(cuenta1.Reintegro);
            Console.WriteLine(cuenta1.Transferencia);
        }
    }
}
