using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EJERCICIO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 01");
            Console.WriteLine("1 .- Declare 5 cinco variables primitivas numéricas");
            
            int numero;
            double decimal1;
            long numeromayor;
            float decima2;
            byte ip;
            Console.WriteLine("");

            Console.WriteLine("2 .- Declare 3 variables primitivas de tipo texto");

            char caracter;
            string cadena;
            bool falsoverdadero;
            Console.WriteLine("");

            Console.WriteLine("3 .- Declare 5 variables numéricas y asígneles un valor");

            int cantidad = 100;
            double decimal3 = 0.54321;
            long cantidadmayor = 50000000;
            float decimal4 = 10;
            byte ip1 = 255;
            Console.WriteLine("");

            Console.WriteLine("4.- Declare 3 variables de texto e ingrese un valor por teclado");
            
            Console.WriteLine("-4.1- Ingrese un candena: ");
            string cadena1 = Console.ReadLine();

            char letra;
            Console.WriteLine("-4.2- Introduce una letra:");
            letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("El caracter es:{0}", letra);

            bool vocal, numero1;
            numero1 = (letra >= '0') && (letra <= '9');
            vocal = (letra == 'a') || (letra == 'e') || (letra == 'i') ||
           (letra == 'o') || (letra == 'u');
            Console.WriteLine("-4.3- Resultado es con respecto al 4.2:");
            if (numero1)
                Console.WriteLine("Es un numero.");
            else if (vocal)
                Console.WriteLine("Es una vocal.");
            else
                Console.WriteLine("Es una consonante u otro caracter.");
            Console.WriteLine("");

            Console.WriteLine("5.- Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”");
            string textonumeroingresado = "El número que ingreso es: {0} ";
            Console.WriteLine("Ingrese un numero:");
            int numeroingresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(textonumeroingresado, numeroingresado);
            Console.WriteLine("");

            Console.WriteLine("6.- Realice 5 ejemplos de conversión implícita");
            int num = 123456789;
            long numerogrande = num;
            
            float decimal11 = 14;
            double decimalfloat = decimal11;

            char caracter13 = '4';
            int numerocaracter = caracter13;

            byte numip = 240;
            long numbyte = numip;

            short pequenio = 2;
            long implicitopequenio = pequenio;
            Console.WriteLine("");

            Console.WriteLine("7.- Realice 5 ejemplos de conversión explicita");
            long centeno = 341;
            int convcenteno = (int)centeno;

            short numshort = 180;
            byte convnumshort = (byte)numshort;

            int numerodouble = 10;
            double convnumerodouble = (double)numerodouble;

            double decimal30 = 567.23;
            int convdecimal30 = (int)decimal30;

            string numerofijo = "12345";
            int convnumerofijo = Convert.ToInt32(numerofijo);
            Console.WriteLine("");

            Console.WriteLine("8.- Ingrese dos números por teclado y verifique cual es el mayor y cual el menor");
            Console.WriteLine("Ingrese el primer numero: ");
            int primernumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int segundonumero = Convert.ToInt32(Console.ReadLine());
            if (primernumero > segundonumero)
            {
                Console.WriteLine("El primer numero {0} es mayor que el segundo numero {1}", primernumero, segundonumero);
            }
            else if (segundonumero > primernumero)
            {
                Console.WriteLine("El segundo numero {0} es mayor que el primer numero {1}", segundonumero, primernumero);
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }
            Console.WriteLine("");

            Console.WriteLine("9.- Ingrese un numero por teclado y verifique si es par");
            Console.WriteLine("Ingrese un numero: ");
            int numeropar = Convert.ToInt32(Console.ReadLine());

            if (numeropar % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.WriteLine("");

            Console.WriteLine("10.- Ingrese un numero por teclado y verifique si es múltiplo de 3, 5 o 7");
            Console.WriteLine("Ingrese un numero: ");
            int numeromulti357 = Convert.ToInt32(Console.ReadLine());
            if (numeromulti357 % 3 == 0 || numeromulti357 % 5 == 0 || numeromulti357 % 7 == 0)
            {
                if (numeromulti357 % 3 == 0)
                    Console.WriteLine("El numero {0} es multiplo de 3", numeromulti357);
                else if (numeromulti357 % 5 == 0)
                    Console.WriteLine("El numero {0} es multiplo de 5", numeromulti357);
                else
                    Console.WriteLine("El numero {0} es multiplo de 7", numeromulti357);
            }
            else
                Console.WriteLine("El numero {0} no es multiplo de 3, 5 y 7",numeromulti357);


        }
    }
}
