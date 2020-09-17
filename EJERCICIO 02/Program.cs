using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Escribir un programa, que reciba una edad como entero por parámetro 
            //      y muestre un mensaje por pantalla si es mayor de edad o no.
            Console.WriteLine("1.- Escribir un programa, que reciba una edad como entero por parámetro y muestre un mensaje por pantalla si es mayor de edad o no.");
            Console.WriteLine("Ingrese la edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("Es menor de edad");
            Console.WriteLine("----------------------------------------------------------------");
            //2.- Escribir un programa, que reciba un entero por parámetro y muestre 
            //      un mensaje por pantalla que indique si es mayor o menor que 25.
            Console.WriteLine("2 .- Escribir un programa, que reciba un entero por parámetro y muestre un mensaje por pantalla que indique si es mayor o menor que 25.");
            Console.WriteLine("Ingrese un numero par verificar si es mayor o menor a 25");
            int numero25 = Convert.ToInt32(Console.ReadLine());
            if (numero25 > 25)
                Console.WriteLine("El numero es mayor que 25");
            else if (numero25 < 25)
                Console.WriteLine("El numero es menor que 25");
            else
                Console.WriteLine("El numero no corresponde por que es es igual a 25");
            Console.WriteLine("----------------------------------------------------------------");
            //3.- Realiza un programa, que pida el nombre y los apellidos de dos personas 
            //      y los escriba ordenados alfabéticamente, teniendo en cuenta los dos apellidos,
            //      y si fuese necesario, el nombre
            Console.WriteLine("3.- Realiza un programa, que pida el nombre y los apellidos de dos personas y los escriba ordenados alfabéticamente, teniendo en cuenta los dos apellidos, y si fuese necesario, el nombre");
            Console.WriteLine("Ingrese nombre y apellidos de la primera persona:");
            string nombreyapellidos01 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre y apellidos de la segunda persona:");
            string nombreyapellidos02 = Console.ReadLine();
            string[] primerapersona = nombreyapellidos01.Split(' ');
            string apellido1 = primerapersona[1];
            string[] segundapersona = nombreyapellidos02.Split(' ');
            string apellido2 = segundapersona[1];
            char caracter1 = apellido1[0];
            char caracter2 = apellido2[0];
            Console.WriteLine("LISTA ALFABETICA DE ACUERDO A APELLIDOS");
            if (caracter1 >= caracter2)
            {
                Console.WriteLine("1.- {0}", nombreyapellidos01);
                Console.WriteLine("2.- {0}", nombreyapellidos02);
            }
            else
            {
                Console.WriteLine("1.- {0}", nombreyapellidos02);
                Console.WriteLine("2.- {0}", nombreyapellidos01);
            }

            string nombre1 = primerapersona[0];
            string nombre2 = segundapersona[0];
            char letranombre1 = nombre1[0];
            char letranombre2 = nombre2[0];
            Console.WriteLine("LISTA ALFABETICA DE ACUERDO A NOMBRE");
            if (letranombre1 >= letranombre2)
            {
                Console.WriteLine("1.- {0}", nombreyapellidos01);
                Console.WriteLine("2.- {0}", nombreyapellidos02);
            }
            else
            {
                Console.WriteLine("1.- {0}", nombreyapellidos02);
                Console.WriteLine("2.- {0}", nombreyapellidos01);
            }
            Console.WriteLine("----------------------------------------------------------------");
            //4.- Escribe un programa, que calcule la cuota que se debe abonar en un club 
            //      de paddel. La cuota es de 800 euros.Tendrán un 40 % de descuento las 
            //      personas mayores de 65 años y un 25 % de descuento los menores de 21 años, 
            //      si los padres no son socios, y un 45 % si los padres son socios
            Console.WriteLine("4.- Escribe un programa, que calcule la cuota que se debe abonar en un club de paddel. La cuota es de 800 euros. Tendrán un 40% de descuento las personas mayores de 65 años y un 25% de descuento los menores de 21 años, si los padres no son socios, y un 45% si los padres son socios");
            Console.WriteLine("INGRESE EL NUMERO DE OPCION QUE CORRESPONDE:");
            Console.WriteLine("(1) ES SOCIO");
            Console.WriteLine("(2) NO ES SOCIO");
            Console.WriteLine("INGRESE EL NUMERO DE OPCION QUE CORRESPONDE:");
            double cuotapersona;
            double cuotasocio;
            int opcionsocio = Convert.ToInt32(Console.ReadLine());
            if (opcionsocio == 1)
            {
                cuotasocio = 800-(800 * 0.45);
                Console.WriteLine("El socio tiene un 45% de descuento de 800 euros, el total de pago es:{0}", cuotasocio);
            }
            else if (opcionsocio == 2)
            {
                Console.WriteLine("Ingrese edad de la persona");
                int edadsocio = Convert.ToInt32(Console.ReadLine());
                if (edadsocio > 65)
                {
                    cuotapersona = 800-(800 * 0.4);
                    Console.WriteLine("La persona tendra 40% de descuento de 800 euros, el total de pago es:{0}", cuotapersona);
                }
                else if (edadsocio < 21)
                {
                    cuotapersona = 800-(800 * 0.25);
                    Console.WriteLine("La persona tendra 40% de descuento de 800 euros, el total de pago es:{0}", cuotapersona);
                }
                else
                {
                    Console.WriteLine("La persona pagara 800 euros, no tiene descuento");
                }
            }
            else
                Console.WriteLine("OPCION INCORRECTA");
            Console.WriteLine("----------------------------------------------------------------");
            //5.- Escribe un programa, que reciba como parámetros tres valores enteros 
            //      con el día, mes y año de una fecha y devuelva un valor booleano que 
            //      indique si se trata de valores válidos para una fecha.
            //6.- Escribir una programa que pida la nota de un examen(un número real entre 0 y 10)
            //      e imprima por pantalla la calificación en formato “Reprueba”, si la nota es 
            //      menor que  5, “Aprobado” si esta entre 5 y 7 sin incluirlo, “Notable” si esta 
            //      entre 7 y 9 sin incluirlo,  “Sobresaliente” si esta entre 9 y 10 sin incluirlo
            //      y “Excelente”  si la nota es igual a 10
            //7.- Dado un número entero determine la cantidad de dígitos que tiene.
            //8.- Dado un número entero determine  la suma de sus dígitos.
            //9.- Crea un programa que declare tres variables de tipo entero con valores 
            //      A = 5, B = 3, C = -12 y muestre si se cumplen o no las siguientes condiciones usando
            //      a) A > 3          b) A > C                     c) B != C                                 d) A == 3
            //      e) A* B == 15     f) C / B < A                 g) C / B == -10
            //      h) A + B + C == 5
            //      i) (A + B == 8) && (A - B == 2)
            //      j) (A + B == 8) || (A - B == 6)
            //      o) A > 3 && B > 3 && C < 3
            //10.- Que pida un número del 1 al 5 y diga si es primo o no.
            //11.- Que pida un número del 1 al 7 y diga el día de la semana correspondiente.
            //12.- Que pida un número del 1 al 12 y diga el nombre del mes correspondiente.
            //13.- Que pida 3 números y los muestre en pantalla de menor a mayor en líneas 
            //      distintas.En caso de haber números iguales se pintan en la misma línea.
            //14.- Que pida un número y diga si es positivo o negativo.
            //15.- Que pida 10 números y diga cuál es el mayor y cual el menor.


        }
    }
}
