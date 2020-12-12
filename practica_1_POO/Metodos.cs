using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO
{
    class Metodos
    {
        public static int GenerarNumerosAlatorios(int minimo, int maximo)
        {
            Random ran = new Random();
            int num = ran.Next(minimo, maximo);
            return num;
        }
    }
}
