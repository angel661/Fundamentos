using System;
using System.ComponentModel.DataAnnotations;

namespace Practica_3__ciclos_
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------1
            Console.WriteLine("Introduzca un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool primo = true;
            for(int i = 2; i * i <= numero; i++)
            {
                if (numero % 2 == 0) primo = false;
            }
            if (primo && numero != 0 && numero != 1 ) Console.WriteLine("Es primo");
            else Console.WriteLine("No es primo");
            //-----------------------------------------------2
            for(int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            //-----------------------------------------------3
            for(int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            //-----------------------------------------------4
            for(int index = 1; index < 101; index++)
            {
                if(index % 2 == 0)
                {
                    Console.WriteLine(index);
                }
            }
            //-----------------------------------------------5
            for (int index = 1; index < 101; index++)
            {
                if (index % 2 != 0)
                {
                    Console.WriteLine(index);
                }
            }
            //-----------------------------------------------6
            int suma = 0, sumar = (100*101)/2;
            for(int i = 1; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("{0}, {1}", suma, sumar);
            //-----------------------------------------------7
            suma = 0;
            for(int i = 2; i <= 100; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            //-----------------------------------------------8
            suma = 0;
            for(int i = 1; i <= 100; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            //-----------------------------------------------9
            suma = 0;
            int numeroDePares = 0;
            for(int i = 2; i <= 100; i = i + 2)
            {
                suma = suma + i;
                numeroDePares++;
            }
            Console.WriteLine("La suma es: {0} y hay {1} numeros pares", suma, numeroDePares);
            //-----------------------------------------------10
            suma = 0;
            int numeroDeImpares = 0;
            for (int i = 1; i <= 100; i = i + 2)
            {
                suma = suma + i;
                numeroDeImpares++;
            }
            Console.WriteLine("La suma es: {0} y hay {1} numeros pares", suma, numeroDeImpares);
            //-----------------------------------------------11
            Console.WriteLine("Introduzca dos numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int aux;
            if (numero1 <= numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            else
            {
                for (int i = numero1; i >= numero2; i--)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            //-----------------------------------------------12
            Console.WriteLine("Introduzca dos numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 <= numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    if (i % 2 == 0) Console.WriteLine("{0} ", i);
                }
            }
            else
            {
                for (int i = numero1; i >= numero2; i--)
                {
                    if (i % 2 == 0) Console.WriteLine("{0} ", i);
                }
            }
            //-----------------------------------------------13
            Console.WriteLine("Introduzca dos numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 <= numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    if (i % 2 != 0) Console.WriteLine("{0} ", i);
                }
            }
            else
            {
                for (int i = numero1; i >= numero2; i--)
                {
                    if (i % 2 != 0) Console.WriteLine("{0} ", i);
                }
            }
            //-----------------------------------------------14
            Console.WriteLine("Introduzca dos numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            aux = Math.Max(numero1, numero2);
            numero1 = Math.Min(numero1, numero2);
            numero2 = aux;
            suma = 0;
            for (int i = numero1; i <= numero2; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
            //-----------------------------------------------15
            Console.WriteLine("Introduzca dos numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            aux = Math.Max(numero1, numero2);
            numero1 = Math.Min(numero1, numero2);
            numero2 = aux;
            long multiplicar = 1;
            for (int i = numero1; i <= numero2; i++)
            {
                multiplicar = multiplicar * i;
            }
            Console.WriteLine(multiplicar);
            //-----------------------------------------------16
            Console.WriteLine("Introduzca un numero");
            int numeroDeAsteriscos = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numeroDeAsteriscos; i++)
            {
                Console.WriteLine("*");
            }
            //-----------------------------------------------17
            aux = 1;
            for(int i = 0; i < 10; i++)
            {
                for(int l = 0; l < 10; l++)
                {
                    Console.Write("{0} ",aux);
                    if (aux < 10) Console.Write(" ");
                    aux++;
                }
                Console.WriteLine();
            }
            //-----------------------------------------------18
            for(int i = 0; i <= 10; i++)
            {
                Console.Write("La tabla del {0}: ", i);
                for(int l = 1; l <= 10; l++)
                {
                    Console.Write("{0} ",l * i);
                }
                Console.WriteLine();
            }
            //-----------------------------------------------19
            numero = 20;
            Console.Write("La tabla de multiplicar del numero {0} es: ",numero);
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i * numero);
            }
            Console.WriteLine();
            //-----------------------------------------------20
            while (true)
            {
                Console.WriteLine("Desea Salir (S/N)");
                char entrada = Convert.ToChar(Console.ReadLine());
                if (entrada == 'S') break;
            }
            //-----------------------------------------------21
            long numeroG = 15;
            long limite = numeroG;
            numeroG = 1;
            for(long i = 1; i < limite; i++)
            {
                numeroG *= i;
            }
            Console.WriteLine(numeroG);
            //-----------------------------------------------22
            int[] numeros = { 10, 12, 214, 12421, 124, 12, 5463, 356, 232, 342};
            aux = 0;
            for(int i = 0; i < 10; i++)
            {
                aux += numeros[i];
            }
            double media = aux / 10;
            Console.WriteLine(media);
            //-----------------------------------------------23
            aux = 0; int aux1 = 0;
            numero = Convert.ToInt32(Console.ReadLine());
            while(numero != 0)
            {
                aux = aux + numero;
                aux1++;
                numero = Convert.ToInt32(Console.ReadLine());
            }
            if (aux1 > 0)
            {
                media = aux / aux1;
            }
            else
            {
                media = 0;
            }
            Console.WriteLine(media);
            //-----------------------------------------------24
            suma = 0;
            for(int i = 1; i <= 100; i++)
            {
                suma = suma + (i * i);
            }
            Console.WriteLine(suma);
            //-----------------------------------------------25
            numero1 = 1;
            numero2 = 1;
            for(long i = 0; i < 25; i++)
            {
                Console.Write("{0} ", numero2);
                aux = numero1 + numero2;
                numero2 = numero1;
                numero1 = aux;
            }
        }
    }
}
