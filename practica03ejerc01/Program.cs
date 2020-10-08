using System;

namespace practica03ejerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Que pida un numero y diga si es primo
            //int valor1 = 0, numero;
            //Console.Write("Por favor, ingrese un numero: \t ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < (numero + 1); i++)
            //{
            //    if (numero % i == 0)
            //    {
            //        valor1++;
            //    }
            //}
            //if (valor1 != 2)
            //{
            //    Console.WriteLine(numero + " No es primo");
            //}
            //else
            //{
            //    Console.WriteLine(numero + " Si es primo ");
            //}
            //Console.ReadLine();
            //Console.ReadKey();


            //2
            //muestra numeros de 1 a 100
            //Console.WriteLine("se muestra los numeros de 1 a 100");
            //int numero;
            //numero = 1;
            //while (numero <= 100)
            //{
            //    Console.Write(numero);
            //    Console.Write(" - ");
            //    numero = numero + 1;
            //}

            //Console.ReadLine();
            //Console.ReadKey();


            //3
            //muestra numeros de 100 a 1
            //Console.WriteLine("numeros de 100 a 1 decreciente");
            //for (int numeros = 100; numeros >= 1; numeros--)
            //{
            //    Console.Write(numeros);
            //    Console.Write(" - ");
            //}
            //Console.ReadLine();
            //Console.ReadKey();

            //4
            //muestra numeros pares en 100
            //Console.WriteLine("numeros pares de 1 a 100");
            //for (int numero = 2; numero <= 100; numero += 2)
            //{
            //    Console.Write(numero);
            //    Console.Write("-");
            //}

            //Console.ReadLine();
            //Console.ReadKey();

            //5
            //muestra numeros impares

            //Console.Write("Por favor, ingrese un numero para mostrar impares hasta el numero ingresado: \t");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int cantidad = 0;
            //for (int x = 1; x <= numero; x++)
            //{
            //    int y = x % 2;
            //    if (y != 0)
            //    {
            //        cantidad = cantidad + 1;
            //        Console.Write(x);
            //        Console.Write("-");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Total de numeros impares: " + cantidad);

            //Console.ReadKey();

            //6
            // suma de los numeros de 1 a 100
            //int sum = 0;
            //String cad = "";
            //for (int i = 0; i <= 100; i++)
            //{
            //    cad = cad + " + " + i;
            //    sum = sum + i;
            //}
            //Console.WriteLine(cad);

            //Console.WriteLine("la suma total es: " + sum);
            //Console.ReadLine();

            //7

            // suma de los numeros  pares de 1 a 100
            //int suma = 0;
            //String cantidad = "";
            //for (int i = 0; i <= 100; i = i + 2)
            //{
            //    cantidad = cantidad + " " + i;
            //    suma = suma + i;
            //}
            //Console.WriteLine(cantidad);
            //Console.WriteLine(suma);
            //Console.ReadLine();


            //8

            // suma de los numeros  impares de 1 a 100
            //int i;
            //int suma = 0;
            //String cantidad = "";
            //for (i = 1; i < 50; i++)
            //{
            //    cantidad = cantidad + " " + (2 * i - 1); ;
            //    suma = suma + (2 * i - 1); ;
            //}
            //Console.WriteLine(cantidad);
            //Console.WriteLine(suma);
            //Console.ReadLine();


            //9

            // cantidad de números pares de 1 a 100

            //Console.Write("Por favor, ingrese un numero para que muestre hasta el numero ingresado: \t");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int c = 0;
            //for (int x = 2; x <= numero; x += 2)
            //{
            //    c = c + 1;
            //    Console.Write(x);
            //    Console.Write("-");

            //}
            //Console.WriteLine();
            //Console.WriteLine("Total de numeros pares: " + c);
            //Console.ReadKey();

            //10
            //suma de los números impares y la cantidad

            //int numero;
            //int par = 0;
            //int impar = 0;
            //int sumapar = 0;
            //int sumaimpar = 0;
            //int contador = 0;

            //Console.Write("por favor, ingrese un numero:  ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //for (int x = 1; x <= numero; x++)
            //{
            //    int y = x % 2;
            //    if (y != 0)
            //    {
            //        contador = contador + 1;
            //        Console.Write("{0}|", x);
            //        sumapar += x;
            //        impar++;
            //    }

            //}
            //Console.WriteLine("\n\n");
            //Console.WriteLine("la suma de numeros impares es:" + sumapar);
            //Console.WriteLine("total de numeros imapar es:" + contador);
            //Console.ReadLine();


            //11
            // ordenar los numeros forma creciente
            //Console.WriteLine("ingrese tres numeros: ");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int mayor;
            //int menor;
            //int segundoNumero;

            //if (a < b && a < c)
            //{
            //    mayor = a;
            //}
            //else if (b < a && b < c)
            //{
            //    mayor = b;
            //}
            //else
            //{
            //    mayor = c;
            //}

            //if (a > b && a > c)
            //{
            //    menor = a;
            //}
            //else if (b > a && b > c)
            //{
            //    menor = b;
            //}
            //else
            //{
            //    menor = c;
            //}

            //if (a < menor && a > mayor)
            //{
            //    segundoNumero = a;
            //}
            //else if (b < menor && b > mayor)
            //{
            //    segundoNumero = b;
            //}
            //else
            //{
            //    segundoNumero = c;
            //}

            //Console.WriteLine("Los valores ordenados de menor a mayor es: {0} {1} {2}", mayor, segundoNumero, menor);
            //Console.WriteLine();
            //Console.ReadLine();

            //12

            // intervalo entre dos numeros
            //Console.Write("Ingrese el limite inferior: \t ");
            //int numeroInferior = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese el limite superior: \t");
            //int numeroSuperior = int.Parse(Console.ReadLine());
            //Console.Clear();

            //for (int i = numeroInferior; i <= numeroSuperior; i += 2)
            //{
            //    Console.Write(i);
            //    Console.WriteLine(" ");

            //}
            //Console.ReadKey();

            //13

            // intervalo entre dos numeros impares
            //int cont = 0, contimpar = 0;
            //Console.Write("Ingrese el limite inferior: \t ");
            //int numeroInferior = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese el limite superior: \t");
            //int numeroSuperior = int.Parse(Console.ReadLine());
            //Console.Clear();

            //for (int i = numeroInferior + 1; i < numeroSuperior; i += 2)
            //{
            //    Console.Write("{0}|", i);
            //    cont++;
            //    if (i % 2 != 0)
            //        contimpar++;
            //}

            //Console.ReadKey();

            //14 Que pida dos números y sume todos los números 
            //int num1 = 0, num2 = 0;
            //double suma = 0;

            //Console.Write("Ingrese el primer numero:  ");
            //int de = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese el segundo numero:  ");
            //int ha = int.Parse(Console.ReadLine());

            //if (de > ha)
            //{
            //    num1 = de;  
            //    num2 = ha;
            //    de = num2;
            //    ha = num1;
            //}


            //if ((ha - de >= 1) && (ha > 0) && (de > 0))
            //{

            //    for (int i = de; i <= ha; i++)
            //    {

            //        suma = suma + (Math.Pow(i,1));

            //    }

            //    Console.WriteLine("Sumatoria de todo es: " + suma);
            //}
            //else { Console.WriteLine("Deben ser numeros mayores a cero, el rango de A hasta B debe de ser mayor 1"); }

            //Console.ReadKey();

            //15 Que pida dos números y multiplique todos los números 

            //16 Que pida un número y muestre en pantalla el mismo número de asteriscos.
            int i, num;
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < num; i++)
            Console.Write(" * ");
            Console.ReadKey();

        }
    }
    
}