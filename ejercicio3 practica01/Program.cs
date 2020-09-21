using System;

namespace ejercicio3_practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Declare 5 variables numéricas y asígneles un valor.
            //1
            //int entero = -4;
            //Console.WriteLine(entero);
            //Console.WriteLine("el numero entero es: {0}", entero);
            //Console.ReadLine();
            //Console.ReadKey();


            //2
            //uint numero = 36;
            //uint numero2 = 6;
            //uint resultado = numero / numero2;
            //Console.WriteLine("El rsultado de la división es {0}", resultado);
            //Console.ReadLine();
            //Console.ReadKey();

            //3
            //int numero = 25;
            //float numero2 = 5.5f;
            //float resultado = numero / numero2;
            //Console.WriteLine("El resultado de la división es {0}", resultado);
            //Console.ReadLine();
            //Console.ReadKey();

            //4

            //char letra;
            //Console.WriteLine("Por favor, ingrese una letra");
            //letra = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(" la letra que ingreso es {0}", letra);
            //Console.WriteLine();
            //Console.ReadKey();

            //5
            //Console.Write("Por favor, ingrese su nombre: ");
            //string respuesta = Console.ReadLine();
            //string nombre = "amaru";
            //if (respuesta == nombre)
            //    Console.WriteLine("Bienvenido! amaru ");
            //else
            //    Console.WriteLine("No estas en la lista ...");
            //Console.WriteLine();
            //Console.ReadKey();

            //6
            //int numero1 = 2;
            //int numero2 = 8;
            //int suma = 0;
            //suma = numero1 + numero2;

            //    if (suma >= 10)
            //    {
            //        Console.WriteLine("verdad");
            //    }
            //    else
            //    {
            //        Console.WriteLine("falso");
            //    }



            //4.Declare 3 variables de texto e ingrese un valor por teclado.
            //1
            //Console.WriteLine("Por favor, ingrese un texto");
            //String texto;
            //texto = Console.ReadLine();
            //Console.WriteLine("El texto que ingreso es: " + texto);
            //Console.WriteLine();
            //Console.ReadKey();


            //2
            //string nombre;
            //Console.WriteLine("Por favor, escriba su nombre: ");
            //nombre = Console.ReadLine();
            //if (nombre == "amaru")
            //{
            //    Console.WriteLine("adelante puede ingresar");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrecto, vuelva a intentar");
            //}
            //Console.ReadKey();

            //5.Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”.

            //int numero;   //declaramos la variable
            //Console.WriteLine("ingrese un numero: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("El numero que ingreso es: {0}", numero);
            //Console.ReadKey();

            //6.Realice 5 ejemplos de conversión implícita.

            //int numero1 = 12;
            //byte numero2 = 20;
            //numero1 = numero2;
            //Console.WriteLine(numero1);
            //Console.ReadKey();

            //int numero1 = 12345;
            //long numero2 = a;
            //Console.WriteLine(numero1);
            //Console.WriteLine(numero2);
            //Console.ReadKey();


            //int numero1 = 20;
            //short numero2 = 300;
            //numero1 = numero2;
            //Console.WriteLine(numero1);
            //Console.ReadKey();

            //double numero;
            //float num2;
            //long num3;
            //int num4;
            //short num5;
            //byte num6=2;

            //num5 = num6;
            //num4 = num5;
            //num3 = num4;
            //num2 = num3;
            //numero = num2;

            //Console.WriteLine("conversion implicita" + numero);
            //Console.ReadKey();


            //7.Realice 5 ejemplos de conversión explicita.

            //float real1 = (float)2.3456789;
            //double real2 = real1;
            //Console.WriteLine(real1);
            //Console.WriteLine(real2);

            //Console.ReadKey();


            //double decimales = 2341.98;
            //int entero;
            //entero = (int)decimales;
            //Console.WriteLine(entero);
            //Console.ReadKey();


            //short s = 300;
            //byte b = (byte)s;
            //Console.WriteLine(s);
            //Console.ReadKey();

            //string num = "56";
            //int numero;
            //int.TryParse(num, out numero);    
            //Console.WriteLine(numero); 
            //Console.ReadKey();

            //8.Ingrese dos números por teclado y verifique cual es el mayor y cual el menor
            //int num1;
            //int num2;
            //Console.Write("Por Favor, ingrese primer numero: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Por Favor, ingrese segundo numero: ");
            //num2 = int.Parse(Console.ReadLine());

            //if (num1 > num2)

            //    Console.WriteLine(" el numero mayor es:" + num1);

            //else if (num1 == num2)
            //{
            //    Console.WriteLine("son iguales");
            //}
            //else
            //{
            //    Console.WriteLine(" el numero mayor es:" + num2);
            //}
            //Console.ReadKey();

            //Console.ReadKey();


            //9.Ingrese un numero por teclado y verifique si es par.

            //int numero = 0;
            //Console.Write("Ingrese el numero: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //if (numero % 2 == 0)
            //{

            //    Console.WriteLine("El numero {0} es par", numero);
            //}
            //else
            //{
            //    Console.WriteLine("El numero {0} es impar", numero);
            //}

            //Console.ReadKey();


            //10.Ingrese un numero por teclado y verifique si es múltiplo de 3, 5 o 7.

            int numero;
            Console.WriteLine("Por favor, ingrese un numero: Son los multiplos de 3: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
                if (i % 3 == 0)
                {
                    Console.Write("{0}|", i);
                }

            Console.Write("\n\n");
            Console.WriteLine("Son los multiplos de 5: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
                if (i % 5 == 0)
                {
                    Console.Write("{0}|", i);
                }
            Console.Write("\n\n");
            Console.WriteLine("Son los multiplos de 7: ");
            for (int i = 1; i <= numero; i++)
                if (i % 7 == 0)
                {
                    Console.Write("{0}|", i);
                }

            Console.ReadKey();



        }
    }
}
