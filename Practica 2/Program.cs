using System;

namespace Clase7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.escribir un programa, que reciba una edad como entero por parámetro y muestre un mensaje por pantalla si es mayor de edad o no.


            //Console.Write("Ingrese su edad: ");
            //int edad;
            //edad = int.Parse(Console.ReadLine());

            //if (edad >= 18)
            //{
            //    Console.WriteLine("Es mayor de edad ");
            //}
            //else
            //{
            //    Console.WriteLine("Es menor de edad ");
            //}

            //// 2.Escribir un programa, que reciba un entero por parámetro y muestre un mensaje por pantalla que indique si es mayor o menor que 25.

            //Console.Write("Ingrese su edad: ");
            //int edad;
            //edad = Convert.ToInt32(Console.ReadLine());
            //if (edad > 25)
            //{
            //    Console.WriteLine("Usted es mayor de 25 años");
            //}
            //else
            //{
            //    Console.WriteLine("Usted tiene {0} años y es menor de 25 años", edad);
            //}


            ////3.Realiza un programa, que pida el nombre y los apellidos de dos personas y los escriba ordenados alfabéticamente, teniendo en cuenta los dos apellidos, y si fuese necesario, el nombre

            //Console.Write("Ingrese Nombre y Apellido: ");
            //string nombre1;
            //nombre1 = Console.ReadLine();
            //Console.Write("Ingrese Nombre y Apellido: ");
            //string nombre2;
            //nombre2 = Console.ReadLine();

            //string[] nombreApellido = {nombre1, nombre2};
            //int Length = nombreApellido.Length;
            //Array.Sort(nombreApellido);
            //Console.WriteLine("Lista Ordenada:");
            //for (int i = 0; i < Length; i++)
            //{
            //    Console.WriteLine(nombreApellido[i]);
            //}

            //// 4. Escribe un programa, que calcule la cuota que se debe abonar en un club de paddel. La cuota es de 800 euros.Tendrán un 40 % de descuento las personas mayores de 65 años y un 25 % de descuento los menores de 21 años, si los padres no son socios, y un 45 % si los padres son socios

            //int edad;
            //double mensual, descuento, totalAPagar;
            //Console.Write("Por favor, ingrese su edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Por favor, ingrese la couta mensual: ");
            //totalAPagar = Convert.ToInt32(Console.ReadLine());
            //descuento = 0.40 * totalAPagar;

            //if (edad >= 65)
            //{ 
            //    Console.WriteLine("Usted es mayor de 65 años usted debe cancelar: {0}", descuento); 
            //}
            //else if (edad <= 21)
            //{
            //    descuento = 0.25 * totalAPagar;
            //    Console.WriteLine("Usted es menor de 21 y sus padres no son socios socios, el monto que debe cancelar es: {0}", descuento);

            //    descuento = 0.45 * totalAPagar;
            //    Console.WriteLine("Usted es menor de 21 y sus padres son socios, el monto que debe cancelar es: {0}", descuento);
            //}
            //else
            //{
            //    Console.WriteLine("Usted no recibe ningun descuento");
            //}

            ////5. Escribe un programa, que reciba como parámetros tres valores enteros con el día, mes y año de una fecha y devuelva un valor booleano que indique si se trata de valores válidos para una fecha.

            //Console.Write("Ingrese el dia: "); 
            //int dia = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el mes: "); 
            //int mes = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el año: "); 
            //int año = Convert.ToInt32(Console.ReadLine());
            //bool verDia = dia >= 1 && dia <= 31;
            //bool verMes = mes >= 1 && mes <= 12;
            //bool verAño = año >= 1900 && año <= 2070;
            //if (verAño)
            //{
            //    if (verDia && verMes && verAño)
            //        Console.WriteLine("Los valores son validos a una fecha");
            //    else
            //        Console.WriteLine("Los valores ingresados no se identifican con un fecha");
            //}
            //else
            //    Console.WriteLine("El valor ingresado en año debe ser menor a 2070");

            ////6. Escribir una programa que pida la nota de un examen (un número real entre 0 y 10) e imprima por pantalla la calificación en formato “Reprueba”, si la nota es menor que  5, “Aprobado” si esta entre 5 y 7 sin incluirlo, “Notable” si esta entre 7 y 9 sin incluirlo,  “Sobresaliente” si esta entre 9 y 10 sin incluirlo y “Excelente”  si la nota es igual a 10 

            //Console.Write("Ingrese la nota, debe ser en un rango de 0 y 10: ");
            //int ingreseNota = int.Parse(Console.ReadLine());

            //if (ingreseNota < 5)
            //{
            //    Console.Write("Reprobado");
            //}
            //else
            //{
            //    if (ingreseNota >= 5 && ingreseNota <= 7)
            //    {
            //        Console.Write("Notable");
            //    }
            //    else 
            //    { 
            //        Console.Write("Sobrsaliente"); 
            //    }
            //}

            ////7. Dado un número entero determine la cantidad de dígitos que tiene.

            //Console.Write("ingrese un numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int digitos = 0;
            //
            //do
            //{
            //    numero = numero / 10;
            //    digitos = digitos + 1;
            //}
            //while (numero > 0);
            //{
            //     Console.WriteLine("el numero de digitos es: " + digitos);
            //     Console.ReadLine();
            //}

            //// 8. Dado un número entero determine  la suma de sus dígitos.

            //Console.Write("ingrese un numero: ");
            //string numero = Console.ReadLine();
            //int total = 0;

            //foreach (char nuevoNumero in numero)
            //{
            //    total += int.Parse(nuevoNumero.ToString());
            //}
            //Console.WriteLine("La suma de los digitos es: " + total);

            ////9. Crea un programa que declare tres variables de tipo entero con valores A = 5, B = 3, C = -12 y muestre si se cumplen o no las siguientes condiciones usando

            //Console.Write("Ingrese valor A: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese valor B: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese valor C: ");
            //int c = Convert.ToInt32(Console.ReadLine());

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

            ////10. Que pida un número del 1 al 5 y diga si es primo o no.

            //Console.Write("Ingrese un numero entre el 1 y 5: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int divisible = 0;
            //if (numero <= 5)
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
            //else
            //{
            //    Console.WriteLine("El numero ingresado esta fuera de rango");
            //}

            //// 11. Que pida un número del 1 al 7 y diga el día de la semana correspondiente.

            //String[] Dia = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            //Console.Write("Ingrese un numero: ");
            //int diaSemana = Convert.ToInt16(Console.ReadLine());
            //if (diaSemana >= 1 && diaSemana <= 7)
            //{
            //    Console.Write("el dia es: " + Dia[diaSemana - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("No es un dia de la semana");
            //}

            //// 12. Que pida un número del 1 al 12 y diga el nombre del mes correspondiente.

            //String[] mesesAño = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            //Console.Write("Ingrese un numero: ");
            //int mesAño = Convert.ToInt16(Console.ReadLine());
            //if (mesAño >= 1 && mesAño <= 12)
            //{
            //    Console.Write("el mes del año es: " + mesesAño[mesAño - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("No es un dia de la semana");
            //}

            //13. Que pida 3 números y los muestre en pantalla de menor a mayor en líneas distintas. En caso de haber números iguales se pintan en la misma línea.

            //Console.Write("Ingrese el primer numero: "); 
            //int primernumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el segundo numero: "); 
            //int segundonumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el tercer numero: "); 
            //int tercernumero = Convert.ToInt32(Console.ReadLine());
            //if ((primernumero < segundonumero && primernumero < tercernumero) || primernumero == segundonumero || primernumero == tercernumero)
            //{
            //    if (segundonumero < tercernumero)
            //    {
            //        Console.WriteLine("{0}",primernumero);
            //        Console.WriteLine("{0}", segundonumero);
            //        Console.WriteLine("{0}", tercernumero);
            //    }
            //    else if (tercernumero < segundonumero)
            //    {
            //        Console.WriteLine("{0}", primernumero);
            //        Console.WriteLine("{0}", tercernumero);
            //        Console.WriteLine("{0}", segundonumero);
            //    }
            //    else if (primernumero == segundonumero)
            //    {
            //        Console.WriteLine("{0} {1}", primernumero, segundonumero);
            //        Console.WriteLine("{0}", tercernumero);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} {1}", primernumero, tercernumero);
            //        Console.WriteLine("{0}", segundonumero);
            //    }
            //}
            //else if ((segundonumero < primernumero && segundonumero < tercernumero) || segundonumero == tercernumero)
            //{
            //    if (primernumero < tercernumero)
            //    {
            //        Console.WriteLine("{0}", segundonumero);
            //        Console.WriteLine("{0}", primernumero);
            //        Console.WriteLine("{0}", tercernumero);
            //    }
            //    else if (tercernumero < primernumero)
            //    {
            //        Console.WriteLine("{0}", segundonumero);
            //        Console.WriteLine("{0}", tercernumero);
            //        Console.WriteLine("{0}", primernumero);
            //    }
            //    else if (segundonumero == tercernumero)
            //    {
            //        Console.WriteLine("{0} {1}", segundonumero, tercernumero);
            //        Console.WriteLine("{0}", primernumero);
            //    }
            //}
            //else if (tercernumero < primernumero && tercernumero < segundonumero)
            //{
            //    if (primernumero < segundonumero)
            //    {
            //        Console.WriteLine("{0}", tercernumero);
            //        Console.WriteLine("{0}", primernumero);
            //        Console.WriteLine("{0}", segundonumero);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}", tercernumero);
            //        Console.WriteLine("{0}", segundonumero);
            //        Console.WriteLine("{0}", tercernumero);
            //    }
            //}

            //// 14. Que pida un número y diga si es positivo o negativo.

            //Console.Write("Ingrese un numero: "); 
            //int valorNumero = Convert.ToInt32(Console.ReadLine());
            //bool verificarNumero = valorNumero % 1 == 0;
            //if (verificarNumero)
            //{
            //    if (valorNumero < 0)
            //    {
            //        Console.WriteLine("ES NEGATIVO");
            //    }
            //    else if (valorNumero > 0)
            //    {
            //        Console.WriteLine("ES POSITIVO");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("NO ES NUMERO ENTERO");
            //}

            ////15. Que pida 10 números y diga cuál es el mayor y cual el menor.

            // int [] numero = new int [10];
            // int mayor = 0;
            // int menor = 0;
            // int suma = 0;
            // int parte = 0;
            // Console.Clear ();
            // Console.WriteLine ("");
            // para (int i = 0; i <10; i ++)
            // {
            //     Console.Write ("{0} Ingrese un numero: ", i);
            //     numero [i] = int.Parse (Console.ReadLine ());
            // }
            // para (int j = 0; j <10; j ++)
            // {
            //     if (numero [j]> numero [mayor])
            //     {
            //         mayor = j;
            //     }
            // }
            // para (int f = 0; f <10; f ++)
            // {
            //     if (numero [f] <numero [menor])
            //     {
            //         menor = f;
            //     }
            // }
            // Console.WriteLine ("el numero menor es:" + numero [menor]);
            // Console.WriteLine ("el numero mayor es:" + numero [mayor]);

            //// 17. Que muestre un menú que contemple las opciones “Archivo”, “Buscar” y “Salir”, en caso de que no se introduzca una opción correcta se notificará por pantalla.

            //Console.Write("Seleccione una opción: ");
            //int opcion = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1 - Archivo");
            //Console.WriteLine("2 - Buscar");
            //Console.WriteLine("3 - Salir");

            //if (opcion != 1 && opcion != 2 && opcion != 3)
            //{
            //    Console.WriteLine("La opción seleccinada no es correcta");
            //}
            //else
            //{
            //    Console.WriteLine("Entrando a archivo");
            //}

            //// 18. Que pase de metros a otra unidad de medida de longitud, mostrar en pantalla un menú con las opciones posibles.

            //Console.Write("Ingrese la cantidad de metros que desee alcular: ");
            //float metros = float.Parse(Console.ReadLine());
            //float pies = metros / (0.3048f);
            //float pulgadas = metros / (0.0254f);
            //float millas = metros / (1609.344f);
            //Console.WriteLine("La cantidad ingresada en pies es iagual a: {0}", pies);
            //Console.WriteLine("La cantidad ingresada en pulgada es igual a: {0}", pulgadas);
            //Console.WriteLine("La cantidad ingresada en millas es iugal a: {0}", millas);

            ////19. Que lea un importe bruto y calcule su importe neto, si es mayor de 15.000 se le aplicará un 16% de impuestos, en caso contrario se le aplicará un 10%.

            //Console.Write("Ingrese el Sueldo bruto de una persona: ");
            //double importeBruto = double.Parse(Console.ReadLine());
            //double impuestos = importeBruto > 15000 ? importeBruto * 0.16 : importeBruto * 0.1;
            //double importeNeto = importeBruto + impuestos;
            //Console.WriteLine("El valor de importe neto es: " + importeNeto);
            //Console.WriteLine("El valor de impuestos es: " + impuestos);

            //// 20. Que calcule el sueldo que le corresponde al trabajador de una empresa que cobra 40.000 Bolivianos anuales

            //Console.Write("Ingrese los años que lleva trabajando: ");
            //int añosTrabajando = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el monto del sueldo anual que recibe: ");
            //double pagoTotal = Convert.ToInt32(Console.ReadLine());
            //double sueldo = 40000;
            
            //if (añosTrabajando >= 10)
            //{
            //    double aumento = (0.10 * pagoTotal) + sueldo;
            //    Console.WriteLine("Lleva más de 10 años trabajando su sueldo es: {0}", aumento);
            //}
            //else if (añosTrabajando >= 5 && añosTrabajando < 10)
            //{
            //    double aumento = (0.07 * pagoTotal) + sueldo;
            //    Console.WriteLine("Lleva mas de 5 años trabajando sueldo es: {0}", aumento);
            //}
            //else if (añosTrabajando >= 3 && añosTrabajando < 5 )
            //{
            //    double aumento = (0.05 * pagoTotal) + sueldo;
            //    Console.WriteLine("Lleva mas de 3 años trabajando su sueldo es: {0}", aumento);
            //}

            //else
            //{
            //    double aumento = (0.03 * pagoTotal) + sueldo;
            //    Console.WriteLine("Lleva menos de 3 años trabajando su sueldo es: {0}", aumento);
            //}  
            


        }

    }
}
