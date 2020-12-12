using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_POO
{
    public class Fecha
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }

        public Fecha(int dia, int mes, int año)
        {
            Dia = dia;
            Mes = mes;
            Año = año;

        }
        public bool fechaCorrecta()
        {
            bool diaCorrecto, mesCorrecto, añoCorrecto;
            añoCorrecto = Año > 0;
            mesCorrecto = Mes >= 1 && Mes <= 12;
            string error = "mal";

            switch (Mes)
            {
                case 1:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 2:
                    diaCorrecto = Dia >= 1 && Dia <= 28;
                    break;
                case 3:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 4:
                    diaCorrecto = Dia >= 1 && Dia <= 30;
                    break;
                case 5:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 6:
                    diaCorrecto = Dia >= 1 && Dia <= 30;
                    break;
                case 7:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 8:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 9:
                    diaCorrecto = Dia >= 1 && Dia <= 30;
                    break;
                case 10:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                case 11:
                    diaCorrecto = Dia >= 1 && Dia <= 30;
                    break;
                case 12:
                    diaCorrecto = Dia >= 1 && Dia <= 31;
                    break;
                default:
                    diaCorrecto = false;
                    break;
            }
            return diaCorrecto && mesCorrecto && añoCorrecto;
        }
        public string ToString()
        {
            return "EL DIA ES " + Dia + " EL MES ES " + Mes + " EL AÑO ES "
                + Año;
        }
        public void Modificar()
        {
            if (fechaCorrecta())
            {
                Dia++;
                if (!fechaCorrecta())
                {
                    Dia = 1;
                    Mes++;
                    if (!fechaCorrecta())
                    {
                        Mes = 1;
                        Año++;
                    }

                }
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine("error");
            }
           

        }
    }
}
