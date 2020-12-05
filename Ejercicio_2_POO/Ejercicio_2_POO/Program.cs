using Libreria.Raices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Raices ecuaciones1 = new Raices(1, -5, 6);
            Raices ecuaciones2 = new Raices(3, 1, 2);

            ecuaciones1.calcular();
            ecuaciones2.calcular();

        }
    }
}
