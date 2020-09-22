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
            Console.WriteLine("------------------------------------------------------");

            //3.Que muestre los números del 100 al 1.
            Console.WriteLine("3.Que muestre los números del 100 al 1.");
            Console.WriteLine("------------------------------------------------------");

            //4.Que muestre los números pares que haya del 1 al 100.
            Console.WriteLine("4.Que muestre los números pares que haya del 1 al 100.");
            Console.WriteLine("------------------------------------------------------");

            //5.Que muestre los números impares que haya del 1 al 100.
            Console.WriteLine("5.Que muestre los números impares que haya del 1 al 100.");
            Console.WriteLine("------------------------------------------------------");

            //6.Que imprima la suma de todos los números que van del 1 al 100.
            Console.WriteLine("6.Que imprima la suma de todos los números que van del 1 al 100.");
            Console.WriteLine("------------------------------------------------------");

            //7.Que imprima la suma de todos los números pares que van del 1 al 100.
            Console.WriteLine("7.Que imprima la suma de todos los números pares que van del 1 al 100.");
            Console.WriteLine("------------------------------------------------------");

            //8.Que imprima la suma de todos los números impares que van del 1 al 100.
            Console.WriteLine("8.Que imprima la suma de todos los números impares que van del 1 al 100.");
            Console.WriteLine("------------------------------------------------------");

            //9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.
            Console.WriteLine("9.Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.");
            Console.WriteLine("------------------------------------------------------");
            //10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga 
            //cuántos hay.
            Console.WriteLine("10.Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.");
            Console.WriteLine("------------------------------------------------------");
            //11.Que pida dos números y muestre todos los números que van desde el primero 
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("11.Que pida dos números y muestre todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.WriteLine("------------------------------------------------------");
            //12.Que pida dos números y muestre todos los números pares que van desde el 
            //primero al segundo. Se debe controlar que los valores son correctos.
            Console.WriteLine("12.Que pida dos números y muestre todos los números pares que van desde el primero al segundo. Se debe controlar que los valores son correctos.");
            Console.WriteLine("------------------------------------------------------");
            //13.Que pida dos números y muestre todos los números impares que van desde el 
            //primero al segundo. Se debe controlar que los valores son correctos.
            Console.WriteLine("13.Que pida dos números y muestre todos los números impares que van desde el primero al segundo. Se debe controlar que los valores son correctos.");
            Console.WriteLine("------------------------------------------------------");
            //14.Que pida dos números y sume todos los números que van desde el primero 
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("14.Que pida dos números y sume todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.WriteLine("------------------------------------------------------");
            //15.Que pida dos números y multiplique todos los números que van desde el primero
            //al segundo.Se debe controlar que los valores son correctos.
            Console.WriteLine("15.Que pida dos números y multiplique todos los números que van desde el primero al segundo.Se debe controlar que los valores son correctos.");
            Console.WriteLine("------------------------------------------------------");
            //16.Que pida un número y muestre en pantalla el mismo número de asteriscos.
            Console.WriteLine("16.Que pida un número y muestre en pantalla el mismo número de asteriscos.");
            Console.WriteLine("------------------------------------------------------");
            //17.Que muestre los números del 1 al 100 en una tabla de 10x10.
            Console.WriteLine("17.Que muestre los números del 1 al 100 en una tabla de 10x10.");
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
