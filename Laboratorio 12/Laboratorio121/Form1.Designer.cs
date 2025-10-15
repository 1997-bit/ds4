namespace Laboratorio121
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.tbVelocidad = new System.Windows.Forms.TextBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTiempo
            // 
            this.tbTiempo.Location = new System.Drawing.Point(174, 85);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.Size = new System.Drawing.Size(100, 22);
            this.tbTiempo.TabIndex = 0;
            this.tbTiempo.TextChanged += new System.EventHandler(this.tbTiempo_TextChanged);
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.Location = new System.Drawing.Point(174, 121);
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(100, 22);
            this.tbVelocidad.TabIndex = 1;
            this.tbVelocidad.TextChanged += new System.EventHandler(this.tbVelocidad_TextChanged);
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(174, 209);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(100, 22);
            this.tbDistancia.TabIndex = 2;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(41, 91);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(52, 16);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(96, 215);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(63, 16);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.Text = "Distancia";
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(41, 127);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(67, 16);
            this.labelVelocidad.TabIndex = 5;
            this.labelVelocidad.Text = "Velocidad";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(84, 167);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(174, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(120, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(138, 16);
            this.labelTitulo.TabIndex = 9;
            this.labelTitulo.Text = "Velocidad de un móvil";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(351, 274);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.tbVelocidad);
            this.Controls.Add(this.tbTiempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.TextBox tbVelocidad;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}
