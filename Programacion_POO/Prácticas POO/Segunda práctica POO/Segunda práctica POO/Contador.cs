using System;
using System.Collections.Generic;
using System.Text;

namespace Segunda_práctica_POO
{
    class Contador
    {
        public Contador(Contador ContadorPrevio)
        {
            Valor = ContadorPrevio.Valor;
        }
        public Contador(int valor)
        {
            Valor = valor;
        }
        public void Incrementar(int incremento)
        {
            Valor = Valor + incremento;
        }
        public void Decrementar(int decremento)
        {
            Valor = Valor + decremento;
        }
        public int Valor { get; set; }
    }
}
