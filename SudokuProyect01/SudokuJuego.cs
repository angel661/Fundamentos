using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuProyect01
{
    public class SudokuJuego
    {
        private List<SudokuFila> filas;
        public List<SudokuFila> Filas
        {

            get { return filas; }
            set { filas = value; }
        }
        private List<SudokuColumna> columnas;
        public List<SudokuColumna> Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }

        private List<SudokuRaiz> raices;
        public List<SudokuRaiz> Raices
        {
            get { return raices; }
            set { raices = value; }
        }

        private List<SudokuCelda> celdas;
        public List<SudokuCelda> Celdas
        {
            get { return celdas; }
            set { celdas = value; }
        }

        public SudokuJuego()
        {
            filas = new List<SudokuFila>(9);
            columnas = new List<SudokuColumna>(9);
            raices = new List<SudokuRaiz>(9);
            celdas = new  List<SudokuCelda> (81);

            InitializeJuego();
        }
        void InitializeJuego()
        {
            for (int i = 0; i < 9; i++)
            {
                SudokuFila sdf = new SudokuFila();
                sdf.FilaNumber = i + 1;
                filas.Add(sdf);
            }

            for (int i = 0; i < 9; i++)
            {
                SudokuColumna sdc = new SudokuColumna();
                sdc.ColumnaNumber = i + 1;
                columnas.Add(sdc);
            }

            for (int i = 0; i < 9; i++)
            {
                SudokuRaiz sdr = new SudokuRaiz();
                sdr.RaizNumber = i + 1;
                raices.Add(sdr);
            }
            for (int i = 0; i < 81; i++)
            {
                celdas.Add(null);
            }
        }

        public void SetValue(int columna, int row, int value)
        {
            int index = (row - 1)* 9 + columna - 1;
            celdas[index] = new SudokuCelda(new System.Drawing.Point(columna, row), value);
            filas[row - 1].Celdas[columna - 1] = celdas[index];
            columnas[columna - 1].Celdas[row - 1] = celdas[index];
            int sq_i = GetRaizIndexFromCeldaIndex(index);
            int internal_i = GetInternalRaizIndexFromCeldaIndex(index);
            raices[sq_i].Celdas[internal_i] = celdas[index];
        
        }

        int GetCeldaIndexFromPosition(int columna, int row)
        {
            return (row - 1) * 9 + columna - 1;
        }

        System.Drawing.Point GetPositionFromCeldaIndex(int celdaIndex)
        {
            System.Drawing.Point pt = new System.Drawing.Point();
            pt.X = celdaIndex % 9 + 1;
            pt.Y = celdaIndex / 9 + 1;
            return pt;
        }

        int GetRaizIndexFromCeldaIndex(int celdaIndex)
        {
            System.Drawing.Point pt = GetPositionFromCeldaIndex(celdaIndex);
            if (pt.X <= 3)
            {
                if (pt.Y <= 3 )
                return 0;
                if (pt.Y > 3  && pt.Y <= 6)
                    return 3;
                if (pt.Y > 6 && pt.Y <= 10)
                    return 6;
            }
            if (pt.X > 3 && pt.X <= 6)
            {
                if (pt.Y <= 3)
                    return 1;
                if (pt.Y > 3 && pt.Y <= 6)
                    return 4;
                if (pt.Y > 6 && pt.Y < 10)
                    return 7;
            }
            if (pt.X > 6 && pt.X < 10)
            {
                if (pt.Y <= 3)
                    return 2;
                if (pt.Y > 3 && pt.Y <= 6)
                    return 5;
                if (pt.Y > 6 && pt.Y < 10)
                    return 8;
            }
            return 0;
        }

        int GetInternalRaizIndexFromCeldaIndex(int celdaIndex)

        {
            System.Drawing.Point pt = GetPositionFromCeldaIndex(celdaIndex);

            int p_x = (pt.X - 1) % 3;
            int p_y = (pt.Y - 1) % 3;

            return p_y * 3 + p_x;
        }

        public bool Validate()
        {
            bool val = true;
            foreach (SudokuGrupoCelda grupo in filas)
                val &= grupo.Validate();
            foreach (SudokuGrupoCelda grupo in columnas)
                val &= grupo.Validate();
            foreach (SudokuGrupoCelda grupo in raices)
                val &= grupo.Validate();
            return val;
        
        }

    }
}
