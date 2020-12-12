using System;

namespace practica_2_POO
{
    class Contador
    {

        public int Conta { get; set; }

        public Contador()
        {

        }
        public Contador(int conta)
        {
            if (conta < 0)
            {
                Conta = 0;
            }
            else
            {
                Conta = conta;
            }

        }
        public Contador(Contador con)
        {
            Conta = con.Conta;
        }
        public void Incrementar(int limite)
        {

            for (int index = 0; index < limite; index++)
            {
                Console.Write(index + " ");
            }


        }
        public void Decrementar(int limite)
        {
            Conta = 50;
            for (int index = Conta; index > limite; index--)
            {
                Console.Write(index + " ");
            }
        }
        public string ToString()
        {
            return "El contador es=" + Conta;
        }
    }
}
