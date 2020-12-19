﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
	
	public class GrillaSudoku : ICloneable
	{
		//grilla 
		public int[,] grilla;
		//numero de limite 
		private const int Max = 9;

		public GrillaSudoku()
		{
			grilla = new int[9, 9];
		}

		public int inicializarCeldas(int filaA, int columnB, int valor)
		{
			int correcto = 0;
			bool validIndex = false;
			bool validNueva = false;

			if (filaA >= 0 && filaA < 9 && columnB >= 0 && columnB < 9)
			{
				validIndex = true;
			}

			if (valor >= -9 && valor <= 9)
			{
				validNueva = true;
			}

			if (validIndex && validNueva)
			{
				grilla[filaA, columnB] = valor;
				correcto = 1;
			}
			else
			{
				correcto = 0;
			}

			return (correcto);
		}

		
		public int setearCeldaUsuario(int filaA, int columnB, int valor)
		{
			int correcto = 0;
			bool validIndex = false;
			bool validNueva = false;
			bool puedeRemplazarse = false;

			if (filaA >= 0 && filaA < 9 && columnB >= 0 && columnB < 9)
			{
				validIndex = true; 
			}

			
			if (valor >= 0 && valor <= 9)
			{
				validNueva = true;
			}

			
			if (grilla[filaA, columnB] >= 0)
			{
				puedeRemplazarse = true;
			}

			if (validIndex && validNueva && puedeRemplazarse)
			{
				grilla[filaA, columnB] = valor;
				correcto = 1;
			}
			else
			{
				correcto = 0;
			}

			return correcto;
		}

		public void Termina()
		{
			for (var i = 0; i < Max; i++)
			{
				for (var j = 0; j < Max; j++)
				{
					grilla[i, j] = Math.Abs(grilla[i, j]) * -1;
				}
			}
		}

		//clona objeto interfaz clone
		public object Clone()
		{
			GrillaSudoku p = new GrillaSudoku();
			for (int i = 0; i < Max; i++)
			{
				for (int j = 0; j < Max; j++)
				{
					p.inicializarCeldas(i, j, grilla[i, j]);
				}
			}
			return p;
		}

		public bool estaEnBlanco()
		{
			var estaEnBlanco = true;
			for (var i = 0; i < Max; i++)
			{
				for (var j = 0; j < Max; j++)
				{
					if (grilla[i, j] != 0)
					{
						estaEnBlanco = false;
					}
				}
			}

			return estaEnBlanco;
		}
	}

}