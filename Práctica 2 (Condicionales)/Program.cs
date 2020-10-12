using System;
using System.Text;
namespace Práctica_2__Condicionales_
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------1
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18) Console.WriteLine("Es mayor de edad");
            else Console.WriteLine("No es mayor de edad");
            //-----------------------------------------------2
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 25) Console.WriteLine("Es mayor que 25");
            else Console.WriteLine("No es mayor que 25");
            //-----------------------------------------------3
            string nombre1, nombre2, apellido1="", apellido2="", aux1="", aux2="";
            Console.WriteLine("Introduzca nombres y apellidos de dos personas");
            Console.Write("Introduzca el nombre de la primera persona: "); nombre1 = Console.ReadLine();
            Console.Write("Introduzca los apellidos de la primera persona: "); apellido1 = Console.ReadLine();
            Console.Write("Introduzca el nombre de la segunda persona: "); nombre2 = Console.ReadLine();
            Console.Write("Introduzca los apellidos de la segunda persona: "); apellido2 = Console.ReadLine();
            nombre2 = Console.ReadLine();
            aux1 = apellido1 + " " + nombre1;
            aux2 = apellido2 + " " + nombre2;
            if (String.Compare(aux1,aux2)==-1)
            {
                Console.WriteLine(aux1);
                Console.WriteLine(aux2);
            }
            else
            {
                Console.WriteLine(aux2);
                Console.WriteLine(aux1);
            }
            //-----------------------------------------------4
            string status ="no";
            Console.WriteLine("Ingrese su edad:"); edad = Convert.ToInt32(Console.ReadLine());
            if (edad < 21)
            {
                Console.WriteLine("¿Son socios sus padres?:"); status = Console.ReadLine();
            }
            double nueva_cuota = 800;
            if(edad > 65)
            {
                nueva_cuota = nueva_cuota - (800 * .4);
            }
            else if(edad < 21 && status == "No")
            {
                nueva_cuota = nueva_cuota - (800 * .25);
            }else if(edad <21 && status == "Si")
            {
                nueva_cuota = nueva_cuota - (800 * .45);
            }
            Console.WriteLine(nueva_cuota);
            //-----------------------------------------------5
            int dia, mes, año;
            bool fecha_valida = false;
            dia = Convert.ToInt32(Console.ReadLine());
            mes = Convert.ToInt32(Console.ReadLine());
            año = Convert.ToInt32(Console.ReadLine());
            if(año % 4 == 0)
            {
                if ((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia < 32) fecha_valida = true;
                else if (mes == 2 && dia < 30) fecha_valida = true;
                else if (mes < 13 && dia < 31) fecha_valida = true;
            }
            else
            {
                if((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia < 32) fecha_valida = true;
                else if (mes == 2 && dia < 29) fecha_valida = true;
                else if (mes < 13 && dia < 31) fecha_valida = true;
            }
            if (fecha_valida) Console.WriteLine("Fecha correcta");
            else Console.WriteLine("Fecha Incorrecta");
            //-----------------------------------------------6
            Console.WriteLine("Por favor introduzca una nota entre 0 y 10");
            double nota = Convert.ToDouble(Console.ReadLine());
            if (nota < 5) Console.WriteLine("Reprueba");
            else if (nota < 7) Console.WriteLine("Aprobado");
            else if (nota < 9) Console.WriteLine("Notable");
            else if (nota < 10) Console.WriteLine("Sobresaliente");
            else if (nota == 10) Console.WriteLine("Excelente");
            //-----------------------------------------------7
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Log10(numero));
            //-----------------------------------------------8
            numero = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while(numero > 0)
            {
                suma = suma + (numero % 10);
                numero = numero / 10;
            }
            Console.WriteLine(suma);
            //-----------------------------------------------9
            int A = 5, B = 3, C = -12;
            if (A > 3) Console.WriteLine("Se cumple A > 3"); else Console.WriteLine("No se cumple A > 3");
            if (A > C) Console.WriteLine("Se cumple A > C"); else Console.WriteLine("No se cumple A > C");
            if (B != C) Console.WriteLine("Se cumple B != C"); else Console.WriteLine("No se cumple B != c");
            if (A == 3) Console.WriteLine("Se cumple A == 3"); else Console.WriteLine("No se cumple A == 3");
            if (A * B == 15) Console.WriteLine("Se cumple A * B == 15"); else Console.WriteLine("No se cumple A * B == 15");
            if (C / B < A) Console.WriteLine("Se cumple C / B < A"); else Console.WriteLine("No se cumple C / B < A");
            if (C / B == -10) Console.WriteLine("Se cumple C / B == -10"); else Console.WriteLine("No se cumple C / B == -10");
            if (A + B + C == 5) Console.WriteLine("Se cumple A + B + C == 5"); else Console.WriteLine("No se cumple A + B + C == 5");
            if ((A + B == 8) && (A - B == 2)) Console.WriteLine("Se cumple (A+B == 8) && (A-B == 2) "); else Console.WriteLine("No se cumple (A+B == 8) && (A-B == 2) ");
            if ((A + B == 8) || (A - B == 6)) Console.WriteLine("Se cumple (A+B == 8) || (A-B == 6)"); else Console.WriteLine("No se cumple (A+B == 8) || (A-B == 6)");
            if (A > 3 && B > 3 && C < 3) Console.WriteLine("Se cumple A > 3 && B > 3 && C < 3"); else Console.WriteLine("No se cumple A > 3 && B > 3 && C < 3");
            //-----------------------------------------------10
            Console.WriteLine("Introduzca un número del 1 al 5");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero == 2 || numero == 3 || numero == 5)
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo");
            }
            //-----------------------------------------------11
            Console.WriteLine("Introduzca un número del 1 al 7");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1) Console.WriteLine("Lunes");
            else if (numero == 2) Console.WriteLine("Martes");
            else if (numero == 3) Console.WriteLine("Miercoles");
            else if (numero == 4) Console.WriteLine("Jueves");
            else if (numero == 5) Console.WriteLine("Viernes");
            else if (numero == 6) Console.WriteLine("Sabado");
            else if (numero == 7) Console.WriteLine("Domingo");
            //-----------------------------------------------12
            Console.WriteLine("Introduzca un número del 1 al 12");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1) Console.WriteLine("Enero");
            else if (numero == 2) Console.WriteLine("Febrero");
            else if (numero == 3) Console.WriteLine("Marzo");
            else if (numero == 4) Console.WriteLine("Abril");
            else if (numero == 5) Console.WriteLine("Mayo");
            else if (numero == 6) Console.WriteLine("Junio");
            else if (numero == 7) Console.WriteLine("Julio");
            else if (numero == 3) Console.WriteLine("Agosto");
            else if (numero == 4) Console.WriteLine("Septiembre");
            else if (numero == 5) Console.WriteLine("Octubre");
            else if (numero == 6) Console.WriteLine("Noviembre");
            else if (numero == 7) Console.WriteLine("Diciembre");
            //-----------------------------------------------13
            Console.WriteLine("Introduzca 3 numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int min;
            min = Math.Min(numero1, Math.Min(numero2, numero3));
            if(numero1 == min && numero2 == min && numero3 == min)
            {
                Console.WriteLine("{0}, {1}, {2}", numero1, numero2, numero3);
            }
            else if (numero1 == min && numero2 == min)
            {
                Console.WriteLine("{0}, {1}", numero1, numero2);
                Console.WriteLine("{0}", numero3);
            }
            else if (numero2 == min && numero3 == min)
            {
                Console.WriteLine("{0}, {1}", numero2, numero3);
                Console.WriteLine("{0}", numero1);
            }
            else if (numero1 == min && numero3 == min)
            {
                Console.WriteLine("{0}, {1}", numero1, numero3);
                Console.WriteLine("{0}", numero2);
            }
            else if (numero1 == min)
            {
                Console.WriteLine("{0}", numero1);
                Console.WriteLine("{0}", Math.Min(numero2, numero3));
                Console.WriteLine("{0}", Math.Max(numero2, numero3));
            }
            else if (numero2 == min)
            {
                Console.WriteLine("{0}", numero2);
                Console.WriteLine("{0}", Math.Min(numero1, numero3));
                Console.WriteLine("{0}", Math.Max(numero1, numero3));
            }
            else if (numero3 == min)
            {
                Console.WriteLine("{0}", numero3);
                Console.WriteLine("{0}", Math.Min(numero2, numero1));
                Console.WriteLine("{0}", Math.Max(numero2, numero1));
            }
            //-----------------------------------------------14
            Console.WriteLine("Introduzca un número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 0) Console.WriteLine("El número es postivio");
            else Console.WriteLine("El numero es negativo");
            //-----------------------------------------------15
            Console.WriteLine("Introduzca 10 numeros");
            int max = -100000000 ;min = 10000000;
            for(int i = 0; i < 10; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    max = Math.Max(numero, max);
                    min = Math.Max(numero, min);
                }
            }
            Console.WriteLine("El numero mayor es: {0} y el numero menor es: {1}", max, min);
            //-----------------------------------------------16
            Console.WriteLine("Introduzca tres numeros");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero3 == numero1 + numero2) Console.WriteLine("El tercer numero es igual a la suma del primer numero mas el segundo");
            else Console.WriteLine("El tercer numero no es igual a la suma del primer numero mas el segundo");
            //-----------------------------------------------17
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("->Archivo");
                Console.WriteLine("->Buscar");
                Console.WriteLine("->Salir");
                string menu_elegido = Console.ReadLine();
                if(menu_elegido == "Arichivo" || menu_elegido == "Buscar" || menu_elegido == "Salir")
                {
                    Console.WriteLine("El menu elegido es correcto, puede avanzar");
                    break;
                }
                else
                {
                    Console.WriteLine("El menu elegido es incorrecto, vuele a intentarlo");
                }
            }
            //-----------------------------------------------18
            Console.WriteLine("Introduzca un valor en metros para convertir a otra unidad mostrada abajo");
            Console.WriteLine("->Pulgadas");
            Console.WriteLine("->Centimentros");
            Console.WriteLine("->Kilometros");
            Console.WriteLine("->Millas");
            Console.WriteLine("->Millas nauticas");
            Console.WriteLine("->Pies");
            string medida = Console.ReadLine();
            numero = Convert.ToInt32(Console.ReadLine());
            if (medida == "Pulgadas") Console.WriteLine(numero * 39.37);
            else if (medida == "Centimetros") Console.WriteLine(numero * 100);
            else if (medida == "Kilometros") Console.WriteLine(numero * 0.001);
            else if (medida == "Millas") Console.WriteLine(numero * 0.000621);
            else if (medida == "Millas nauticas") Console.WriteLine(numero * 0.0005);
            else if (medida == "Pies") Console.WriteLine(numero * 3.28084);
            //-----------------------------------------------19
            double importe, impuesto;
            importe = Convert.ToInt32(Console.ReadLine());
            if (importe > 15000) impuesto = importe * 0.16;
            else impuesto = importe * 0.1;
            importe = importe -impuesto;
            //-----------------------------------------------20
            int añosDeAntiguedad = Convert.ToInt32(Console.ReadLine());
            double nuevoSueldo = 40000;
            if(añosDeAntiguedad < 3)
            {
                nuevoSueldo += nuevoSueldo * 0.03;
            }
            else if(añosDeAntiguedad < 5)
            {
                nuevoSueldo += nuevoSueldo * 0.05;
            }
            else if(añosDeAntiguedad < 10)
            {
                nuevoSueldo += nuevoSueldo * 0.07;
            }
            else if(añosDeAntiguedad >= 10)
            {
                nuevoSueldo += nuevoSueldo * 0.1;
            }
            Console.WriteLine("El nuevo sueldo es {0}", nuevoSueldo);
        }
    }
}
