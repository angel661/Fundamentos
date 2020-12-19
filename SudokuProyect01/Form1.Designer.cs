namespace SudokuProyect01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.sudokuControl1 = new SudokuProyect01.SudokuControl();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "validar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sudokuControl1
            // 
            this.sudokuControl1.BackColor = System.Drawing.SystemColors.Control;
            this.sudokuControl1.DefaultColor = System.Drawing.Color.White;
            this.sudokuControl1.ErrorColor = System.Drawing.Color.OrangeRed;
            this.sudokuControl1.Juego = null;
            this.sudokuControl1.LineColor = System.Drawing.Color.LightGray;
            this.sudokuControl1.Location = new System.Drawing.Point(38, 12);
            this.sudokuControl1.Name = "sudokuControl1";
            this.sudokuControl1.SelecedBox = new System.Drawing.Point(0, 0);
            this.sudokuControl1.SelectedColor = System.Drawing.Color.LimeGreen;
            this.sudokuControl1.Size = new System.Drawing.Size(542, 542);
            this.sudokuControl1.TabIndex = 0;
            this.sudokuControl1.ThickLineColor = System.Drawing.Color.Black;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "inicio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sudokuControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.TextChanged += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SudokuControl sudokuControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

