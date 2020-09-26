using System;
using System.Globalization;

namespace Practica_variables
{
    class Program
    {


        static void Main(string[] args)
        {
            ////1.declare 5 variables primitivas numericas
            //int numero1;
            //short numero2;
            //long numero3;
            //float numero5;
            //double numero;
            ////2. declare 3 variables primitivas de tipo texto
            //string palabra;
            //char caracter;
            //bool eleccion;

            //////3. declare 5 variables numeroicas y asigneles un valor
            //int num = 10;
            //long num1 = 122;
            //float num2 = 67;
            //double num3 = 23.5;
            //short num4 = 26;
            ////4. declare 3 variables de texto e ingrese una valor por teclado
            //Console.WriteLine("introduzca tres palabras");
            //string palabra1 = Convert.ToString(Console.ReadLine());
            //string palabra2 = Convert.ToString(Console.ReadLine());
            //string palabra3 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(palabra1+" "+palabra2+" "+palabra3);
           ////5. ingrese valores numericos por teclado y muestrelos en consola con la frase
            //"el numero que ingreso es:"
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("el numero que ingreso es:");
            //Console.WriteLine("");
            //Console.WriteLine(n1 + " " + n2 + " " + n3);
            ////6.Realice 5 ejemplos de conversion implicita
            //byte n4 = 200;
            //int n5 = n4;
            //double n6 = n5;

            //int nnn = 23;
            //double nn = nnn;

            //short ll = 14;
            //float lll = ll;

            //float r = 21;
            //double rr = r;

            //long e = 56;
            //float ee = e;
            ////7. Realice 5 ejemplos de conversion explicita
            //string q = "457";
            //int qq = Convert.ToInt32(q);

            //double t = 2.56;
            //byte tt = Convert.ToByte(t);

            //char u = 't';
            //string uu = Convert.ToString(u);

            //float d = 123;
            //byte dd = Convert.ToByte(d);

            //bool c = true;
            //int cc = Convert.ToInt32(c);

            //Console.WriteLine(cc);
            ////8. ingrese dos numeros por teclado yverfique cual es el mayor y cual el menor
            //Console.WriteLine("ingrese dos numeros por teclado");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine("el  numero mayor es: " + num1);
            //    Console.WriteLine("el numero menor es: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("el  numero mayor es: " + num2);
            //    Console.WriteLine("el numero menor es: " + num1);
            //}

            ////9. ingrese un numero por teclado y verifique si es par
            //Console.WriteLine("ingrese un numero por teclado");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("el numero es par " + num);
            //}
            //else
            //{
            //    Console.WriteLine("elnumero es impar " + num);
            //}

            //10. ingrese un numero por teclado y verifique si es multiplo de 3,5 o 7
            Console.WriteLine("ingrese un numero por teclado");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%3==0 && num % 5 == 0)
            {
                Console.WriteLine("el numero es multiplo de 3 y 5 " + num);
            }
            else
            {
                if (num % 3 == 0 && num % 7 == 0)
                {
                    Console.WriteLine("el numero es multiplo de 3 y 7 " + num);

                }
                else
                {
                    if (num % 5 == 0 && num % 7 == 0)
                    {
                        Console.WriteLine("el numero es multiplo de 5 y 7 " + num);
                    }
                    else
                    {
                        if (num % 3 == 0)
                        {
                            Console.WriteLine("el numero es multiplo de 3 " + num);

                        }
                        else
                        {
                            if (num % 5 == 0)
                            {
                                Console.WriteLine("el numero es multiplo de 5 " + num);

                            }
                            else
                            {
                                if (num % 7 == 0)
                                {
                                    Console.WriteLine("el numero es multiplo de 7 " + num);
                                }
                                else
                                {
                                    Console.WriteLine("no es multiplo de 3,5,7");
                                }
                            }
                        }

                    }
                }
            }

        }


        
    }
}
