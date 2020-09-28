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

            //int numero;
            //Console.Write("Por favor, Ingrese un Numero: ");
            //numero = Int32.Parse(Console.ReadLine());

            //if (numero == 0)
            //{
            //    Console.Write("el numero es cero");
            //}
            //else if (numero >= 1)
            //{
            //    Console.Write("el numero " + numero + " es Positivo.");
            //}
            //else if (numero <= -1)
            //{
            //    Console.Write("el numero " + numero + " es Negativo.");
            //}

            //Console.ReadLine();
            //Console.ReadKey();

            //15

            // numero mayor y menor .Ordenar los numeros de mayor a menor.
            //int[] numero = new int[10];
            //int mayor = 0;
            //int menor = 0;
            //int suma = 0;
            //int parte = 0;
            //Console.Clear();
            //Console.WriteLine("");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0} Por favor, ingrese un numero:", i);
            //    numero[i] = int.Parse(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    if (numero[j] > numero[mayor])
            //    {
            //        mayor = j;
            //    }
            //}
            //for (int f = 0; f < 10; f++)
            //{
            //    if (numero[f] < numero[menor])
            //    {
            //        menor = f;
            //    }
            //}
            //Console.WriteLine("el numero menor es: " + numero[menor]);
            //Console.WriteLine("el numero mayor es: " + numero[mayor]);

            //Console.ReadKey();

            //16
            //el 3er num es la suma de los dos 
            //int num1, num2, num3;
            //int suma;
            //Console.Write(" Escriba primer nuemro  \t ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" Escriba segundo nuemro \t ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Escriba tercer numero   \t ");
            //num3 = Convert.ToInt32(Console.ReadLine());


            //if (num1 + num2 == num3)
            //{
            //    Console.WriteLine("El tercer número es la suma de los dos primeros.\n");
            //}
            //else
            //{
            //    Console.WriteLine("El tercer número NO es la suma de los dos primeros.\n");
            //}
            //Console.ReadLine();
            //Console.ReadKey();

            //17

            // opciones “Archivo”, “Buscar” y “Salir”, 
            //int opcion;
            //Console.WriteLine(" Seleccione opción:\n");
            //Console.WriteLine("1 – Archivo\n");
            //Console.WriteLine("2 – Buscar\n");
            //Console.WriteLine("3 – Salir\n");
            //opcion = Convert.ToInt32(Console.ReadLine());
            //if (opcion != 1 && opcion != 2 && opcion != 3)
            //{
            //    Console.WriteLine("La opción NO es correcta.\n");
            //}
            //else
            //{
            //    Console.WriteLine("La opción es correcta.\n");
            //}
            //Console.ReadKey();

            //18

            //Conversion de equivalencias
            //float Metros, pies, pulgadas, millas;
            //Console.Write("Por favor, ingrese Cantidad de Metros a Calcular: ");
            //Metros = float.Parse(Console.ReadLine());

            //pies = Metros / (0.3048f);
            //pulgadas = Metros / (0.0254f);
            //millas = Metros / (1609.344f);
            //Console.WriteLine("La Cantidad de pies es: {0}", pies);
            //Console.WriteLine("La Cantidad de pulgada es: {0}", pulgadas);
            //Console.WriteLine("La Cantidad de millas es: {0}", millas);
            //Console.ReadKey();

            //19
            /*Que lea un importe bruto y calcule su importe neto, si es mayor de 15.000 se le 
            aplicará un 16% de impuestos, en caso contrario se le aplicará un 10%.*/
            //double importe_bruto, importe_neto, impuestos;
            //Console.Write("\n Ingrese el Sueldo bruto de una persona: ");
            //importe_bruto = double.Parse(Console.ReadLine());
            //impuestos = importe_bruto > 15000 ? importe_bruto * 0.16 : importe_bruto * 0.1;
            //importe_neto = importe_bruto + impuestos;
            //Console.WriteLine("Valor de importe neto: " + importe_neto);
            //Console.WriteLine("Valor de impuestos: " + impuestos);
            //Console.WriteLine();
            //Console.ReadKey();

            //20
            // haber  40000 Bs >10años 10%, 5años<x<10años 7%,3años<x<5años 5%, <3años 3%
            double sueldo = 40000;
            double aumento, totalAPagar;
            Console.WriteLine("Por favor, ingrese sueldo anual: ");
            totalAPagar = Convert.ToInt32(Console.ReadLine());
            aumento = (0.10 * totalAPagar) + sueldo;
            Console.WriteLine("Si lleva más de 10 años su sueldo es: {0}", aumento);


            aumento = (0.07 * totalAPagar) + sueldo;
            Console.WriteLine("Si lleva menos de 10 años pero más que 5, su sueldo es: {0}", aumento);

            aumento = (0.05 * totalAPagar) + sueldo;
            Console.WriteLine("Si lleva menos de 5 años pero más que 3, su sueldo es: {0}", aumento);
            aumento = (0.03 * totalAPagar) + sueldo;
            Console.WriteLine("Si lleva menos de 3 años , su sueldo es: {0}", aumento);

            Console.WriteLine();
            Console.ReadKey();





        }
    }
}
