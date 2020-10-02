using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5, B = 3, C = -12;
            Console.WriteLine("a) A > 3");
            if (A > 3)
            {
                Console.WriteLine("Correcot el valor de A es mayor a 3.");
            }
            else
            {
                Console.WriteLine("No el valor de A no es mayor a 3.");
            }
            Console.WriteLine();
            Console.WriteLine("b) A > C");
            if (A > C)
            {
                Console.WriteLine("Correcto A={0} es mayor a C={1}.", A, C);
            }
            else
            {
                Console.WriteLine("A={0} no es mayor a C={1}.", A, C);
            }
            Console.WriteLine();
            Console.WriteLine("c) B != C");
            if (B!=C)
            {
                Console.WriteLine("Si B={0} es diferente de C={1}", B, C);
            }
            else
            {
                Console.WriteLine("B={0} no es diferente de C={1}", B, C);
            }
            Console.WriteLine();
            Console.WriteLine("d) A == 3");
            if (A == 3)
            {
                Console.WriteLine("Si, A = {0} es igual a 3", A);
            }
            else
            {
                Console.WriteLine("A={0} no es igual a 3", A);
            }
            Console.WriteLine();
            Console.WriteLine("e) A * B == 15");
            if (A * B == 15)
            {
                Console.WriteLine("El resultado es correcto.");
            }
            else
            {
                Console.WriteLine("El resultado es incorrecto.");
            }
            Console.WriteLine();
            Console.WriteLine("f) C / B < A");
            if (C / B < A)
            {
                Console.WriteLine("Si, el resultado de C={0} dividido entre B={1} es menor a A={2}", C, B, A);
            }
            else
            {
                Console.WriteLine("NO, el resultado de C={0} dividido entre B={1} no es menor a A={2}", C, B, A);
            }
            Console.WriteLine();
            Console.WriteLine("g) C / B == -10");
            if (C / B == -10)
            {
                Console.WriteLine("Si, el resultado de la división entre c = {0} y B = {1} es correcto.", C, B);
            }
            else
            {
                Console.WriteLine("El resultado de la división entre c = {0} y B = {1} no es -10 ");
            }
            Console.WriteLine();
            Console.WriteLine("i) (A+B == 8) && (A-B == 2)");
            if ((A + B == 8) && (A - B == 2))
            {
                Console.WriteLine("A={0} + B={1} = 8", A, B);
                Console.WriteLine("A={0} - B={1} = 2", A, B);
                Console.WriteLine("Correcto.");
            }
            else
            {
                Console.WriteLine("Resultados incorrectos.");
            }
            Console.WriteLine();
            Console.WriteLine("j) (A+B == 8) || (A-B == 6)");
            if ((A + B == 8) || (A - B == 6))
            {
                Console.WriteLine("La suma de A={0} mas B={1} es 8", A, B);
            }
            else
            {
                Console.WriteLine("La resta de A={0} menos B={1} no es 3", A, B);
            }
            Console.WriteLine();
            Console.WriteLine("k) A > 3 && B > 3 && C < 3");
            if (A > 3 && B > 3 && C < 3)
            {
                Console.WriteLine("Correcto.");
            }
            else
            {
                Console.WriteLine("Es incorrecto porque B = {0} no es mayor a 3.", B);
            }
        }
    }
}
