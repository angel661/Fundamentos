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
        Metodos sudo = new Metodos();
        private int[,] inicial = { { 7,5,8,1,6,4,9,2,3 },
                                   { 6,3,9,5,2,8,1,4,7 },
                                   { 4,1,2,3,7,9,5,6,8 },
                                   { 1,8,7,6,3,2,4,5,9 },
                                   { 2,4,3,8,9,5,7,1,6 },
                                   { 5,9,6,4,1,7,3,8,2 },
                                   { 8,7,1,9,4,6,2,3,5 },
                                   { 9,6,4,2,5,3,8,7,1 },
                                   { 3,2,5,7,8,1,6,9,4 }};
        private int[,] partida = new int[9, 9];
        private int[,] restablecer = new int[9, 9];
        //Boolean inic54iar = false;

        public Form1()
        {
            InitializeComponent();
            cbNivel.SelectedItem = "1";
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[,] aTextbox = { { jt00, jt01, jt02, jt03, jt04, jt05, jt06, jt07, jt08 },
                                    { jt10, jt11, jt12, jt13, jt14, jt15, jt16, jt17, jt18 },
                                    { jt20, jt21, jt22, jt23, jt24, jt25, jt26, jt27, jt28 },
                                    { jt30, jt31, jt32, jt33, jt34, jt35, jt36, jt37, jt38 },
                                    { jt40, jt41, jt42, jt43, jt44, jt45, jt46, jt47, jt48 },
                                    { jt50, jt51, jt52, jt53, jt54, jt55, jt56, jt57, jt58 },
                                    { jt60, jt61, jt62, jt63, jt64, jt65, jt66, jt67, jt68 },
                                    { jt70, jt71, jt72, jt73, jt74, jt75, jt76, jt77, jt78 },
                                    { jt80, jt81, jt82, jt83, jt84, jt85, jt86, jt87, jt88 },};
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    partida[i,j] = inicial[i,j];
                }
            }
            nivel();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    restablecer[i,j] = partida[i,j];
                }
            }
            inicio();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    aTextbox[i, j].TextAlign = HorizontalAlignment.Center;
                    if (partida[i,j] != 0)
                    {
                        aTextbox[i, j].Text = ""+partida[i,j];
                        aTextbox[i, j].ForeColor = Color.Blue;
                        aTextbox[i, j].Enabled = false;
                    }
                }
            }
            //iniciar = true;
            /*sudo.imprimir(partida);*/
        }
        public void finalizar()
        {
            TextBox[,] aTextbox = { { jt00, jt01, jt02, jt03, jt04, jt05, jt06, jt07, jt08 },
                                    { jt10, jt11, jt12, jt13, jt14, jt15, jt16, jt17, jt18 },
                                    { jt20, jt21, jt22, jt23, jt24, jt25, jt26, jt27, jt28 },
                                    { jt30, jt31, jt32, jt33, jt34, jt35, jt36, jt37, jt38 },
                                    { jt40, jt41, jt42, jt43, jt44, jt45, jt46, jt47, jt48 },
                                    { jt50, jt51, jt52, jt53, jt54, jt55, jt56, jt57, jt58 },
                                    { jt60, jt61, jt62, jt63, jt64, jt65, jt66, jt67, jt68 },
                                    { jt70, jt71, jt72, jt73, jt74, jt75, jt76, jt77, jt78 },
                                    { jt80, jt81, jt82, jt83, jt84, jt85, jt86, jt87, jt88 },};
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    aTextbox[i, j].Enabled = false;
                }
            }
        }
        
        private void EventoTextBox(object sender, KeyPressEventArgs e)
        {
            Boolean juego = true;
            TextBox[,] aTextbox = { { jt00, jt01, jt02, jt03, jt04, jt05, jt06, jt07, jt08 },
                                    { jt10, jt11, jt12, jt13, jt14, jt15, jt16, jt17, jt18 },
                                    { jt20, jt21, jt22, jt23, jt24, jt25, jt26, jt27, jt28 },
                                    { jt30, jt31, jt32, jt33, jt34, jt35, jt36, jt37, jt38 },
                                    { jt40, jt41, jt42, jt43, jt44, jt45, jt46, jt47, jt48 },
                                    { jt50, jt51, jt52, jt53, jt54, jt55, jt56, jt57, jt58 },
                                    { jt60, jt61, jt62, jt63, jt64, jt65, jt66, jt67, jt68 },
                                    { jt70, jt71, jt72, jt73, jt74, jt75, jt76, jt77, jt78 },
                                    { jt80, jt81, jt82, jt83, jt84, jt85, jt86, jt87, jt88 },};

            TextBox txt = sender as TextBox;

            String s = txt.Name;
            int f = Int32.Parse(s.Substring(2, 1));
            int c = Int32.Parse(s.Substring(3, 1));

            int numero = (int)(e.KeyChar-48);
            if (numero < 0)
                numero = 0;
            //MessageBox.Show(""+numero);
            if (sudo.comprobardato(partida, numero, f, c))
            {
                aTextbox[f, c].ForeColor = Color.Green;
                juego = true;
            }
            else
            {
                aTextbox[f, c].ForeColor = Color.Red;
                juego = false;
            }
            partida[f,c] = numero;
            sudo.imprimir(partida);
            if (sudo.terminado(partida) && juego)
            {
                finalizar();
                MessageBox.Show("Juego Terminado");
            }
        }

        private void Resetear_Click(object sender, EventArgs e)
        {
            inicio();
        }
        private void inicio()
        {
            TextBox[,] aTextbox = { { jt00, jt01, jt02, jt03, jt04, jt05, jt06, jt07, jt08 },
                                    { jt10, jt11, jt12, jt13, jt14, jt15, jt16, jt17, jt18 },
                                    { jt20, jt21, jt22, jt23, jt24, jt25, jt26, jt27, jt28 },
                                    { jt30, jt31, jt32, jt33, jt34, jt35, jt36, jt37, jt38 },
                                    { jt40, jt41, jt42, jt43, jt44, jt45, jt46, jt47, jt48 },
                                    { jt50, jt51, jt52, jt53, jt54, jt55, jt56, jt57, jt58 },
                                    { jt60, jt61, jt62, jt63, jt64, jt65, jt66, jt67, jt68 },
                                    { jt70, jt71, jt72, jt73, jt74, jt75, jt76, jt77, jt78 },
                                    { jt80, jt81, jt82, jt83, jt84, jt85, jt86, jt87, jt88 },};
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    aTextbox[i, j].Enabled = true;
                    aTextbox[i, j].Text = "";
                    if (restablecer[i, j] != 0)
                    {
                        aTextbox[i, j].Text = "" + restablecer[i, j];
                        aTextbox[i, j].ForeColor = Color.Blue;
                        aTextbox[i, j].Enabled = false;
                    }
                }
            }
        }
        private void nivel()
        {
            partida = sudo.generarPartida(partida, Int32.Parse(cbNivel.Text));
        }

        private void jt00_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
