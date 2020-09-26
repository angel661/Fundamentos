using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Que pida un número y diga si es primo o no.
            Console.WriteLine("1.Que pida un número y diga si es primo o no.");
            Console.Write("Ingrese un numero:   ");int numeroprimo = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            int index=1;
            while (index <= numeroprimo)
            {
                if (numeroprimo != 1)
                {
                    int aux01;
                    aux01 = numeroprimo % index;
                    if(aux01==0)
                    {
                        contador++;
                    }
                }
                //Console.WriteLine("index: {0}",index);
                index++;
            }
            bool siesentero = numeroprimo % 1 == 0;
            if (siesentero&&numeroprimo!=0)
            {
                if (numeroprimo == 1)
                    Console.WriteLine("El numero 1 es neutro");
                else
                {
                    if (contador == 2)
                        Console.WriteLine("El numero {0} es primo", numeroprimo);
                    else
                        Console.WriteLine("El numero {0} no es primo", numeroprimo);
                }
            }
            else
                Console.WriteLine("No es numero entero");
            Console.WriteLine("------------------------------------------------------");
            //2.Que muestre los números del 1 al 100.
            Console.WriteLine("2.Que muestre los números del 1 al 100.");
            int index2 = 1;
            while(index2 <= 100)
            {
                Console.Write("{0}   ", index2);
                if (index2 % 10 == 0)
                    Console.Write("\n");
                index2++;
            }
            Console.WriteLine("\n------------------------------------------------------");

            //3.Que muestre los números del 100 al 1.
            Console.WriteLine("3.Que muestre los números del 100 al 1.");
            int index3 = 100;
            while(index3>0)
            {
                
                if (index3 % 10 == 0)
                    Console.Write("\n");
                Console.Write("{0}   ", index3);
                index3--;
            }
            Console.Write("\n");
            Console.WriteLine("------------------------------------------------------");

            //4.Que muestre los números pares que haya del 1 al 100.
            Console.WriteLine("4.Que muestre los números pares que haya del 1 al 100.");
            int index4 = 1;
            while (index4 <= 100)
            {
                if (index4 % 2 == 0)
                    Console.Write("{0}   ",index4);
                if (index4 % 10 == 0)
                    Console.Write("\n");
                index4++;
            }
            Console.WriteLine("------------------------------------------------------");

            //5.Que muestre los números impares que haya del 1 al 100.
            Console.WriteLine("5.Que muestre los números impares que haya del 1 al 100.");
            int index5 = 1;
            while (index5 <= 100)
            {
                if (index5 % 2 != 0)
                    Console.Write("{0}   ", index5);
                if (index5 % 10 == 0)
                    Console.Write("\n");
                index5++;
            }
            Console.WriteLine("------------------------------------------------------");

            //6.Que imprima la suma de todos los números que van del 1 al 100.
            Console.WriteLine("6.Que imprima la suma de todos los números que van del 1 al 100.");
            int suma6=0;
            int index6 = 1;
            while (index6 <= 100)
            {
                suma6 = suma6 + index6;
                index6++;
            }
            Console.WriteLine("La suma del 1 al 100 es:  {0}",suma6);
            Console.WriteLine("------------------------------------------------------");

            //7.Que imprima la suma de todos los números pares que van del 1 al 100.
            Console.WriteLine("7.Que imprima la suma de todos los números pares que van del 1 al 100.");
            int suma7 = 0;
            int index7 = 1;
            while (index7 <= 100)
            {
                if(index7%2==0)
                    suma7 = suma7 + index7;
                index7++;
            }
            Console.WriteLine("La suma de numeros pares del 1 al 100 es:  {0}", suma7);

            Console.WriteLine("------------------------------------------------------");

            //8.Que imprima la suma de todos los números impares que van del 1 al 100.
            Console.WriteLine("8.Que imprima la suma de todos los números impares que van del 1 al 100.");
            int suma8 = 0;
            int index8 = 1;
            while (index8 <= 100)
            {
                if (index8 % 2 != 0)
                    suma8 = suma8 + index8;
                index8++;
            }
            Console.WriteLine("La suma de numeros impares del 1 al 100 es:  {0}", suma8);
            Console.WriteLine("------------------------------------------------------");

            //9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.
            Console.WriteLine("9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.");
            int suma9 = 0;
            int contadornumero9 = 0;
            int index9 = 1;
            while (index9 <= 100)
            {
                if (index9 % 2 == 0)
                {
                    suma9 = suma9 + index9;
                    contadornumero9++;
                }
                    
                index9++;
            }
            Console.WriteLine("La suma de numeros pares del 1 al 100 es:  {0}    y existe  {1}  numeros pares", suma9,contadornumero9);
            Console.WriteLine("------------------------------------------------------");
            //10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga 
            //cuántos hay.
            Console.WriteLine("10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.");
            int suma10 = 0;
            int contadornumero10 = 0;
            int index10 = 1;
            while (index10 <= 100)
            {
                if (index10 % 2 == 0)
                {
                    suma10 = suma10 + index10;
                    contadornumero10++;
                }

                index10++;
            }
            Console.WriteLine("La suma de numeros pares del 1 al 100 es:  {0}    y existe  {1}  numeros impares", suma10, contadornumero10);
            Console.WriteLine("------------------------------------------------------");
            //11.Que pida dos números y muestre todos los números que van desde el primero 
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("11.Que pida dos números y muestre todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.Write("Ingrese el primer numero:  ");int primernumero11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:  "); int segundonumero11 = Convert.ToInt32(Console.ReadLine());
            if (primernumero11 < segundonumero11)
            {
                for(int contador11=primernumero11;contador11<=segundonumero11;contador11++)
                {
                    Console.WriteLine("  {0}  ",contador11);
                }
            }
            else
                Console.WriteLine("Los numeros ingresados no cumplen con lo requerido.");
            Console.WriteLine("------------------------------------------------------");
            //12.Que pida dos números y muestre todos los números pares que van desde el 
            //primero al segundo. Se debe controlar que los valores son correctos.
            Console.WriteLine("12.Que pida dos números y muestre todos los números pares que van desde el primero al segundo. Se debe controlar que los valores son correctos.");
            Console.Write("Ingrese el primer numero:  "); int primernumero12 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:  "); int segundonumero12 = Convert.ToInt32(Console.ReadLine());
            if (primernumero12 < segundonumero12)
            {
                for (int contador12 = primernumero12; contador12 <= segundonumero12; contador12++)
                {
                    if(contador12%2==0)
                        Console.WriteLine(" {0}  ", contador12);

                }
            }
            else
                Console.WriteLine("Los numeros ingresados no cumplen con lo requerido.");
            Console.WriteLine("------------------------------------------------------");
            //13.Que pida dos números y muestre todos los números impares que van desde el 
            //primero al segundo. Se debe controlar que los valores son correctos.
            Console.WriteLine("13.Que pida dos números y muestre todos los números impares que van desde el primero al segundo. Se debe controlar que los valores son correctos.");
            Console.Write("Ingrese el primer numero:  "); int primernumero13 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:  "); int segundonumero13 = Convert.ToInt32(Console.ReadLine());
            if (primernumero13 < segundonumero13)
            {
                for (int contador13 = primernumero13; contador13 <= segundonumero13; contador13++)
                {
                    if (contador13 % 2 != 0)
                        Console.WriteLine(" {0}  ", contador13);

                }
            }
            else
                Console.WriteLine("Los numeros ingresados no cumplen con lo requerido.");

            Console.WriteLine("------------------------------------------------------");
            //14.Que pida dos números y sume todos los números que van desde el primero 
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("14.Que pida dos números y sume todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.Write("Ingrese el primer numero:  "); int primernumero14 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:  "); int segundonumero14 = Convert.ToInt32(Console.ReadLine());
            if (primernumero14 < segundonumero14)
            {
                int suma14 = 0;
                for (int contador14 = primernumero14; contador14 <= segundonumero14; contador14++)
                {
                    suma14 = suma14+contador14;
                }
                Console.WriteLine("La suma de los numeros del primero al segundo es: {0}  ", suma14);
            }
            else
                Console.WriteLine("Los numeros ingresados no cumplen con lo requerido.");
            Console.WriteLine("------------------------------------------------------");
            //15.Que pida dos números y multiplique todos los números que van desde el primero
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("15.Que pida dos números y multiplique todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.Write("Ingrese el primer numero:  "); int primernumero15 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:  "); int segundonumero15 = Convert.ToInt32(Console.ReadLine());
            if (primernumero15 < segundonumero15)
            {
                int suma15 = 1;
                for (int contador15 = primernumero15; contador15 <= segundonumero15; contador15++)
                {
                    suma15 = suma15 * contador15;
                }
                Console.WriteLine("La multiplicacion de los numeros del primero al segundo es: {0}  ", suma15);
            }
            else
                Console.WriteLine("Los numeros ingresados no cumplen con lo requerido.");
            Console.WriteLine("------------------------------------------------------");
            //16.Que pida un número y muestre en pantalla el mismo número de asteriscos.
            Console.WriteLine("16.Que pida un número y muestre en pantalla el mismo número de asteriscos.");
            char estrella16 = '*';
            Console.Write("Ingrese un numero:  "); int primernumero16 = Convert.ToInt32(Console.ReadLine());
            for (int index16 = 0; index16 < primernumero16; index16++)
                Console.Write("{0}",estrella16);
            Console.Write("\n");
            Console.WriteLine("------------------------------------------------------");
            //17.Que muestre los números del 1 al 100 en una tabla de 10x10.
            Console.WriteLine("17.Que muestre los números del 1 al 100 en una tabla de 10x10.");

            for (int index17 = 1; index17 <= 100; index17++)
            {
                Console.Write("{0}   ", index17);
                if (index17 % 10 == 0)
                    Console.Write("\n");
            }
        

            Console.WriteLine("------------------------------------------------------");
            //18.Que escriba las tablas de multiplicar del 0 al 10.
            Console.WriteLine("18.Que escriba las tablas de multiplicar del 0 al 10.");
            Console.WriteLine("------------------------------------------------------");
            //19.Que muestre la tabla de multiplicar de un número cualquiera.
            Console.WriteLine("19.Que muestre la tabla de multiplicar de un número cualquiera.");
            Console.WriteLine("------------------------------------------------------");
            //20.Que haga un menú del tipo “desea salir(S/ N)” y el programa no termine hasta
            //que el usuario teclee “S”.
            Console.WriteLine("20.Que haga un menú del tipo “desea salir(S/ N)” y el programa no termine hasta que el usuario teclee “S”.");
            Console.WriteLine("------------------------------------------------------");
            //21.Que calcule el factorial de un número cualquiera y lo muestre en pantalla.
            Console.WriteLine("21.Que calcule el factorial de un número cualquiera y lo muestre en pantalla.");
            Console.WriteLine("------------------------------------------------------");
            //22.Que calcule la media de 10 números.
            Console.WriteLine("22.Que calcule la media de 10 números.");
            Console.WriteLine("------------------------------------------------------");
            //23.Que calcule la media de X números, se dejarán de solicitar números hasta 
            //que se introduzca el cero.
            Console.WriteLine("23.Que calcule la media de X números, se dejarán de solicitar números hasta que se introduzca el cero.");
            Console.WriteLine("------------------------------------------------------");
            //24.Que calcule la suma de los cuadrados de los 100 primeros números.
            Console.WriteLine("24.Que calcule la suma de los cuadrados de los 100 primeros números.");
            Console.WriteLine("------------------------------------------------------");
            //25.Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.
            Console.WriteLine("25.Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
