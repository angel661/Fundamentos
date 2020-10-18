using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.      Que pida un número y diga si es primo o no.
            //Console.Write("Introduzca un numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //bool primo = true;
            //for (int i = 2; i * i <= numero; i++)
            //{
            //    if (numero % 2 == 0)
            //    {
            //        primo = false;
            //    }
            //}
            //if (primo && numero != 0 && numero != 1)
            //{
            //    Console.WriteLine("Es primo");
            //}
            //else
            //{
            //    Console.WriteLine("No es primo");
            //}

            //// 2.Que muestre los números del 1 al 100.

            //for (int i = 1; i < 101; i++)
            //{
            //    Console.Write(i + " ");
            //}

            ////3.Que muestre los números del 100 al 1.

            //for (int i = 100; i > 0; i--)
            //{
            //    Console.Write(i + " ");
            //}

            //// 4.      Que muestre los números pares que haya del 1 al 100.

            //for (int numero = 2; numero <= 100; numero += 2)
            //{
            //    Console.Write(numero + " ");
            //}

            //// 5.      Que muestre los números impares que haya del 1 al 100.

            //for (int numero = 1; numero < 101; numero++)
            //{
            //    if (numero % 2 != 0)
            //    {
            //        Console.Write(numero + " ");
            //    }
            //}

            //// 6.      Que imprima la suma de todos los números que van del 1 al 100.

            //int suma = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    suma = suma + i;
            //}
            //Console.WriteLine("La suma de numeros del 1 al 100 es: " + suma);

            //// 7.      Que imprima la suma de todos los números pares que van del 1 al 100.

            //int suma = 0;
            //for (int i = 0; i <= 100; i = i + 2)
            //{
            //    suma = suma + i;
            //}
            //Console.WriteLine("La suma de numeros pares del 1 al 100 es: " + suma);

            ////8.      Que imprima la suma de todos los números impares que van del 1 al 100.

            //int i;
            //int suma = 0;
            //for (i = 1; i <= 100; i = i + 2)
            //{
            //    suma = suma + i;
            //}
            //Console.WriteLine("la suma de numeros impares del 1 al 100 es: " + suma);

            //// 9.      Que imprima la suma de todos los números pares que van del 1 al 100 y diga cuántos hay.

            //int suma = 0;
            //int numeroDePares = 0;
            //for (int i = 2; i <= 100; i = i + 2)
            //{
            //    suma = suma + i;
            //    numeroDePares++;
            //}
            //Console.WriteLine("La suma total es: {0} y existen {1} numeros pares", suma, numeroDePares);

            //// 10.  Que imprima la suma de todos los números impares que van del 1 al 100 y diga cuántos hay.

            //int suma = 0;
            //int numeroDeImpares = 0;
            //for (int i = 1; i <= 100; i = i + 2)
            //{
            //    suma = suma + i;
            //    numeroDeImpares++;
            //}
            //Console.WriteLine("La suma total es: {0} y existen {1} numeros impares", suma, numeroDeImpares);

            ////11.  Que pida dos números y muestre todos los números que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //Console.Write("Introduzca un numero: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduzca un numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int aux;
            //if (numero1 <= numero2)
            //{
            //    for (int i = numero1; i <= numero2; i++)
            //    {
            //        Console.WriteLine("{0}", i);
            //    }
            //}
            //else
            //{
            //    for (int i = numero1; i >= numero2; i--)
            //    {
            //        Console.WriteLine("{0}", i);
            //    }
            //}

            ////12.  Que pida dos números y muestre todos los números pares que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //Console.Write("Introduzca un numero: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduzca un numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //if (numero1 <= numero2)
            //{
            //    for (int i = numero1; i <= numero2; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("{0}", i);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = numero1; i >= numero2; i--)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine("{0} ", i);
            //        }
            //    }
            //}

            //// 13.  Que pida dos números y muestre todos los números impares que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //Console.Write(" Ingrese el primer numero: "); 
            //int primerNumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" Ingrese el segundo número: "); 
            //int segundoNumero = Convert.ToInt32(Console.ReadLine());
            //if(primerNumero < segundoNumero)
            //{
            //    for(int i = primerNumero ; i <= segundoNumero; i++ )
            //    {
            //        if(i % 2 != 0)
            //        {
            //            Console.WriteLine("{0}", i);
            //        }


            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El segundo numero ingresado debe ser mayor que el primero");
            //}

            ////14.  Que pida dos números y sume todos los números que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //Console.Write("Ingrese el primer numero: "); 
            //int primerNumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write(" Ingrese el segundo número: ");
            //int segundoNumero = Convert.ToInt32(Console.ReadLine());
            //if(primerNumero < segundoNumero)
            //{
            //    int suma = 0;
            //    for(int i = primerNumero ; i <= segundoNumero; i++ )
            //    {
            //        suma = suma + i;
            //    }
            //    Console.WriteLine("La suma de los números que van del primero al segundo es: " + suma);
            //}
            //else
            //{
            //    Console.WriteLine("El segundo numero ingresado debe ser mayor que el primero");
            //}

            //// 15.  Que pida dos números y multiplique todos los números que van desde el primero al segundo. Se debe controlar que los valores son correctos.

            //Console.Write("Ingrese el primer numero: "); 
            //int primerNumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingrese el segundo número: "); 
            //int segundoNumero = Convert.ToInt32(Console.ReadLine());
            //if(primerNumero < segundoNumero)
            //{
            //    int producto = 1;
            //    for(int i = primerNumero; i <= segundoNumero; i++ )
            //    {
            //        producto = producto * i;
            //    }
            //    Console.WriteLine("La multiplicación de los números que van del primero al segundo es: " + producto);
            //}
            //else
            //{
            //    Console.WriteLine("El segundo numero ingresado debe ser mayor que el primero");
            //}

            ////16.  Que pida un número y muestre en pantalla el mismo número de asteriscos.

            //int i;
            //Console.Write("Ingrese un numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < numero; i++)
            //{
            //    Console.Write(" * ");
            //}

            //// 17.  Que muestre los números del 1 al 100 en una tabla de 10x10.

            //int aux = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int l = 0; l < 10; l++)
            //    {
            //        Console.Write("{0} ", aux);
            //        if (aux < 10) Console.Write(" ");
            //        aux++;
            //    }
            //    Console.WriteLine();
            //}

            ////18.  Que escriba las tablas de multiplicar del 0 al 10.

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("La tabla de multiplicar del {0} es: ", i);
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0} ", j * i);
            //    }
            //    Console.WriteLine();
            //}

            ////19.  Que muestre la tabla de multiplicar de un número cualquiera.

            //Console.Write("Ingrese un numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.Write("La tabla de multiplicar del numero {0} es: ", numero);
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} ", i * numero);
            //}

            // 20.  Que haga un menú del tipo “desea salir (S/N)” y el programa no termine hasta que el usuario teclee “S”.

            //// 21.  Que calcule el factorial de un número cualquiera y lo muestre en pantalla.

            //Console.Write(" Ingrese un numero: "); 
            //int numFactorial = Convert.ToInt32(Console.ReadLine());
            //int aux = 1;
            //for(int i = 1 ; i <= numFactorial; i++ )
            //{
            //    aux = aux * i;
            //} 
            //Console.WriteLine(" El número factorial es: " + aux);

            ////22.  Que calcule la media de 10 números.

            //int cont = 0; 
            //int aux = 0;
            //double div = 0;
            //while (cont <= 10)
            //{
            //    aux = (aux + cont);

            //    cont++;
            //}
            //div = aux / 10;
            //Console.WriteLine("La media de 10 es {0}.", div);

            //23.  Que calcule la media de X números, se dejarán de solicitar números hasta que se introduzca el cero.

            ////24.  Que calcule la suma de los cuadrados de los 100 primeros números.

            //int cuadrado;
            //int sumaCuadrado = 0;

            //for(int  i = 0 ; i <= 100; i++ )
            //{
            //    cuadrado = i * i;
            //    sumaCuadrado = sumaCuadrado + cuadrado;
            //}
            //Console.WriteLine("La suma de los cuadrados de los 100 primeros numeros es: " + sumaCuadrado);

            ////25.  Que escriba los primeros 25 dígitos de la sucesión de Fibonacci.

            //int aux;
            //int primerNumero = 0;
            //int segundoNumero = 1;
            
            //for(int  i = 0 ; i < 25; i++ )
            //{
            //    Console.Write(primerNumero + ",");
            //    aux = primerNumero;
            //    primerNumero = segundoNumero;
            //    segundoNumero = aux + primerNumero;
            //}





        }
    }
}
