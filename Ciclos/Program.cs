using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (5<2)
            //{
            //    Console.WriteLine();
            //}

            //char letra = Console.ReadLine()[0];
            //switch (letra)
            //{
            //    case 'a':
            //        Console.WriteLine("Es la letra a");
            //        break;
            //    case 'b':
            //        Console.WriteLine("Es la letra b");
            //        break;
            //    case 'c':
            //        Console.WriteLine("Es la letra c");
            //        break;
            //    default:
            //        Console.WriteLine("Es otra letra");
            //        break;
            //}

            // operador ternario   % modular   / entera
            //int numeroPar = Convert.ToInt32(Console.ReadLine());
            //numeroPar = numeroPar % 2 == 0 ? numeroPar : numeroPar + 1;
            //int[] listaNumeros = new int[9];
            //listaNumeros[0] = 25;
            //listaNumeros[listaNumeros.Length - 1] = 135;
            //Console.WriteLine("El tamanio del arreglo es {0}", listaNumeros.Length);
            //Console.WriteLine(listaNumeros[listaNumeros.Length - 1]);
            //int[] listaEnteros2 = new int[] { 1, 13, 8, 5, 7 };
            //int[] listaENteros3 = { 10, 6, 5, 4, 12 };

            /*
             *  c0  c1 c2
             * {{0  0  0}, F0
             * {0  0  0},  F1
             * {0  0  0}}  F2
             */
            //int[,] listaNumerosBid = new int[3, 3];
            //int[,] listaNumerosBid2 = { {5, 10, 8 },
            //                            {11, 1, 18 },
            //                            {5, 101, 32 } };
            //int[] listaMultiArreglos = ;

            //int[][] listaListasNumeros = new int[6][];
            //listaListasNumeros[0] = new int[] { 1,2,3};
            //listaListasNumeros[1] = new int[9];

            //string texto = "Hola Mundo";
            //texto.Length;

            // ciclo while
            //int count = 1;
            //int limite = 100;
            //while (count <= limite)
            //{
            //    Console.WriteLine(count);
            //    count++;// => count = count + 1;
            //}

            //int count = 2;
            //int limite = 100;
            //while (count <= limite)
            //{
            //    Console.WriteLine(count);
            //    count = count + 2;// => count = count + 1;
            //}

            //int count = 1;
            //int limite = 100;
            //while (count <= limite)
            //{
            //    if (count % 2 == 0)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count++;// => count = count + 1;
            //}

            //int count = 1;
            //int limite = 100;
            //while ((count * 2) <= limite)
            //{
            //    Console.WriteLine(count * 2);
            //    count++;// => count = count + 1;
            //}

            //Factoriales F(n) = n * F(n-1) => F(5) = 5 * 4 * 3 * 2 * 1;
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resultado = 1;
            //while (numero >= 1)
            //{
            //    resultado = resultado * numero;
            //    numero--;
            //}
            //Console.WriteLine(resultado);
            // Potencia P(n,e)=n * P(n,e-1)
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int potencia = Convert.ToInt32(Console.ReadLine());
            //int resultado = 1;
            //while (potencia > 0)
            //{
            //    // resultado = resultado * numero;
            //    resultado *= numero;
            //    potencia--;
            //}
            //Console.WriteLine(resultado);

            //int index = 0;
            //int[] listaNumeros = new int[5] { 5, 10, 8, 6, 9};
            //while (index < listaNumeros.Length)
            //{
            //    Console.WriteLine(listaNumeros[index]);
            //    index++;
            //}

            //int fila = 0;
            //int columna = 0;
            //int[,] listaNumeros = { { 5, 10, 8, 21 }, 
            //                        { 3, 11, 26, 25 }, 
            //                        { 6, 7, 13, 11 },
            //                        { 5,19 , 3, 13} };
            //while (fila < 4)
            //{
            //    columna = 0;
            //    while (columna < 4)
            //    {
            //        Console.Write(" "+listaNumeros[fila,columna]);
            //        columna++;
            //    }
            //    Console.WriteLine();
            //    fila++;
            //}

            //int fila = 0, columna = 0;
            //int[,] listaNumeros = { { 5, 10, 8, 21 },     F0
            //                        { 3, 11, 26, 25 },    F1
            //                        { 6, 7, 13, 11 },     F2
            //                        { 5,19 , 3, 13} };    F3
            //                          C0 C1  C2  C3
            //while (fila < 4)
            //{
            //    columna = 0;
            //    while (columna < 4)
            //    {
            //        // mostrar los lados
            //        //if (fila == 0 || fila == 3 || columna == 0 || columna == 3)
            //        //    Console.Write(" " + listaNumeros[fila, columna]);
            //        //else
            //        //    Console.Write("  ");
            //        //string numero = fila == 0 || fila == 3 || columna == 0 || columna == 3 ?
            //        //    " " + listaNumeros[fila, columna] : "  ";
            //        //Console.Write(numero);
            //        //if(fila == columna || fila + columna == 3)
            //        //    Console.Write(" " + listaNumeros[fila, columna]);
            //        //else
            //        //    Console.Write("  ");
            //        //string numero = fila == columna || fila + columna == 3 ?
            //        //    " " + listaNumeros[fila, columna] : "  ";
            //        //Console.Write(numero);
            //        //columna++;
            //    }
            //    Console.WriteLine();
            //    fila++;
            //}

            int altura = Convert.ToInt32(Console.ReadLine());
            int fila = 1, columna = 1;
            while (fila <= altura)
            {
                columna = 1;
                while (columna <= fila)
                {
                    Console.Write("*");
                    columna++;
                }
                Console.WriteLine();
                fila++;
            }

        }
    }
}
