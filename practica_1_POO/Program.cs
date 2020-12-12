using practica_1_POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1    Una clase es lo mismo que un objeto
            //                       b) Falso

            //2    Las clases permiten que el programador modele objetos
            //     que contienen atributos y comportamientos
            //                       a) Verdadero
            //                  
            //3    En C# cuando se declara un objeto, este se crea automaticamente                                              
            //                       a) Verdadero

            //4    Solo los metodos pueden ser declarados public
            //                       b) Falso                                                  

            //5    Solo los atributos pueden ser declarados private
            //                       b) Falso                                                  

            //6    Cuando se declara un dato o funcion despues de en la clase, 
            //       este puede ser visible para cualquier funcion que tenga acceso a dicha clase
            //                       a) Verdadero                                                 

            //7    El constructor se invoca cuando se crea una instancia de una clase
            //                       b) Falso 

            //8    El constructor se invoca cuando se crea un objeto de de una clase
            //                       a) Verdadero
            //9    Los datos o funciones privados de una clase son visibles desde fuera de la clase
            //                      b) Falso                                                  

            //10    Solo los miembros de una clase tienen acceso directo a los atributos privados
            //                       a) Verdadero            

            //11    Si se declara un atributo privado, puede ser inicializado desde fuera de la 
            //clase con el operador de asignacion de igualdad(=)
            //                       b) Falso                                                  

            //12    Solo los metodos pueden ser declarados private
            //                       b) Falso                                                  

            //13    Solo los atributos pueden ser declarados public
            //                       b) Falso                                                  

            //14    Un arreglo NO puede ser un atributo de una clase
            //                       b) Falso                                                  

            //15    Los constructores deben prototiparse
            //                       b) Falso                                                  

            //16    Los destructores deben prototiparse
            //                       b) Falso                                                  

            //17    Se refiere a "quitar" propiedades y metodos de un objeto y 
            //quedarse solo con aquellos que sean necesarios(relevantes para el problema a solucionar)
            //                       b) Abstraccion
            //18    Se centra en las caracteristicas esenciales de algun objeto,
            //en relacion a la perspectiva del observador
            //                       b) Abstraccion


            //19    Es una plantilla, plano o definicion que contiene la 
            //descripcion de las caracteristicas y acciones que se desean modelar
            //                       b) Clase

            //20    A partir de una clase se pueden crear muchos objetos 
            //independientes con las mismas caracteristicas
            //                       a) Verdadero              

            //21    Es una unidad o elemento que combina datos y funciones
            //                       a) Objeto

            //22    Es creado a partir de una clase
            //                       a) Objeto                                            

            //23    Son las caracteristicas o datos de los objetos
            //                       d) Atributos                                              

            //24    Son las acciones u operaciones a realizar por un objeto
            //                       c) Metodos

            //25    Se refiere al valor de las caracteristicas de un objeto
            //                       a) Estado                                            

            //26    Se refiere a las acciones que puede realizar un objeto

            //                       b) Comportamiento                                           

            //27    Se refiere a que un objeto tiene un nombre unico y 
            //pertenece a una clase
            //                       c) Identidad                                              

            //28    Es la instancia de una clase
            //                       a) Objeto                                            

            //29    Permite incluir en una sola entidad la informacion
            //y operaciones que manipulan dicha informacion
            //                       c) Encapsulamiento


            //30    Permite "eliminar" caracteristicas y acciones irrelevantes 
            //para el problema que se desea modelar
            //                       d) Sobrecarga         
            //31    Permite definir restricciones de acceso
            //(como publico oprivado) a los componentes de los objetos
            //                       c) Encapsulamiento


            //32    Permite ocultar los detalles de implementacion de los objetos
            //                       c) Encapsulamiento                                           

            //33    En C# cuando se declara un objeto, automaticamente se  
            //crea una instancia de la clase a la que pertenece      
            //                       a) Verdadero                                                

            //34    Se utiliza para crear un objeto y/o inicializar su estado
            //                       a) Constructor                                            

            //35    Se utiliza para liberar el estado de un objeto
            //                       b) Destructor                                             

            //36    Capacidad para utilizar caracteristicas previstas en 
            //antepasados o ascendientes
            //                       a) Herencia


            //37    Permite crear nuevas clases a partir de otras ya existentes,
            //permitiendo que estas transmitan sus propiedades
            //                       a) Herencia


            //38    La clase base tambien se conoce como super clase
            //                       a) Verdadero

            //39    La clase base tambien se conoce como clase madre
            //                       a) Verdadero                                              

            //40    La clase base tambien se conoce como clase derivada
            //                       b) Falso                                                  


            //41    Una clase derivada hereda de una clase base            
            //                       a) Verdadero                                                

            //42    Una clase base hereda de una clase derivada
            //                       b) Falso                                                  

            //43    A las clases derivadas tambien se les conoce como
            //     clases hijas
            //                       a) Verdadero


            //44    Una subclase es una clase derivada
            //                       a) Verdadero                                               

            //45    Una subclase hereda el comportamiento y la estructura
            //                       de una clase base                                      
            //                       a) Verdadero                                                  

            //46    En C# se permite la herencia simple                    
            //                       a) Verdadero


            //47    En C# se permite la herencia multiple                  
            //                       b) Falso                                                  

            //48    Se pueden generar instancias de una clase abstracta
            //                       b) Falso                                                  

            //49    Se pueden crear objetos de una clase abstracta
            //                       b) Falso                                                  

            //50    Se pueden crear objetos de una clase derivada de una 
            //clase abstracta
            //                       a) Verdadero

            //            1 Crear una clase Libro que contenga los siguientes atributos:
            //– ISBN
            //– Titulo
            //– Autor
            //– Número de páginas
            //Crear sus respectivos métodos get y set correspondientes para cada atributo. 
            //Crear el método toString() para mostrar la información relativa al libro con el siguiente formato:
            //“El libro con ISBN creado por el autor tiene páginas”
            //En el fichero main, crear 2 objetos Libro(los valores que se quieran) y mostrarlos por pantalla.
            //Por último, indicar cuál de los 2 tiene más páginas.

            //Libro libro1 = new Libro(9548261356, "laguna", "lorenzo lopez", 320);
            //Libro libro2 = new Libro(9458736599, "nueva luna", "valeria garcia", 400);
            //Console.WriteLine(libro2.ToString());
            //Console.WriteLine(libro1.ToString());

            //if (libro1.NumeroPaginas > libro2.NumeroPaginas)
            //{
            //    Console.WriteLine("el quew tiene mas paginas es " + libro1.Titulo +
            //        " con " + libro1.NumeroPaginas);
            //}

            //else
            //{
            //    Console.WriteLine("el quew tiene mas paginas es " + libro2.Titulo + " con " + libro2.NumeroPaginas);

            //}

            // 2 Vamos a realizar una clase llamada Raices, donde representaremos los valores de una ecuación de 2º grado. 
            //Tendremos los 3 coeficientes como atributos, llamémosles a, b y c.
            //Hay que insertar estos 3 valores para construir el objeto.
            //Las operaciones que se podrán hacer son las siguientes:
            //-obtenerRaices(): imprime las 2 posibles soluciones
            //-obtenerRaiz(): imprime única raíz, que será cuando solo tenga una solución posible.
            //-getDiscriminante(): devuelve el valor del discriminante(double), el discriminante tiene la siguiente formula, (b ^ 2)-4 * a * c
            //- tieneRaices(): devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
            //- tieneRaiz(): devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
            //- calcular(): mostrara por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
            //Formula ecuación 2º grado: (-b±√((b ^ 2) - (4 * a * c)))/ (2 * a)
            //Solo varia el signo delante de –b

            //Raices raices = new Raices(1, 2, -3);
            //raices.calcular();

            //            3 Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.
            //Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo. De los estudiantes,
            //queremos saber también su calificación actual(entre 0 y 10) y del profesor que materia da.
            //Las materias disponibles son matemáticas, filosofía y física.
            //Los estudiantes tendrán un 50 % de hacer novillos, por lo que si hacen novillos no van a clase pero aunque no vayan 
            //quedara registrado en el aula(como que cada uno tiene su sitio).
            //El profesor tiene un 20 % de no encontrarse disponible(reuniones, baja, etc.)
            //Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor(polimorfismo).
            //El aula debe tener un identificador numérico, el número máximo de estudiantes y para que esta destinada(matemáticas, 
            //filosofía o física). Piensa que más atributos necesita.
            //Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente
            //en el aula correspondiente(un profesor de filosofía no puede dar en un aula de matemáticas) 
            //y que haya más del 50 % de alumnos.
            //El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo 
            //en cuenta las condiciones antes dichas.
            //Si se puede dar clase mostrar cuantos alumnos y alumnas(por separado) están aprobados de
            //momento(imaginad que les están entregando las notas).
            //NOTA: Los datos pueden ser aleatorios(nombres, edad, calificaciones, etc.) siempre y 
            //cuando tengan sentido(edad no puede ser 80 en un estudiante o calificación ser 12).

            //Creamos el objeto
            Aula aula = new Aula();

            //Indicamos si se puede dar la clase
            if (aula.darClase())
            {
                aula.notas();
            }

        }
    }
}
