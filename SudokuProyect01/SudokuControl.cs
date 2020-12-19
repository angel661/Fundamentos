using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuProyect01
{
    public partial class SudokuControl: UserControl
    {
        private SudokuJuego juego;
        public SudokuJuego Juego
        {
            get { return juego; }
            set
            {
                juego = value;
                this.Invalidate();

            }
        
        }
        public Color SelectedColor { get; set; }
        public Color ErrorColor { get; set; }
        public Color DefaultColor { get; set; }
        public Color LineColor { get; set; }
        public Color ThickLineColor { get; set; }
        public Point SelecedBox { get; set; }

        public SudokuControl()
        {

            this.juego = null;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            InitializeComponent();

            this.SelectedColor = Color.AliceBlue;
            this.ErrorColor = Color.Red;
            this.DefaultColor = Color.LightGray;
            this.LineColor = Color.LightGray;
            this.ThickLineColor = Color.Black;
            this.SelecedBox = new Point();
        }

        private void SudokuControl_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Height, this.Size.Height);
        }

        private void SudokuControl_Paint(object sender, PaintEventArgs e)
        {
            Brush br1 = new SolidBrush(this.BackColor);
            e.Graphics.FillRectangle(br1, e.ClipRectangle);
            br1.Dispose();

            float step_w1 = (this.Width-1) / 9f;
            float step_h1 = (this.Height-1) / 9f;

            if (this.SelecedBox.X != 0 && this.SelecedBox.Y != 0)
            {
                Rectangle rec = new Rectangle((int)((SelecedBox.X - 1) * step_w1), (int)((SelecedBox.Y - 1) * step_h1), (int)step_w1+1, (int)step_h1+1);
                e.Graphics.FillRectangle(Brushes.LightBlue, rec);
            }

            for (int i = 0; i <= 9; i++)
            {
                Pen p = new Pen(this.LineColor);
                //p.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                //p.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                e.Graphics.DrawRectangle(p, 0, (int)i * step_h1, this.Width, (int)i * step_h1);
                p.Dispose();
            }

            for (int i = 0; i <= 9; i++)
            {
                Pen p = new Pen(this.LineColor);
                //p.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                //p.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                e.Graphics.DrawRectangle(p, (int)i * step_w1, 0, (int)i * step_w1, this.Width);
                p.Dispose();
            }

            float tlw = 3f;
             float step_w = (this.Width-tlw) / 3f;
             float step_h = (this.Height-tlw) / 3f;

            for (int i = 0; i <= 3; i++)
            {
                Pen p = new Pen(this.ThickLineColor, tlw);
                e.Graphics.DrawRectangle(p, 0, (int)tlw / 2f+(int)i * step_h, this.Width, (int)tlw / 2f+(int)i * step_h);
                p.Dispose();
            }

            for (int i = 0; i <= 3; i++)
            {
                Pen p = new Pen(this.ThickLineColor, tlw);

                //p.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                //p.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
                e.Graphics.DrawRectangle(p, (int)tlw / 2f+(int)i * step_w, 0, (int)tlw / 2f+(int)i * step_w, this.Width);
                p.Dispose();
            }

            float scale = 0.5f * this.Width / 9f;

            if (this.juego != null)
            {
                for (int i = 0; i < juego.Celdas.Count; i++)
                {
                    SudokuCelda celda = juego.Celdas[i];
                    if (celda != null)
                    {
                        int v1 = celda.Value;
                       
                        Font ff = new System.Drawing.Font(this.Font.FontFamily, scale, this.Font.Style);
                        SizeF sz = e.Graphics.MeasureString(v1.ToString(), ff);
                        int px = (int)((celda.Column-1) * step_w1 + step_w1 / 2f - sz.Width / 2f);
                        int py = (int)((celda.Row-1) * step_h1 + step_h / 2f - sz.Height / 2f);

                        Point ppp = new Point(px, py);
                        Brush br7 = new SolidBrush(this.ForeColor);

                        e.Graphics.DrawString(v1.ToString(), ff, br7, ppp);
                        br7.Dispose();
                    }

                }

            }
        }

        private void SudokuControl_MouseClick(object sender, MouseEventArgs e)
        {
            float step_w = this.Width / 9f;
            float step_h = this.Height / 9f;

            int row = (int)(e.Y / step_h)+1;
            int col = (int)(e.X / step_w)+1;
            this.SelecedBox = new Point(col, row);
            this.Invalidate();

            this.ParentForm.Text = "(" + col.ToString() + " , " + row.ToString() + ")";
        }

        private void SudokuControl_KeyDown(object sender, KeyEventArgs e)
        {
            Keys test = Keys.D1 | Keys.D2 | Keys.D3 | Keys.D4 | Keys.D5 | Keys.D6 | Keys.D7 | Keys.D8 | Keys.D9
                | Keys.NumPad1 | Keys.NumPad2 | Keys.NumPad3 | Keys.NumPad4 | Keys.NumPad5 | Keys.NumPad6 
                | Keys.NumPad7 | Keys.NumPad8 | Keys.NumPad9;
                int num = 0;

            if (this.SelecedBox.X != 0 && this.SelecedBox.Y == 0)
            {
                if (e.KeyCode == test)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D1:
                            num = 1;
                            break;
                        case Keys.D2:
                            num = 2;
                            break;
                        case Keys.D3:
                            num = 3;
                            break;
                        case Keys.D4:
                            num = 4;
                            break;
                        case Keys.D5:
                            num = 5;
                            break;
                        case Keys.D6:
                            num = 6;
                            break;
                        case Keys.D7:
                            num = 7;
                            break;
                        case Keys.D8:
                            num = 8;
                            break;
                        case Keys.D9:
                            num = 9;
                            break;
                        case Keys.D0:
                            num = 0;
                            break;
                    }
                }

                if (juego != null && num > 0 && SelecedBox.X > 0 && SelecedBox.Y > 0)
                {
                    juego.SetValue(SelecedBox.X, SelecedBox.Y, num);
                    this.Invalidate(true);
                }
            }

        }
    }
}
