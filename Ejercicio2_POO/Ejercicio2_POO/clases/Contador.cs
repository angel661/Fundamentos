using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_POO.clases
{
    class Contador
    {
        public int Incrementar { get; set; }
        public int Decremetnear { get; set; }
        

        public Contador(int incrementador, int decrementador)
        {
            this.Incrementar = incrementador;
            this.Decremetnear = decrementador;
            
        }
    }
}
