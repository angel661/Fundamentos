using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_POO
{
    public class Empleado
    {
        //De los atributos de clase existe una copia única para toda la clase, 
        // al contrario de lo que ocurre con los de instancia, para los cuales 
        //hay una copia por cada una de las instancias de la clase.De hecho, 
        // el atributo de clase existe por el hecho de existir la clase,
        //incluso aunque no se haya creado ninguna instancia de esa clase.

        public static double PagoExtra { get; set; }
        public string nombre { get; set; }
        public double saldo { get; set; }
    }
}
