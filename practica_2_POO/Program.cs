using System;

namespace practica_2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Crea una clase Cuenta con los métodos ingreso, reintegro y transferencia.
            //La clase contendrá un constructor por defecto, un constructor con
            //parámetros, un constructor copia y los métodos getters y setters.
            //Cuenta cuenta1 = new Cuenta("josue cruz", "4561328yu", 500);
            //Cuenta cuenta2 = new Cuenta("sandra lopez", "89565266yo", 200);
            //Console.WriteLine(cuenta1.ToString());
            //Console.WriteLine(cuenta2.ToString());
            //cuenta1.Transferencia(cuenta2,100);
            //cuenta2.Ingreso(300);
            //cuenta1.reIntegro(800);
            //Console.WriteLine(cuenta1.ToString());
            //Console.WriteLine(cuenta2.ToString());

            //2.Crea una clase Contador con los métodos para incrementar y decrementar
            //el contador. La clase contendrá un constructor por defecto, un constructor
            //con parámetros, un constructor copia y los métodos getters y setters.
            //Contador contador1 = new Contador(8);
            //contador1.Incrementar(19);
            //contador1.Decrementar(5);

            //3.Crea una clase Libro con los métodos préstamo, devolución y toString.La
            //clase contendrá un constructor por defecto, un constructor con parámetros y
            //los métodos getters y setters.
            //Libro libro1 = new Libro("MISTERIOS", "LARA MARQUEZ", 120, "HORIZONTE", 2, 6);
            //Console.WriteLine(libro1.ToString());
            //libro1.Prestamos();
            //Console.WriteLine(libro1.ToString());
            //libro1.Devolucion();
            //Console.WriteLine(libro1.ToString());

            //4.Crea una clase Fraccion con métodos para sumar, restar, multiplicar y
            //dividir fracciones.
            //Fraccion fraccion1 = new Fraccion(4, 6);
            //Fraccion fraccion2 = new Fraccion(9, 6);
            //Fraccion fraccion3 = new Fraccion(3, 2);
            //Console.WriteLine(fraccion1.ToString());
            //Console.WriteLine(fraccion2.ToString());
            //Console.WriteLine(fraccion3.ToString());

            //Console.WriteLine(fraccion1.ToString()+" + "+fraccion2.ToString()+"=");
            //Console.WriteLine(Fraccion.sumar(fraccion1, fraccion2).ToString());

            //Console.WriteLine(fraccion1.ToString() + " - " + fraccion2.ToString() + "=");
            //Console.WriteLine(Fraccion.restar(fraccion1, fraccion3).ToString());

            //Console.WriteLine(fraccion1.ToString() + " * " + fraccion2.ToString() + "=");
            //Console.WriteLine(Fraccion.multiplicar(fraccion2, fraccion3).ToString());

            //Console.WriteLine(fraccion1.ToString() + " / " + fraccion2.ToString() + "=");
            //Console.WriteLine(Fraccion.division(fraccion3, fraccion1).ToString());

            //5.Crea una clase Complejo con métodos para sumar, restar, multiplicar y
            //dividir números complejos.
            //Complejo complejo1 = new Complejo(4, 5);
            //Complejo complejo2 = new Complejo(6, 8);
            //Complejo complejo3 = new Complejo(3, 8);
            //Console.WriteLine(complejo1.ToString());
            //Console.WriteLine(complejo2.ToString());
            //Console.WriteLine(complejo3.ToString());
            //Console.WriteLine(complejo1.ToString() + " + " + complejo2.ToString() + "=");
            //Console.WriteLine(Complejo.sumar(complejo1, complejo2).ToString());

            //Console.WriteLine(complejo1.ToString() + " - " + complejo3.ToString() + "=");
            //Console.WriteLine(Complejo.restar(complejo1, complejo3).ToString());

            //Console.WriteLine(complejo2.ToString() + " * " + complejo3.ToString() + "=");
            //Console.WriteLine(Complejo.multiplicar(complejo2, complejo3).ToString());

            //Console.WriteLine(complejo2.ToString() + " / " + complejo2.ToString() + "=");
            //Console.WriteLine(Complejo.dividir(complejo2, complejo3).ToString());

            //6.Crea una clase Fecha.La clase contendrá además de constructores,
            //métodos set y get y el método toString, un método para comprobar si la
            //fecha es correcta y otro para modificar la fecha actual por la del día
            //siguiente.
            //Fecha fecha1 = new Fecha(30, 2, 2020);
            //Console.WriteLine(fecha1.ToString());
            //fecha1.fechaCorrecta();
            //Console.WriteLine(fecha1.fechaCorrecta());
            //fecha1.Modificar();

            //7.Crea una clase Empleado.La clase contendrá un atributo estático o
            //atributo de clase.
            //Empleado A = new Empleado();

            //8.Crea una clase NIF.Los atributos serán el número de DNI y la letra. La
            //clase contendrá un método privado que calcule la letra del NIF a partir del
            //número de DNI
            NIF nif1 = new NIF(2);
            Console.WriteLine(nif1.ToString());

            //1.Crea una clase Persona.La clase contendrá un atributo fechaNacimiento
            //que será un objeto de la clase Fecha creada en el ejercicio 6 anterior.
            Persona per = new Persona();








        }
    }
}
