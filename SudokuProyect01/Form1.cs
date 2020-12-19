using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SudokuProyect01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            sudokuControl1.Juego = new SudokuJuego();
            sudokuControl1.Juego.SetValue(3, 6, 9);
            sudokuControl1.Juego.SetValue(4, 2, 1); 
            sudokuControl1.Juego.SetValue(7, 5, 8);
            sudokuControl1.Juego.SetValue(2, 3, 4);
            sudokuControl1.Juego.SetValue(3, 8, 1);
            sudokuControl1.Juego.SetValue(2, 4, 6);
            sudokuControl1.Juego.SetValue(7, 5, 8);
           

            sudokuControl1.Invalidate(true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.sudokuControl1.Juego != null)
            {
                bool val = this.sudokuControl1.Juego.Validate();
                if (val == false)
                {
                    MessageBox.Show("No valido");
                }
            }
        
        }

    }
}
