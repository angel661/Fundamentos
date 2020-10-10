using System;

namespace PracticaCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.      Que pida un número y diga si es primo o no.
            //Console.WriteLine("ingrese un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //bool primo = true;
            //int cont = 2;
            //if (numero == 1)
            //{
            //    primo = false;
            //}
            //else
            //{
            //    while (primo && cont != numero)
            //    {
            //        if (numero % cont == 0)
            //        {
            //            primo = false;
            //        }
            //        cont++;
            //    }
            //}
            //Console.WriteLine(primo);

            //2.      Que muestre los números del 1 al 100.
            //for (int index = 1; index <= 100; index++)
            //{
            //    Console.WriteLine(index);
            //}

            //3.      Que muestre los números del 100 al 1.
            //for (int index = 100; index >= 1; index--)
            //{
            //    Console.WriteLine(index);
            //}

            //4.      Que muestre los números pares que haya del 1 al 100.
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 == 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //}

            //5.      Que muestre los números impares que haya del 1 al 100.
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 != 0)
            //        Console.WriteLine(index);
            //}

            //6.      Que imprima la suma de todos los números que van del 1 al 100.
            //int suma = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    suma = suma + index;
            //}
            //Console.WriteLine(suma);

            //7.      Que imprima la suma de todos los números pares que van del 1 al 100.
            //int suma = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 == 0)
            //    {
            //        suma = suma + index;
            //    }
            //}
            //Console.WriteLine(suma);

            //8.      Que imprima la suma de todos los números impares que van del 1 al 100.
            //int suma = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 != 0)
            //    {
            //        suma = suma + index;
            //    }
            //}
            //Console.WriteLine(suma);

            //9.      Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.
            //int suma = 0;
            //int cont = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 == 0)
            //    {
            //        suma = suma + index;
            //        cont++;
            //    }
            //}
            //Console.WriteLine(suma+" "+cont);

            //10.  Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.
            //int suma = 0;
            //int cont = 0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    if (index % 2 != 0)
            //    {
            //        suma = suma + index;
            //        cont++;
            //    }
            //}
            //Console.WriteLine(suma+" "+cont);

            //11.  Que pida dos números y muestre todos los números que van desde el primero al segundo.
            //Se debe controlar que los valores son correctos.
            //Console.WriteLine("ingresa dos numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //for (int index = numero1; index <= numero2; index++)
            //{
            //    Console.WriteLine(index);
            //}

            //12.  Que pida dos números y muestre todos los números pares que van desde el primero al segundo.
            //Se debe controlar que los valores son correctos.
            //Console.WriteLine("ingresa dos numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //for (int index = numero1; index <= numero2; index++)
            //{
            //    if (index % 2 == 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //}

            //13.  Que pida dos números y muestre todos los números impares que van desde el primero al segundo.
            //Se debe controlar que los valores son correctos.
            //Console.WriteLine("ingresa dos numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //for (int index = numero1; index <= numero2; index++)
            //{
            //    if (index % 2 != 0)
            //    {
            //        Console.WriteLine(index);
            //    }
            //}

            //14.  Que pida dos números y sume todos los números que van desde el primero al segundo. 
            //Se debe controlar que los valores son correctos.
            //Console.WriteLine("ingrese dos numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int suma = 0;
            //for (int index = numero1; index <= numero2 ; index++)
            //{
            //    suma = suma + index;
            //}
            //Console.WriteLine(suma);

            //15.  Que pida dos números y multiplique todos los números que van desde el primero al segundo. 
            //Se debe controlar que los valores son correctos.
            //Console.WriteLine("ingrese dos numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int multi = 1;
            //for (int index = numero1; index <= numero2; index++)
            //{
            //    multi = multi * index;
            //}
            //Console.WriteLine(multi);

            //16.Que pida un número y muestre en pantalla el mismo número de asteriscos.
            //Console.WriteLine("ingrese un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //for (int index = 0; index < numero; index++)
            //{
            //    Console.Write("*");
            //}

            //17.  Que muestre los números del 1 al 100 en una tabla de 10x10.
            //for (int index = 1; index <= 100; index++)
            //{
            //    Console.Write(index+"\t");
            //    if (index%10==0)
            //    {
            //         Console.WriteLine();
            //    }
            //}

            //18.  Que escriba las tablas de multiplicar del 0 al 10.
            //for (int index = 0; index <= 10; index++)
            //{
            //    for (int index1 = 1; index1 <= 10; index1++)
            //    {
            //        int multi ;
            //        multi = index * index1;
            //        Console.WriteLine(index + " x " + index1 + " = "+multi);
            //    }
            //}

            //19.  Que muestre la tabla de multiplicar de un número cualquiera.
            //Console.WriteLine("ingrese cualquier numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resultado;
            //for (int index = 1; index <= 10; index++)
            //{
            //    resultado = numero * index;
            //    Console.WriteLine(numero + " x " + index + " = " + resultado);
            //}

            //20.  Que haga un menú del tipo “desea salir (S/N)” y 
            //el programa no termine hasta que el usuario teclee “S”.
            //bool sw = true;
            //while (sw)
            //{
            //    Console.WriteLine("****MENU****");
            //    Console.WriteLine("DESEA SALIR S /N ");

            //    char salir = Convert.ToChar(Console.ReadLine());
            //    switch (salir)
            //    {
            //        case 'S':
            //            sw = false;
            //            break;
            //        case 'N':
            //            break;
            //        default:
            //            break;
            //    }
            //}

            //21.  Que calcule el factorial de un número cualquiera y lo muestre en pantalla.
            //Console.WriteLine("ingrese un numero ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //for (int index = 1; index <= numero; index++)
            //{
            //    factorial = factorial * index;
            //}
            //Console.WriteLine(factorial);

            //22.  Que calcule la media de 10 números.
            //int[] vec = new int[10];
            //for (int index1 = 0; index1 < vec.Length; index1++)
            //{
            //    vec[index1] = Convert.ToInt32(Console.ReadLine());
            //}
            //int suma = 0;
            //double media;
            //int index;
            //for (index = 0; index < vec.Length; index++)
            //{
            //    suma = suma + vec[index];

            //}
            //media = (double)suma / index;
            //Console.WriteLine("la media es "+media);

            //23.  Que calcule la media de X números, se dejarán de solicitar números hasta
            //que se introduzca el cero.
            //int[] vec = new int[10000];
            //int cont = 0;
            //for (int index1 = 0; index1 < vec.Length; index1++)
            //{
            //    vec[index1] = Convert.ToInt32(Console.ReadLine());

            //    if (vec[index1] == 0)
            //    {
            //        break;
            //    }
            //    cont++;
            //}
            //int suma = 0;
            //double media;
            //int index;
            //for (index = 0; index < cont; index++)
            //{
            //    suma = suma + vec[index];
            //}
            //media = (double)suma / cont;
            //Console.WriteLine("la media es " + media);

            //24.  Que calcule la suma de los cuadrados de los 100 primeros números.
            //int multi;
            //int suma=0;
            //for (int index = 1; index <= 100; index++)
            //{
            //    multi = index * index;
            //    suma = suma + multi;
            //}
            //Console.WriteLine("la suma de los caudrados es " + suma);

            //25.  Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.
            int aux = 1;
            int inicio = 0;
            int[] vec = new int[25];
            vec[0] = aux;
            Console.WriteLine(vec[0]);
            for (int index = 1; index < vec.Length; index++)
            {
                
                vec[index] = inicio + aux;
                Console.WriteLine(vec[index]);
                inicio = aux;
                aux = vec[index];
            }

        }

    }
}
