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
            int valorcaracter1 = (int)apellido1[0];
            int valorcaracter2 = (int)apellido2[0];
            Console.WriteLine("LISTA ALFABETICA DE ACUERDO A APELLIDOS");
            if (valorcaracter1 <= valorcaracter2)
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
            int valornombre1 = (int)nombre1[0];
            int valornombre2 = (int)nombre2[0];
            //Console.WriteLine("valor 1 {0} valor 2 {1}",valornombre1, valornombre2);
            Console.WriteLine("LISTA ALFABETICA DE ACUERDO A NOMBRE");
            if ( valornombre1 <= valornombre2)
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
            Console.WriteLine("5.- Escribe un programa, que reciba como parámetros tres valores enteros con el día, mes y año de una fecha y devuelva un valor booleano que indique si se trata de valores válidos para una fecha.");
            Console.Write("Ingrese el dia: ");int ingresodia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el mes: ");int ingresomes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el año (valido valores mayor a 1900 y menor a 2050): ");int ingresoanio = Convert.ToInt32(Console.ReadLine());
            bool controldia = ingresodia >= 1 && ingresodia <= 31;
            bool controlmes = ingresomes >= 1 && ingresomes <= 12;
            bool controlanio = ingresoanio >= 1900 && ingresoanio <= 2050;
            if (controlanio)
            {
                if (controldia && controlmes && controlanio)
                    Console.WriteLine("Los valores son validos a una fecha");
                else
                    Console.WriteLine("Los valores ingresados no se identifican con un fecha");
            }
            else
                Console.WriteLine("El valor de año esta fuera de rango");
            Console.WriteLine("----------------------------------------------------------------");

            //6.- Escribir una programa que pida la nota de un examen(un número real entre 0 y 10)
            //      e imprima por pantalla la calificación en formato “Reprueba”, si la nota es 
            //      menor que  5, “Aprobado” si esta entre 5 y 7 sin incluirlo, “Notable” si esta 
            //      entre 7 y 9 sin incluirlo,  “Sobresaliente” si esta entre 9 y 10 sin incluirlo
            //      y “Excelente”  si la nota es igual a 10
            Console.WriteLine("6.- Escribir una programa que pida la nota de un examen (un número real entre 0 y 10) e imprima por pantalla la calificación en formato “Reprueba”, si la nota es menor que  5, “Aprobado” si esta entre 5 y 7 sin incluirlo, “Notable” si esta entre 7 y 9 sin incluirlo,  “Sobresaliente” si esta entre 9 y 10 sin incluirlo y “Excelente”  si la nota es igual a 10");
            Console.Write("Ingrese la nota de examen, entre 0 y 10:");int numeronota = Convert.ToInt32(Console.ReadLine());
            bool testnota = numeronota >= 0 && numeronota <= 10;
            if (testnota)
            {
                if (numeronota < 5)
                    Console.WriteLine("Reprueba");
                else if (numeronota >= 5 && numeronota < 7)
                    Console.WriteLine("Aprobado");
                else if (numeronota >= 7 && numeronota < 9)
                    Console.WriteLine("Notable");
                else if (numeronota >= 9 && numeronota < 10)
                    Console.WriteLine("Sobresaliente");
                else
                    Console.WriteLine("Excelente");
            }
            else
                Console.WriteLine("La nota esta fuera del parametro indicado");
            Console.WriteLine("----------------------------------------------------------------");
            //7.- Dado un número entero determine la cantidad de dígitos que tiene.
            Console.WriteLine("7.- Dado un número entero determine la cantidad de dígitos que tiene.");
            Console.Write("Ingrese el numero:   ");int cantidaddigito = Convert.ToInt32(Console.ReadLine());
            string digitos = cantidaddigito.ToString();
            Console.WriteLine("El numero {0} tiene {1} digito(s)",cantidaddigito,digitos.Length);
            Console.WriteLine("----------------------------------------------------------------");
            //8.- Dado un número entero determine  la suma de sus dígitos.
            Console.WriteLine("8.- Dado un número entero determine  la suma de sus dígitos.");
            Console.Write("Ingrese el numero:   "); int digito = Convert.ToInt32(Console.ReadLine());
            int digito1 = digito;
            int sumardigitos = 0;
            while (digito != 0)
            {
                sumardigitos = sumardigitos + (digito % 10);
                digito = digito / 10;
            }
            Console.WriteLine("La suma de los digitos del numero {0} es {1}",digito1,sumardigitos);
            Console.WriteLine("----------------------------------------------------------------");
            //9.- Crea un programa que declare tres variables de tipo entero con valores 
            //      A = 5, B = 3, C = -12 y muestre si se cumplen o no las siguientes condiciones usando
            //      a) A > 3          b) A > C                     c) B != C              d) A == 3
            //      e) A* B == 15     f) C / B < A                 g) C / B == -10
            //      h) A + B + C == 5
            //      i) (A + B == 8) && (A - B == 2)
            //      j) (A + B == 8) || (A - B == 6)
            //      o) A > 3 && B > 3 && C < 3
            Console.WriteLine("9.- Crea un programa que declare tres variables de tipo entero con valores A = 5, B = 3, C = -12 y muestre si se cumplen o no las siguientes condiciones usando");
            int valorA = 5; int valorB = 3; int valorC = -12;
            Console.WriteLine("Valor A:  {0}",valorA);
            Console.WriteLine("Valor B:  {0}", valorB);
            Console.WriteLine("Valor C:  {0}", valorC);
            Console.WriteLine("a) A > 3");
            if (valorA > 3) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("b) A > C");
            if (valorA > valorC) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("c) B != C");
            if (valorB != valorC) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("d) A == 3");
            if (valorA == 3) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("e) A* B == 15");
            if((valorA*valorB)==15) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("f) C / B < A");
            if((valorC/valorB)<valorA) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("g) C / B == -10");
            if((valorC/valorB)==-10) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("h) A + B + C == 5");
            if((valorA+valorB+valorC)==5)Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("i) (A + B == 8) && (A - B == 2)");
            if((valorA+valorB)==8&&(valorA-valorB)==2) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("j) (A + B == 8) || (A - B == 6)");
            if((valorA+valorB==8)||(valorA-valorB==6)) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("o) A > 3 && B > 3 && C < 3");
            if(valorA>3&&valorB>3&&valorC<3) Console.WriteLine("Cumple"); else Console.WriteLine("No cumple");
            Console.WriteLine("----------------------------------------------------------------");
            //10.- Que pida un número del 1 al 5 y diga si es primo o no.
            Console.WriteLine("----------------------------------------------------------------");
            //11.- Que pida un número del 1 al 7 y diga el día de la semana correspondiente.
            Console.WriteLine("----------------------------------------------------------------");
            //12.- Que pida un número del 1 al 12 y diga el nombre del mes correspondiente.
            Console.WriteLine("----------------------------------------------------------------");
            //13.- Que pida 3 números y los muestre en pantalla de menor a mayor en líneas 
            //      distintas.En caso de haber números iguales se pintan en la misma línea.
            Console.WriteLine("----------------------------------------------------------------");
            //14.- Que pida un número y diga si es positivo o negativo.
            Console.WriteLine("----------------------------------------------------------------");
            //15.- Que pida 10 números y diga cuál es el mayor y cual el menor.


        }
    }
}
