using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.- Declare 5 variables primitivas numéricas
            //byte numbyte;
            //int numint;
            //long numlong;
            //float numfloat;
            //double numdouble;



            ////2.- Declare 3 variables primitivas de tipo texto.
            //char textchar;
            //string textstring;
            //char letra;



            ////3.- Declare 5 variables numéricas y asígneles un valor.
            //byte numbyte = 1;
            //int numint = 300;
            //long numlong = 1001;
            //float numfloat = 35;
            //double numdouble = 3.555;



            ////4.- Declare 3 variables de texto e ingrese un valor por teclado.
            //string cadena1;
            //string cadena2;
            //string cadena3;
            //cadena1 = Console.ReadLine();
            //cadena2 = Console.ReadLine();
            //cadena3 = Console.ReadLine();



            ////5.- Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”.
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El número que ingreso es: {0}", numero);



            ////6.- Realice 5 ejemplos de conversión implícita.
            //int numint = 8;
            //long numlong = numint;

            //int numint1 = 5;
            //byte numbyte = 110;
            //numint1 = numbyte;

            //long numlong1 = 51;
            //float numfloat = numlong1;

            //float numfloat1 = 112;
            //Double numdouble = numfloat1;

            //int numint5 = 5;
            //decimal numdecimal = numint5;



            ////7.- Realice 5 ejemplos de conversión explicita.
            //long numlong = 6699;
            //int numint = (int)numlong;

            //int numint1 = 155;
            //byte numero = (byte)numint1;

            //string textnum = "12";
            //int numint2 = int.Parse(textnum);

            //string textnum1 = "1980";
            //int numint3 = Convert.ToInt32(textnum1);

            //int numint4 = 40;
            //byte numbyte = Convert.ToByte(numint4);



            ////8.- Ingrese dos números por teclado y verifique cual es el mayor y cual el menor
            //Console.WriteLine("Ingrese los numeros");
            //string valor1 = Console.ReadLine();
            //string valor2 = Console.ReadLine();
            //int num1 = Convert.ToInt32(valor1);
            //int num2 = Convert.ToInt32(valor2);
            //if (num1 > num2)
            //{
            //    Console.WriteLine("El numero mayor es {0} y el menor es {1}", num1, num2);
            //}
            //else
            //{
            //    Console.WriteLine("El numero mayor es {0} y el menor es {1}", num2, num1);
            //}



            ////9.- Ingrese un numero por teclado y verifique si es par.
            //Console.WriteLine("Ingrese un numero");
            //string valor1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(valor1);
            //if (num1 % 2 == 0)
            //    Console.WriteLine("El numero {0} es par", num1);
            //else
            //    Console.WriteLine("El numero {0} es impar", num1);



            //10.- Ingrese un numero por teclado y verifique si es múltiplo de 3, 5 o 7.
            Console.WriteLine("Ingrese un numero");
            string valor1 = Console.ReadLine();
            int num1 = Convert.ToInt32(valor1);
            if (num1 % 3 == 0)
                Console.WriteLine("El numero {0} es multiplo de 3", num1);
            else if (num1 % 5 == 0)
                Console.WriteLine("El numero {0} es multiplo de 5", num1);
            else if (num1 % 7 == 0)
                Console.WriteLine("El numero {0} es multiplo de 7", num1);
            else
                Console.WriteLine("El numero {0} no es multiplo de 3, 5 o 7", num1);
        }
    }
}
