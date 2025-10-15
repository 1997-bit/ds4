namespace Laboratorio122
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
            this.btnPromedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNota1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotaPromedio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(88, 133);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 0;
            this.btnPromedio.Text = "Pomedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota No.1";
            // 
            // tbNota1
            // 
            this.tbNota1.Location = new System.Drawing.Point(191, 37);
            this.tbNota1.Name = "tbNota1";
            this.tbNota1.Size = new System.Drawing.Size(149, 22);
            this.tbNota1.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 133);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbNota2
            // 
            this.tbNota2.Location = new System.Drawing.Point(191, 65);
            this.tbNota2.Name = "tbNota2";
            this.tbNota2.Size = new System.Drawing.Size(149, 22);
            this.tbNota2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota No.2";
            // 
            // tbNota3
            // 
            this.tbNota3.Location = new System.Drawing.Point(191, 105);
            this.tbNota3.Name = "tbNota3";
            this.tbNota3.Size = new System.Drawing.Size(149, 22);
            this.tbNota3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota No.3";
            // 
            // tbNotaPromedio
            // 
            this.tbNotaPromedio.Location = new System.Drawing.Point(210, 172);
            this.tbNotaPromedio.Name = "tbNotaPromedio";
            this.tbNotaPromedio.Size = new System.Drawing.Size(130, 22);
            this.tbNotaPromedio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.tbNotaPromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNota2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbNota1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromedio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNota1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotaPromedio;
        private System.Windows.Forms.Label label4;
    }
}

