namespace Laboratorio123
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSemiperimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.tbLadoA = new System.Windows.Forms.TextBox();
            this.tbLadoB = new System.Windows.Forms.TextBox();
            this.tbLadoC = new System.Windows.Forms.TextBox();
            this.tbSemiperimetro = new System.Windows.Forms.TextBox();
            this.tbAeraTriangulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresa la longitud del lado A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingresa la longitud del lado B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(414, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Calculo Semiperimetro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ingresa la longitud del lado C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(414, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Area del Triangulo";
            // 
            // btnSemiperimetro
            // 
            this.btnSemiperimetro.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemiperimetro.Location = new System.Drawing.Point(417, 243);
            this.btnSemiperimetro.Name = "btnSemiperimetro";
            this.btnSemiperimetro.Size = new System.Drawing.Size(112, 44);
            this.btnSemiperimetro.TabIndex = 5;
            this.btnSemiperimetro.Text = "Semiperimetro";
            this.btnSemiperimetro.UseVisualStyleBackColor = true;
            this.btnSemiperimetro.Click += new System.EventHandler(this.btnSemiperimetro_Click);
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(535, 243);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(96, 44);
            this.btnArea.TabIndex = 6;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(637, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(739, 243);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(96, 44);
            this.btnSalida.TabIndex = 8;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            // 
            // tbLadoA
            // 
            this.tbLadoA.Location = new System.Drawing.Point(587, 113);
            this.tbLadoA.Name = "tbLadoA";
            this.tbLadoA.Size = new System.Drawing.Size(248, 22);
            this.tbLadoA.TabIndex = 9;
            // 
            // tbLadoB
            // 
            this.tbLadoB.Location = new System.Drawing.Point(587, 149);
            this.tbLadoB.Name = "tbLadoB";
            this.tbLadoB.Size = new System.Drawing.Size(248, 22);
            this.tbLadoB.TabIndex = 10;
            this.tbLadoB.TextChanged += new System.EventHandler(this.tbLadoB_TextChanged);
            // 
            // tbLadoC
            // 
            this.tbLadoC.Location = new System.Drawing.Point(587, 188);
            this.tbLadoC.Name = "tbLadoC";
            this.tbLadoC.Size = new System.Drawing.Size(248, 22);
            this.tbLadoC.TabIndex = 11;
            this.tbLadoC.TextChanged += new System.EventHandler(this.tbLadoC_TextChanged);
            // 
            // tbSemiperimetro
            // 
            this.tbSemiperimetro.Location = new System.Drawing.Point(587, 303);
            this.tbSemiperimetro.Name = "tbSemiperimetro";
            this.tbSemiperimetro.Size = new System.Drawing.Size(248, 22);
            this.tbSemiperimetro.TabIndex = 12;
            // 
            // tbAeraTriangulo
            // 
            this.tbAeraTriangulo.Location = new System.Drawing.Point(587, 339);
            this.tbAeraTriangulo.Name = "tbAeraTriangulo";
            this.tbAeraTriangulo.Size = new System.Drawing.Size(248, 22);
            this.tbAeraTriangulo.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1206, 526);
            this.Controls.Add(this.tbAeraTriangulo);
            this.Controls.Add(this.tbSemiperimetro);
            this.Controls.Add(this.tbLadoC);
            this.Controls.Add(this.tbLadoB);
            this.Controls.Add(this.tbLadoA);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSemiperimetro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSemiperimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.TextBox tbLadoA;
        private System.Windows.Forms.TextBox tbLadoB;
        private System.Windows.Forms.TextBox tbLadoC;
        private System.Windows.Forms.TextBox tbSemiperimetro;
        private System.Windows.Forms.TextBox tbAeraTriangulo;
    }
}

