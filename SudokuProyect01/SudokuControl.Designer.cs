namespace SudokuProyect01
{
    partial class SudokuControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SudokuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SudokuControl";
            this.Size = new System.Drawing.Size(609, 452);
            this.SizeChanged += new System.EventHandler(this.SudokuControl_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SudokuControl_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SudokuControl_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SudokuControl_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
