using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Metodos
    {
        public int[,] generarPartida(int [,] partida, int nivel)
        {
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                
                for(int k = 0; k < nivel*3; k++)
                {
                    int n = (int)(rnd.Next(1, 9));
                    for (int j = 0; j < 9; j++)
                    {

                        if (n == j)
                        {
                            partida[i, j] = 0;
                        }
                        if (n == j)
                        {
                            partida[i, j] = 0;
                        }
                        n = (int)(rnd.Next(1, 9));
                    }
                }
            }
            return partida;
        }
        public Boolean terminado(int[,] partida)
        {
            Boolean estado = true;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (0 == partida[i,j])
                    {
                        estado = false;
                    }
                }
            }
            return estado;
        }
        public Boolean comprobardato(int[,] partida, int numero, int fila, int columna)
        {
            Boolean estado = true;
            for (int i = 0; i < 9; i++)
            {
                if (numero == partida[fila,i])
                {
                    estado = false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (numero == partida[i,columna])
                {
                    estado = false;
                }
            }

            /***********************************************************/
            if (fila >= 0 && fila <= 2 && columna >= 0 && columna <= 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 0 && fila <= 2 && columna >= 3 && columna <= 5)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 0 && fila <= 2 && columna >= 6 && columna <= 8)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 3 && fila <= 5 && columna >= 0 && columna <= 2)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 3 && fila <= 5 && columna >= 3 && columna <= 5)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 3 && fila <= 5 && columna >= 6 && columna <= 8)
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 6 && fila <= 8 && columna >= 0 && columna <= 2)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 6 && fila <= 8 && columna >= 3 && columna <= 5)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            if (fila >= 6 && fila <= 8 && columna >= 6 && columna <= 8)
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 6; j < 9; j++)
                    {
                        if (numero == partida[i,j])
                        {
                            estado = false;
                        }
                    }
                }
            }
            return estado;
        }
        public void imprimir(int[,] m)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(m[i,j] + " ");
                }
                Console.Write("/n");
            }
        }
    }
}
