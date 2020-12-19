using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
	public partial class Form1 : Form
	{
		private int contador = 0;
		public Form1()
		{
			InitializeComponent();
			buttonFacil.Visible = false;
			buttonMedia.Visible = false;
			buttonDificll.Visible = false;
			labelDificultad.Visible = false;
			this.CenterToScreen();
			this.Text = "JUEGO SUDOKU - MIGUEL GONZALES";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			button1.Visible = false;
			button2.Visible = false;
			buttonFacil.Visible = true;
			buttonMedia.Visible = true;
			buttonDificll.Visible = true;
			labelDificultad.Visible = true;
			
		}

		private void buttonEasy_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Easy);
			frm.Show();
			this.Hide();
		}

		private void buttonMedium_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Medium);
			frm.Show();
			this.Hide();
		}

		private void buttonHard_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Hard);
			frm.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
		
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '6')
			{
				contador++;
				if (contador==3) { 
					contador = 0;

					button1.Visible = false;
					labelDificultad.Visible = true;

				}
			}
		}

		private void evilButton_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.devilmodSkere);
			frm.Show();
			this.Hide();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("¿Desea Salir de Juego?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
			{
				this.Close();
			}
		}
    }
}
