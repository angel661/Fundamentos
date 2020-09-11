using System;
using System.Security.Cryptography;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Decalre 5 variables primitivas.
            int V1, v2;
            double V3, V4;
            float V5;

            //2) Declare 3 variables primitivas de tipo texto.
            string frase1 = "Hola buenas tardes.";
            string frase2 = "¿Cómo te llamas?";
            string frase3 = "Mi nombre es Fabio.";


            //3) Declare 5 variables númericas y asigne un valor.
            int N1 = 15;
            int N2 = 35;
            int N3 = 20;

            //4) Declare 3 variables de texto e ingrese un valor por teclado.
            string texto1 = "";
            string texto2 = "";
            string texto3 = "";


            //5) Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”.
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número que ingresó es {0}", valor);

            //6) Realice 5 ejemplos de conversión implícita.
            int a = 10;
            long b;
            b = 10;

            int A = 15;
            valor = a;

            byte c = 255;
            int d;
            d = 255;

            short C = -200;
            int D;
            D = C;

            sbyte E = 105;
            double F;
            F = E;

            //7) Realice 5 ejemplos de conversión explicita.
            sbyte g = 110;
            byte num1 = Convert.ToByte(g);

            string texto = "561";
            int num2 = Convert.ToInt32(texto);

            int h = 156;
            double num3 = Convert.ToDouble(h);

            int i = 2000000;
            string num4 = Convert.ToString(i);

            byte j = 255;
            int num5 = Convert.ToInt32(j);



        }
    }
}
