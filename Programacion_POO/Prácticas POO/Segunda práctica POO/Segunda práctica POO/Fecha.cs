using System;

namespace Segunda_práctica_POO
{
    class Fecha
        {
            public Fecha(int dia, int mes, int año)
            {
                Dia = dia;
                Mes = mes;
                Año = año;
            }
            public void incrementar()
            {
                Dia++;
                if (Dia >= 31 &&(Mes == 04 || Mes == 06 || Mes == 09 || Mes == 11))
                {
                    Mes++;
                    Dia = 1;
                }
                else if (Dia >= 32 && (Mes == 01 || Mes == 03 || Mes == 05 || Mes == 07 || Mes == 08 || Mes == 10))
                {
                    Mes++;
                    Dia = 1;
                }
                else if (Dia >= 32 &&  Mes >= 12)
                {
                    Mes = 1;
                    Año++;
                    Dia = 1;
                }
                else if (Dia >= 29 && Mes == 2)
                {
                    Mes++;
                    Dia = 1;
                }
            }
            public void revisar()
            {
                if ((Mes == 04 || Mes == 06 || Mes == 09 || Mes == 11) && Dia >= 1 && Dia <= 30)
                {
                    Console.WriteLine("La Fecha es correcta");
                }
                else if ((Mes == 01 || Mes == 03 || Mes == 05 || Mes == 07 || Mes == 08 || Mes == 10) && Dia >= 1 && Dia <= 31)
                {
                    Console.WriteLine("La Fecha es correcta");
                }

                else if (Mes == 2 && Dia >= 1 && Dia <= 28)
                {
                    Console.WriteLine("La fecha es correcta");
                }
                else
                {
                    Console.WriteLine("La fecha no es correcta");
                }
            }
            public override string ToString()
            {
                return string.Format("{0}/{1}/{2}",Dia,Mes,Año);
            }
            int Dia { set; get; }
            int Mes { set; get; }
            int Año { set; get; }
        }
}
