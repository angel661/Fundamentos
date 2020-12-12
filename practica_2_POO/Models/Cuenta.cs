namespace practica_2_POO
{
    class Cuenta
    {
        public string Nombre { get; set; }
        public string NumeroCuenta { get; set; }
        private double Saldo { get; set; }
        public Cuenta()
        {

        }
        public Cuenta(string nombre, string numerocuenta, double saldo)
        {
            Nombre = nombre;
            NumeroCuenta = numerocuenta;
            Saldo = saldo;
        }
        public bool Ingreso(double n)
        {
            bool ingresoCorrecto = true;
            if (n > 0)
            {
                Saldo = Saldo + n;
            }
            else
            {
                ingresoCorrecto = false;
            }
            return ingresoCorrecto;
        }
        public bool reIntegro(double n)
        {
            bool correcto = true;
            if (n < 0)
            {
                correcto = false;

            }
            else if (Saldo >= n)
            {
                Saldo -= n;
            }
            else
            {
                correcto = false;
            }
            return correcto;
        }
        public bool Transferencia(Cuenta c, double n)
        {
            bool correcto = true;
            if (n < 0)
            {
                correcto = false;
            }
            else
            {
                if (Saldo >= 0)
                {
                    reIntegro(n);
                    c.Ingreso(n);
                }
                else
                {
                    correcto = false;
                }
            }
            return correcto;
        }
        public string ToString()
        {
            return "NOMBRE=" + Nombre + "\n" + "NUMERO CUENTA =" + NumeroCuenta + "\n" + "SALDO=" + Saldo;
        }
    }
}
