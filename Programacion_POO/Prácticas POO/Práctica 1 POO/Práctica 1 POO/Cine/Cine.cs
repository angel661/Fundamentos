using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_1_POO.Cine
{
    class Cine
    {
        Cine(Pelicula pelicula, int precio)
        {
            Pelicula = pelicula;
            Precio = precio;
            Espacio = 64;
            VaciarCine();
        }
        public void AsignarEspectador(Espectador espectador, char columna, int fila)
        {
            if (espectador.Midinero() >= Precio)
            {
                int columnaN = 0;
                string Columnas = "ABCDEFGHI";
                for(int i = 0; i < 8; i++)
                {
                    if (Columnas[i] == columna)
                    {
                        columnaN = i;
                        break;
                    }
                }
                if (Espacio > 0)
                {
                    if (espectador.Miedad() >= Pelicula.Miedadmin())
                    {
                        if (Asientos[8 - (fila - 1), columnaN] == false) 
                        {
                            Asientos[8 - (fila - 1), columnaN] = true;
                            Console.WriteLine("El asiento ha sido seleccionado y el espectador podrá entrar satisfactoriamente");
                        }
                        else
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                for (int l = 0; l < 8; l++)
                                {
                                    if(Asientos[i, l] == false)
                                    {

                                        Asientos[i, l] = true;
                                        Console.WriteLine("El asiento seleccionado se encunetra ocupado, el nuevo asiento es: {0}{1}", 8 - i,Columnas[l]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("El espectador no cumple la edad requerida");
                    }
                }
                else
                {
                    Console.WriteLine("El cine se encuentra lleno");
                }
            }
            else
            {
                Console.WriteLine("El espectador no cumple el requisito de dinero");
            }
        }
        public void VaciarCine()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int l = 0; l < 8; l++)
                {
                    Asientos[i,l] = false;
                }
            }
        }
        Pelicula Pelicula { get; set; }
        int Precio { get; set; }
        int Espacio { get; set; }

        bool[,] Asientos = new bool[8, 8];

    }
}
