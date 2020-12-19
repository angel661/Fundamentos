using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProyect01
{
    public abstract class SudokuGrupoCelda
    {
        public List<SudokuCelda> celdas;
        public List<SudokuCelda> Celdas
        {
            get { return this.celdas; }
        }

        public SudokuGrupoCelda()
        {
            celdas = new List<SudokuCelda>(9);

            for (int i = 0; i < 9; i++)
            {
                celdas.Add(null);
            }

        }

        public bool Validate()
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < celdas.Count; i++)
            {
                if (celdas[i] != null)
                {
                    if (ints.Contains(celdas[i].Value))
                        return false;
                    else
                        ints.Add(celdas[i].Value);
                }
            }

            return true;

        }
        
    }
}

