namespace Sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFacil = new System.Windows.Forms.Button();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.buttonDificll = new System.Windows.Forms.Button();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nuevo Juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // buttonFacil
            // 
            this.buttonFacil.Location = new System.Drawing.Point(303, 200);
            this.buttonFacil.Name = "buttonFacil";
            this.buttonFacil.Size = new System.Drawing.Size(180, 42);
            this.buttonFacil.TabIndex = 3;
            this.buttonFacil.Text = "Facil";
            this.buttonFacil.UseVisualStyleBackColor = true;
            this.buttonFacil.Visible = false;
            this.buttonFacil.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonMedia
            // 
            this.buttonMedia.Location = new System.Drawing.Point(303, 265);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(180, 42);
            this.buttonMedia.TabIndex = 4;
            this.buttonMedia.Text = "Media";
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonDificll
            // 
            this.buttonDificll.Location = new System.Drawing.Point(305, 331);
            this.buttonDificll.Name = "buttonDificll";
            this.buttonDificll.Size = new System.Drawing.Size(178, 42);
            this.buttonDificll.TabIndex = 5;
            this.buttonDificll.Text = "Dificil";
            this.buttonDificll.UseVisualStyleBackColor = true;
            this.buttonDificll.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDificultad.Location = new System.Drawing.Point(300, 169);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(133, 17);
            this.labelDificultad.TabIndex = 6;
            this.labelDificultad.Text = "Elegir Dificultad: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 149);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.buttonDificll);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.buttonFacil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonFacil;
		private System.Windows.Forms.Button buttonMedia;
		private System.Windows.Forms.Button buttonDificll;
		private System.Windows.Forms.Label labelDificultad;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

