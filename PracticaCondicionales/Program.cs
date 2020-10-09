using System;
using System.Security.Cryptography.X509Certificates;

namespace PracticaCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Escribir un programa, que reciba una edad como entero por 
            //parámetro y muestre un mensaje por pantalla si es mayor de edad o no.
            //Console.WriteLine("Ingrese edad");
            //int edad = Convert.ToInt32(Console.ReadLine());
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Es mayor de edad\t" + edad);
            //}
            //else
            //{
            //    Console.WriteLine("es menor de edad\t" + edad);
            //}

            //2 .- Escribir un programa, que reciba un entero por parámetro y muestre 
            //un mensaje por pantalla que indique si es mayor o menor que 25.
            //Console.WriteLine("Ingrese numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //if (numero < 25)
            //    Console.WriteLine("el numero 25 es mayor a \t" + numero);
            //else
            //    Console.WriteLine("el numero 25 es menor a \t" + numero);

            //3.- Realiza un programa, que pida el nombre y los apellidos de dos personas y los escriba
            //ordenados alfabéticamente, teniendo en cuenta los dos apellidos, y si fuese necesario, el nombre
            //Console.WriteLine("ingrese los nombres completos de dos personas");
            //Console.WriteLine("nombre de la primera persona");
            //string nombre1 = Console.ReadLine();
            //Console.WriteLine("Apellidos de la primera persona");
            //string apellido1 = Console.ReadLine();
            //Console.WriteLine("nombre de la primera persona");
            //string nombre2 = Console.ReadLine();
            //Console.WriteLine("Apellidos de la primera persona");
            //string apellido2 = Console.ReadLine();
            //int aux = (int)apellido1[0];
            //int aux1 = (int)apellido2[0];
            //int aux2 = (int)nombre1[0];
            //int aux3 = (int)nombre2[0];
            //bool entrada = true;
            //while (entrada)
            //{
            //    Console.WriteLine("Ordenar alfabeticamente por");
            //    Console.WriteLine("1. nombre");
            //    Console.WriteLine("2. apellido");
            //    Console.WriteLine("3. salir");
            //    int sw = Convert.ToInt32(Console.ReadLine());

            //    switch (sw)
            //    {
            //        case 1:
            //            if (aux2 < aux3)
            //            {
            //                Console.WriteLine(nombre1 + "  " + apellido1);
            //                Console.WriteLine(nombre2 + " " + apellido2);
            //            }
            //            else
            //            {
            //                Console.WriteLine(nombre2 + " " + apellido2);
            //                Console.WriteLine(nombre1 + "  " + apellido1);
            //            }
            //            break;

            //        case 2:
            //            if (aux < aux1)
            //            {
            //                Console.WriteLine(apellido1 + "  " + nombre1);
            //                Console.WriteLine(apellido2 + " " + nombre2);
            //            }
            //            else
            //            {
            //                Console.WriteLine(apellido2 + " " + nombre2);
            //                Console.WriteLine(apellido1 + "  " + nombre1);
            //            }
            //            break;
            //        case 3:
            //            entrada = false;
            //            break;

            //        default:
            //            break;

            //    }
            //}

            //4.- Escribe un programa, que calcule la cuota que se debe abonar en un club de paddel. 
            //La cuota es de 800 euros. Tendrán un 40% de descuento las personas mayores de 65 años y 
            //un 25% de descuento los menores de 21 años, si los padres no son socios, y un 45% si los padres son socios

            //Console.WriteLine("ingrese su edad");
            //int edad = Convert.ToInt32(Console.ReadLine());
            //string socio;
            //int cuota = 800;
            //if(edad<65 && edad > 21)
            //{
            //    Console.WriteLine("no hay descuento pagara " + cuota);
            //}
            //else
            //{
            //    if (edad >= 65)
            //    {
            //        cuota = cuota - (cuota * 40 / 100);
            //        Console.WriteLine("tendra un descuento de 40% pagara " + cuota);
            //    }
            //    else
            //    {
            //        if (edad <= 21)
            //        {
            //            Console.WriteLine("tus padres son socios  si/no");
            //            socio = Console.ReadLine();
            //            if (socio.Equals("si"))
            //            {
            //                cuota = cuota - (cuota * 45 / 100);
            //                Console.WriteLine("tendra un descuento de 45% pagara " + cuota);
            //            }

            //            else
            //            {
            //                if (socio.Equals("no"))
            //                {
            //                    cuota = cuota - (cuota * 25 / 100);
            //                    Console.WriteLine("tendra un descuento de 25% pagara " + cuota);
            //                }
            //            }
            //        }

            //    }
            //}

            //5.- Escribe un programa, que reciba como parámetros tres valores enteros con el día,
            //mes y año de una fecha y devuelva un valor booleano que indique si se trata de valores 
            //válidos para una fecha.
            //Console.WriteLine("ingrese dia");
            //int dia = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese mes");
            //int mes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese año");
            //int año = Convert.ToInt32(Console.ReadLine());
            //bool valido = FechaValido(dia, mes, año);
            //Console.WriteLine(valido);

            // 6.- Escribir una programa que pida la nota de un examen(un número real entre 0 y 10) e imprima por
            //pantalla la calificación en formato “Reprueba”, si la nota es menor que  5, “Aprobado” si esta entre 
            //5 y 7 sin incluirlo, “Notable” si esta entre 7 y 9 sin incluirlo,  “Sobresaliente” si esta entre
            //9 y 10 sin incluirlo y “Excelente”  si la nota es igual a 10
            //Console.WriteLine("ingrese la nota entre 0 y 10");
            //int nota = Convert.ToInt32(Console.ReadLine());

            //if (nota <= 5)
            //{
            //    Console.WriteLine("REPRUEBA " + nota);
            //}
            //else
            //{
            //    if (5 < nota && nota < 7)
            //    {
            //        Console.WriteLine("APROBADO " + nota);
            //    }
            //    else
            //    {
            //        if(7<nota && nota < 9)
            //        {
            //            Console.WriteLine("notable " + nota);
            //        }
            //        else
            //        {
            //            if(8<nota && nota < 10)
            //            {
            //                Console.WriteLine("SOBRESALIENTE " + nota);
            //            }
            //            else
            //            {
            //                if (nota == 10)
            //                {
            //                    Console.WriteLine("EXCELENTE " + nota);
            //                }
            //                else
            //                {
            //                    if (nota > 5)
            //                    {
            //                        Console.WriteLine("normal " + nota);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //7.- Dado un número entero determine la cantidad de dígitos que tiene.
            //Console.WriteLine("ingrese un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int cantidad=0;
            //while (numero > 0)
            //{
            //    numero= numero / 10;
            //    cantidad++;
            //}
            //Console.WriteLine("Cantidad de digitos "+cantidad);

            //8.- Dado un número entero determine  la suma de sus dígitos.
            //Console.WriteLine("ingrese un numero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int suma = numero%10;
            //while (numero > 0)
            //{
            //    numero = numero / 10;
            //    suma = suma + (numero % 10);
            //}
            //Console.WriteLine("la suma es  "+suma);

            // 9.- Crea un programa que declare tres variables de tipo entero 
            //con valores A = 5, B = 3, C = -12 y muestre si se cumplen o no las siguientes condiciones usando
            //int A = 5;
            //int B = 3;
            //int C = -12;
            //if (A > 3)
            //{
            //    Console.WriteLine("A) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("A) NO CUMPLE");
            //}
            //if (A > C)
            //{
            //    Console.WriteLine("B) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("B) NO CUMPLE");
            //}
            //if (B!=C)
            //{
            //    Console.WriteLine("C) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("C) NO CUMPLE");
            //}
            //if (A == 3)
            //{
            //    Console.WriteLine("D) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("D) NO CUMPLE");
            //}
            //if (A *B == 15)
            //{
            //    Console.WriteLine("E) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("E) NO CUMPLE");
            //}
            //if (C/B < A)
            //{
            //    Console.WriteLine("F) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("F) NO CUMPLE");
            //}
            //if (C/B == -10)
            //{
            //    Console.WriteLine("G) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("G) NO CUMPLE");
            //}
            //if (A + B + C == 5)
            //{
            //    Console.WriteLine("H) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("H) NO CUMPLE");
            //}
            //if ((A + B == 8) && (A - B == 2))
            //{
            //    Console.WriteLine("I) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("I) NO CUMPLE");
            //}
            //if ((A + B == 8) || (A - B == 6))
            //{
            //    Console.WriteLine("J) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("J) NO CUMPLE");
            //}
            //if (A > 3 && B > 3 && C < 3)
            //{
            //    Console.WriteLine("O) SI CUMPLE");
            //}
            //else
            //{
            //    Console.WriteLine("O) NO CUMPLE");
            //}

            //10.- Que pida un número del 1 al 5 y diga si es primo o no.
            //Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 5");
            //int numero=Convert.ToInt32(Console.ReadLine());
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
            //Console.WriteLine("es primo  " + primo);

            //11.- Que pida un número del 1 al 7 y diga el día de la semana correspondiente.
            //Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 7");
            //int dia = Convert.ToInt32(Console.ReadLine());
            //switch (dia)
            //{
            //    case 1:
            //        Console.WriteLine("LUNES");
            //        break;
            //    case 2:
            //        Console.WriteLine("MARTES");
            //        break;
            //    case 3:
            //        Console.WriteLine("MIERCOLES");
            //        break;
            //    case 4:
            //        Console.WriteLine("JUEVES");
            //        break;
            //    case 5:
            //        Console.WriteLine("VIERNES");
            //        break;
            //    case 6:
            //        Console.WriteLine("SABADO");
            //        break;
            //    case 7:
            //        Console.WriteLine("DOMINGO");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //}

            //12.- Que pida un número del 1 al 12 y diga el nombre del mes correspondiente.
            //Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 12");
            //int dia = Convert.ToInt32(Console.ReadLine());
            //switch (dia)
            //{
            //    case 1:
            //        Console.WriteLine("ENERO");
            //        break;
            //    case 2:
            //        Console.WriteLine("FEBRERO");
            //        break;
            //    case 3:
            //        Console.WriteLine("MARZO");
            //        break;
            //    case 4:
            //        Console.WriteLine("ABRIL");
            //        break;
            //    case 5:
            //        Console.WriteLine("MAYO");
            //        break;
            //    case 6:
            //        Console.WriteLine("JUNIO");
            //        break;
            //    case 7:
            //        Console.WriteLine("JULIO");
            //        break;
            //    case 8:
            //        Console.WriteLine("AGOSTO");
            //        break;
            //    case 9:
            //        Console.WriteLine("SEPTIEMBRE");
            //        break;
            //    case 10:
            //        Console.WriteLine("OCTUBRE");
            //        break;
            //    case 11:
            //        Console.WriteLine("NOVIEMBRE");
            //        break;
            //    case 12:
            //        Console.WriteLine("DICIEMBRE");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //}

            //13.- Que pida 3 números y los muestre en pantalla 
            //de menor a mayor en líneas distintas. En caso de haber números iguales se pintan en la misma línea.
            //Console.WriteLine("ingrese tres numeros ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("***********************");
            //if(numero1==numero2 )
            //{
            //    if (numero1 > numero3)
            //    {
            //        Console.WriteLine(numero3);
            //        Console.WriteLine(numero1+"  "+numero2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(numero1 + "  " + numero2);
            //        Console.WriteLine(numero3);
            //    }
            //}
            //else
            //{
            //    if (numero1 == numero3)
            //    {
            //        if (numero1 > numero2)
            //        {
            //            Console.WriteLine(numero2);
            //            Console.WriteLine(numero1 + "  " + numero3);
            //        }
            //        else
            //        {
            //            Console.WriteLine(numero1 + "  " + numero3);
            //            Console.WriteLine(numero2);
            //        }
            //    }
            //    else
            //    {
            //        if (numero2 == numero3)
            //        {
            //            if (numero2 > numero1)
            //            {
            //                Console.WriteLine(numero1);
            //                Console.WriteLine(numero2 + "  " + numero3);
            //            }
            //            else
            //            {
            //                Console.WriteLine(numero2 + "  " + numero3);
            //                Console.WriteLine(numero1);
            //            }
            //        }
            //        else
            //        {
            //            if (numero1 > numero2 && numero1 > numero3)
            //            {
            //                if (numero2 > numero3)
            //                {
            //                    Console.WriteLine(numero3);
            //                    Console.WriteLine(numero2);
            //                    Console.WriteLine(numero1);
            //                }
            //                else
            //                {
            //                    if (numero3 > numero2)
            //                    {
            //                        Console.WriteLine(numero2);
            //                        Console.WriteLine(numero3);
            //                        Console.WriteLine(numero1);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                if (numero2 > numero1 && numero2 > numero3)
            //                {
            //                    if (numero1 > numero3)
            //                    {
            //                        Console.WriteLine(numero3);
            //                        Console.WriteLine(numero1);
            //                        Console.WriteLine(numero2);
            //                    }
            //                    else
            //                    {
            //                        if (numero3 > numero1)
            //                        {
            //                            Console.WriteLine(numero1);
            //                            Console.WriteLine(numero3);
            //                            Console.WriteLine(numero2);
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    if (numero3 > numero1 && numero3 > numero2)
            //                    {
            //                        if (numero1 > numero2)
            //                        {
            //                            Console.WriteLine(numero2);
            //                            Console.WriteLine(numero1);
            //                            Console.WriteLine(numero3);
            //                        }
            //                        else
            //                        {
            //                            if (numero2 > numero1)
            //                            {
            //                                Console.WriteLine(numero1);
            //                                Console.WriteLine(numero2);
            //                                Console.WriteLine(numero3);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //14.- Que pida un número y diga si es positivo o negativo.
            //Console.WriteLine("ingrese un numero ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //if (numero > 0)
            //{
            //    Console.WriteLine("el numero es positivo "+numero);
            //}
            //else
            //{
            //    if (numero == 0)
            //    {
            //        Console.WriteLine("es ambos");
            //    }
            //    else
            //    {
            //        Console.WriteLine("el numero es negativo " + numero);
            //    }

            //}

            //15.- Que pida 10 números y diga cuál es el mayor y cual el menor.
            //int numero = 10;
            //int[] vec = new int[numero];
            //int mayor = 0;
            //int menor = 10000000;
            //for (int index = 0; index < vec.Length; index++)
            //{
            //    vec[index] = Convert.ToInt32(Console.ReadLine());

            //}
            //for (int index = 0; index < vec.Length; index++)
            //{
            //    Console.Write(" " + vec[index]);

            //}


            //for (int index = 0; index < vec.Length; index++)
            //{
            //    for (int index1 = index + 1; index1 < vec.Length; index1++)
            //    {
            //        if (mayor > vec[index])
            //        {
            //            mayor = mayor;

            //        }
            //        else
            //        {
            //            if (vec[index] > vec[index1])
            //            {
            //                mayor = vec[index];

            //            }
            //            else
            //            {
            //                mayor = vec[index1];

            //            }
            //        }
            //    }
            //}
            //for (int index = 0; index < vec.Length; index++)
            //{
            //    for (int index1 = index + 1; index1 < vec.Length; index1++)
            //    {
            //        if (menor < vec[index])
            //        {
            //            menor=menor;

            //        }
            //        else
            //        {
            //            if (vec[index] < vec[index1])
            //            {
            //                menor = vec[index];

            //            }
            //            else
            //            {
            //                menor = vec[index1];

            //            }
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(mayor);
            //Console.WriteLine();
            //Console.WriteLine(menor);

            //16.- Que pida tres números e indicar si el tercero es igual a la suma del primero y el segundo.
            //Console.WriteLine("ingrese tres numeros");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //int suma = numero1 + numero2;
            //if (numero3 == suma)

            //    Console.WriteLine("El numero "+numero3+" es igual a la suma del primero y segundo numero " + suma);
            //else
            //    Console.WriteLine("es diferente");

            //17.- Que muestre un menú que contemple las opciones “Archivo”, “Buscar” y “Salir”, en caso de que
            //no se introduzca una opción correcta se notificará por pantalla.
            //bool sw = true;
            //while (sw)
            //{
            //    Console.WriteLine("*********MENU*********");
            //    Console.WriteLine("1. ARCHIVO");
            //    Console.WriteLine("2. BUSCAR");
            //    Console.WriteLine("3. SALIR");
            //    try
            //    {

            //        int numero = Convert.ToInt32(Console.ReadLine());
            //        switch (numero)
            //        {
            //            case 1:
            //                Console.WriteLine("ENTRANDO A ARCHIVO...");
            //                break;
            //            case 2:
            //                Console.WriteLine("BUSCANDO EL ARCHIVO...");
            //                break;
            //            case 3:
            //                sw = false;
            //                break;
            //            default:
            //                Console.WriteLine("valor invalido");
            //                break;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("valor invalido");
            //    }
            //}

            // 18.- Que pase de metros a otra unidad de medida de longitud, mostrar en pantalla un
            //menú con las opciones posibles.
            //bool sw = true;
            //Console.WriteLine("INGRESE EL NUMERO A CONVERTIR");
            //double convertir = Convert.ToDouble(Console.ReadLine());
            //while (sw)
            //{

            //    Console.WriteLine("*****menu*****");
            //    Console.WriteLine("1. metros a pie");
            //    Console.WriteLine("2. metros a kilometros");
            //    Console.WriteLine("3. metros a pulgada");
            //    Console.WriteLine("4. metros a milla");
            //    Console.WriteLine("5. matros a milimetro");
            //    Console.WriteLine("6. metros a centimetros");
            //    Console.WriteLine("7. salir");
            //    int numero = Convert.ToInt32(Console.ReadLine());
            //    double resultado ;
            //    try
            //    {
            //        switch (numero)
            //        {
            //            case 1:
            //                resultado = convertir * 3.281;
            //                Console.WriteLine("pies "+resultado);
            //                break;
            //            case 2:
            //                resultado = convertir / 1000;
            //                Console.WriteLine("kilomentros " + resultado);
            //                break;
            //            case 3:
            //                resultado = convertir * 39.3701;
            //                Console.WriteLine("pulgada " + resultado);
            //                break;
            //            case 4:
            //                resultado = convertir / 1609;
            //                Console.WriteLine("milla " + resultado);
            //                break;
            //            case 5:
            //                resultado = convertir * 1000;
            //                Console.WriteLine("milimetro " + resultado);
            //                break;
            //            case 6:
            //                resultado = convertir * 100;
            //                Console.WriteLine("centimetro " + resultado);
            //                break;
            //            case 7:
            //                sw = false;
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine("error");
            //    }
            //}

            //19.- Que lea un importe bruto y calcule su importe neto, 
            //si es mayor de 15.000 se le aplicará un 16% de impuestos, en caso contrario se le aplicará un 10%.
            //Console.WriteLine("introduce el importe bruto");
            //int bruto = Convert.ToInt32(Console.ReadLine());
            //double neto;
            //double impuestos;
            //if (bruto > 15000)
            //{
            //    impuestos = bruto * 0.16;
            //    neto=bruto+impuestos;
            //    Console.WriteLine("su descuento es de 16%  su importe neto es " + neto);
            //}
            //else
            //{
            //    impuestos = bruto * 0.10;
            //    neto = bruto + impuestos;
            //    Console.WriteLine("su descuento es de 10%  su importe neto es " + neto);
            //}

            //20.- Que calcule el sueldo que le corresponde al trabajador de una empresa que cobra 40.000 
            //Bolivianos anuales, el programa debe realizar los cálculos en función de los siguientes criterios:
            Console.WriteLine("Cuantos años trabaja en la empresa");
            int años = Convert.ToInt32(Console.ReadLine());
            double anualAnterior = 40000;
            double anualActual;
            if (años >= 10)
            {
                anualActual = anualAnterior * (1 + 0.160);
                Console.WriteLine("el sueldo actual es " + anualActual);
            }
            else
            {
                if(10>años && años >= 5)
                {
                    anualActual = anualAnterior * (1 + 0.070);
                    Console.WriteLine("el sueldo actual es " + anualActual);
                }
                else
                {
                    if(5>años && años >= 3)
                    {
                        anualActual = anualAnterior * (1 + 0.050);
                        Console.WriteLine("el sueldo actual es " + anualActual);
                    }
                    else
                    {
                        if (3 > años)
                        {
                            anualActual = anualAnterior * (1 + 0.030);
                            Console.WriteLine("el sueldo actual es " + anualActual);
                        }
                    }
                }
            }


        }
        // funcion del ejercicio 5
        //public static Boolean FechaValido(int dia, int mes, int año)
        //{
        //    bool sw=false;
        //    if (dia <= 31 && dia >= 1 && mes <= 12 && mes >= 1 && año <= 2020 && año >= 1)
        //    {

        //        if (año % 4 == 0 && dia <= 29 && mes == 2)
        //        {
        //            sw = true;

        //        }
        //        else
        //        {
        //            if (dia <= 28 && mes == 2)
        //            {
        //                sw = true;

        //            }
        //            else
        //            {
        //                if (dia <= 31 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
        //                {
        //                    sw = true;
        //                }
        //                else
        //                {
        //                    if (dia <= 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
        //                    {
        //                        sw = true;
        //                    }
        //                }
        //            }

        //        }

        //    }
        //    else
        //    {
        //        sw = false;

        //    }
        //    return sw;
        //}
    }
}
