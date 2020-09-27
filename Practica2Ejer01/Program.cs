using System;

namespace Practica2Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Escribir un programa, que reciba una edad como entero por parámetro y muestre un mensaje por pantalla si es mayor de edad o no.

            //int edad;
            //Console.WriteLine("Por favor, Ingrese su edad: ");
            //edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("Ud; es mayor de edad ");
            //}
            //else
            //{
            //    Console.WriteLine("es menor de edad ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();


            // 2.Escribir un programa, que reciba un entero por parámetro y muestre un mensaje por pantalla que indique si es mayor o menor que 25.


            //int edad;
            //Console.WriteLine("Por favor, ingrese su edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());
            //if (edad > 25)
            //{
            //    Console.WriteLine("Ud es, Mayor a 25");
            //}
            //else
            //{
            //    Console.WriteLine("Ud. tiene {0} por tanto es, Menor a 25", edad);
            //}
            //Console.WriteLine();
            //Console.ReadKey();



            /*3.Realiza un programa, que pida el nombre y los apellidos
                de dos personas y los escriba ordenados alfabéticamente, 
               teniendo en cuenta los dos apellidos, y si fuese necesario, el nombre */

            //string nombre1;
            //string nombre2;
            //Console.Write("Ingrese nombre y apellido:");
            //nombre1 = Console.ReadLine();
            //Console.Write("Ingrese nombre y apellido:");
            //nombre2 = Console.ReadLine();

            //string[] nombres = { nombre1, nombre2 };
            //int length = nombres.Length;
            //Array.Sort(nombres);
            //Console.WriteLine("Array ordenado:\n");
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine(nombres[i]);
            //}

            //Console.WriteLine();
            //Console.ReadKey();

            //4

            // cuota 800 con decuentos 40, 25, 45
            //double mensual;
            //double descuento, totalAPagar;
            //Console.WriteLine("Por favor, ingrese la couta mensual");
            //totalAPagar = Convert.ToInt32(Console.ReadLine());
            //descuento = 0.40 * totalAPagar;
            //Console.WriteLine("ud como es mayor a 65; debe cancelar  : {0}", descuento);


            //descuento = 0.25 * totalAPagar;
            //Console.WriteLine("ud  < 21 y PPFF no socios; debe cancelar : {0}", descuento);

            //descuento = 0.45 * totalAPagar;
            //Console.WriteLine("ud < 21 y PPFF son socios; debe cancelar : {0}", descuento);

            //Console.WriteLine();
            //Console.ReadKey();

            //5

            //DateTime fecha = new DateTime(2020, 09, 23);
            //DateTime fechaConHora = new DateTime(2020, 09, 23, 21, 30, 45);
            //Console.WriteLine(fecha.ToString());
            //Console.WriteLine(fecha.ToString("dd/mm/yyy "));
            //Console.WriteLine(fechaConHora.ToString("dd/mm/yyy/ hh:mm:ss "));
            //Console.ReadKey();

            //6
            // notas con reprodabo, notable y sobresalente
            //int nota;
            //Console.Write("Po favor, Ingrese la nota:");
            //nota = int.Parse(Console.ReadLine());

            //if (nota < 5)
            //{
            //    Console.Write("Reprobado");
            //}
            //else
            //{
            //    if (nota >= 5 && nota <= 7)
            //    {
            //        Console.Write("Notable");
            //    }
            //    else { Console.Write("Sobrsaliente"); }
            //}

            //Console.ReadKey();

            //7
            // dado z cantidad de digitos
            //int numero, digitos = 0;
            //Console.Write("ingrese unvalor numerico:  ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //if (numero <= 0)
            //{
            //    Console.Write("ingrese unvalor numerico: ");
            //}
            //else
            //{
            //    do
            //    {
            //        numero = numero / 10;
            //        digitos = digitos + 1;
            //    }
            //    while (numero > 0);
            //    {
            //        Console.WriteLine("la cantidad de digitos es: " + digitos);
            //        Console.ReadLine();
            //    }
            //}

            //Console.ReadKey();


            //8

            // suma de digitos

            //Console.Write("ingrese un numero: ");
            //string numero = Console.ReadLine();

            //int total = 0;
            //foreach (char numero2 in numero)
            //{
            //    total += int.Parse(numero2.ToString());
            //}
            //Console.WriteLine($"la suma los digitos de {numero}  es: {total}");
            //Console.ReadKey();

            //9

            // >, < =
            //int a;
            //int b;
            //int c;
            //Console.Write("Dar valor A:  ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Dar valor B:  ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Dar valor C:  ");
            //c = Convert.ToInt32(Console.ReadLine());

            //if (a < b)
            //{
            //    if (b < c)
            //    {
            //        Console.WriteLine("{0} es mayor", c);
            //    }
            //    else
            //        Console.WriteLine("{0} es mayor", b);
            //}
            //else if (a > b)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine("{0} es mayor", c);
            //    }
            //    else
            //        Console.WriteLine("{0} es mayor", a);
            //}
            //Console.ReadKey();

            //10
            // numeros primos <= a 5

            //int numero = 2;
            //int divisible = 0;
            //while (numero <= 5)
            //{
            //    for (int i = 1; i <= numero; i++)
            //    {

            //        if (numero % i == 0)
            //        {
            //            divisible++;
            //        }
            //        if (divisible > 2)
            //        {
            //            break;
            //        }
            //    }
            //    if (divisible == 2)
            //    {
            //        Console.WriteLine("el numero {0} es primo", numero);
            //    }
            //    divisible = 0;
            //    numero++;
            //}
            //Console.ReadLine();
            //Console.ReadKey();

            //11

            // dias de la semana igrese el numero

            //String[] Dia = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            //Console.Write("Por favor, Ingresa un numero:  ");
            //int i = Convert.ToInt16(Console.ReadLine());
            //if (i >= 1 && i <= 7)
            //{
            //    Console.Write("el dia " + i + " es un dia que corresponde a: " + Dia[i - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("No es un dia de la semana");
            //}

            //Console.ReadLine();
            //Console.ReadKey();

            //12
            // meses del año igrese el numero

            //String[] mes = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            //Console.Write("Por favor, Ingresa un numero:  ");
            //int i = Convert.ToInt16(Console.ReadLine());
            //if (i >= 1 && i <= 12)
            //{
            //    Console.WriteLine("el numero " + i + "  corresponde a: " + mes[i - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("No es un dia de la semana");
            //}

            //Console.ReadLine();
            //Console.ReadKey();


            //14
            // positivo negativo o cero

            int numero;
            Console.Write("Por favor, Ingrese un Numero: ");
            numero = Int32.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.Write("el numero es cero");
            }
            else if (numero >= 1)
            {
                Console.Write("el numero " + numero + " es Positivo.");
            }
            else if (numero <= -1)
            {
                Console.Write("el numero " + numero + " es Negativo.");
            }

            Console.ReadLine();
            Console.ReadKey();



        }
    }
}
