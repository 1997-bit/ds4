namespace Laboratorio141
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
            this.tsbNuevo = new System.Windows.Forms.PictureBox();
            this.tsbGuardar = new System.Windows.Forms.PictureBox();
            this.tsbEliminar = new System.Windows.Forms.PictureBox();
            this.tsbCancelar = new System.Windows.Forms.PictureBox();
            this.tsbBuscar = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gfg = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dfsdf = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.fewr = new System.Windows.Forms.Label();
            this.rer = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtbusar = new System.Windows.Forms.Label();
            this.tstId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsbNuevo.Image = global::Laboratorio141.Properties.Resources.nuevo;
            this.tsbNuevo.Location = new System.Drawing.Point(14, 6);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(48, 48);
            this.tsbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbNuevo.TabIndex = 0;
            this.tsbNuevo.TabStop = false;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsbGuardar.Image = global::Laboratorio141.Properties.Resources.guardar;
            this.tsbGuardar.Location = new System.Drawing.Point(81, 6);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(48, 48);
            this.tsbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbGuardar.TabIndex = 1;
            this.tsbGuardar.TabStop = false;
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsbEliminar.Image = global::Laboratorio141.Properties.Resources.eliminar;
            this.tsbEliminar.Location = new System.Drawing.Point(215, 6);
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(48, 48);
            this.tsbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbEliminar.TabIndex = 2;
            this.tsbEliminar.TabStop = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsbCancelar.Image = global::Laboratorio141.Properties.Resources.cancelar;
            this.tsbCancelar.Location = new System.Drawing.Point(149, 6);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(48, 48);
            this.tsbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbCancelar.TabIndex = 3;
            this.tsbCancelar.TabStop = false;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsbBuscar.Image = global::Laboratorio141.Properties.Resources.buscar;
            this.tsbBuscar.Location = new System.Drawing.Point(568, 12);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(48, 48);
            this.tsbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tsbBuscar.TabIndex = 4;
            this.tsbBuscar.TabStop = false;
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(27, 193);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(159, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // gfg
            // 
            this.gfg.AutoSize = true;
            this.gfg.Location = new System.Drawing.Point(28, 173);
            this.gfg.Name = "gfg";
            this.gfg.Size = new System.Drawing.Size(46, 16);
            this.gfg.TabIndex = 6;
            this.gfg.Text = "Precio";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(27, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 65);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dfsdf
            // 
            this.dfsdf.AutoSize = true;
            this.dfsdf.Location = new System.Drawing.Point(241, 173);
            this.dfsdf.Name = "dfsdf";
            this.dfsdf.Size = new System.Drawing.Size(41, 16);
            this.dfsdf.TabIndex = 8;
            this.dfsdf.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(244, 192);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(159, 22);
            this.txtStock.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // fewr
            // 
            this.fewr.AutoSize = true;
            this.fewr.Location = new System.Drawing.Point(241, 89);
            this.fewr.Name = "fewr";
            this.fewr.Size = new System.Drawing.Size(56, 16);
            this.fewr.TabIndex = 11;
            this.fewr.Text = "Nombre";
            // 
            // rer
            // 
            this.rer.AutoSize = true;
            this.rer.Location = new System.Drawing.Point(24, 89);
            this.rer.Name = "rer";
            this.rer.Size = new System.Drawing.Size(18, 16);
            this.rer.TabIndex = 13;
            this.rer.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(27, 117);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(159, 22);
            this.txtId.TabIndex = 12;
            // 
            // txtbusar
            // 
            this.txtbusar.AutoSize = true;
            this.txtbusar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtbusar.Location = new System.Drawing.Point(286, 28);
            this.txtbusar.Name = "txtbusar";
            this.txtbusar.Size = new System.Drawing.Size(86, 16);
            this.txtbusar.TabIndex = 14;
            this.txtbusar.Text = "Buscar por Id";
            // 
            // tstId
            // 
            this.tstId.Location = new System.Drawing.Point(378, 28);
            this.tstId.Name = "tstId";
            this.tstId.Size = new System.Drawing.Size(159, 22);
            this.tstId.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tstId);
            this.Controls.Add(this.txtbusar);
            this.Controls.Add(this.rer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.fewr);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.dfsdf);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gfg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbEliminar);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.tsbNuevo);
            this.Name = "Form1";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tsbNuevo;
        private System.Windows.Forms.PictureBox tsbGuardar;
        private System.Windows.Forms.PictureBox tsbEliminar;
        private System.Windows.Forms.PictureBox tsbCancelar;
        private System.Windows.Forms.PictureBox tsbBuscar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label gfg;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label dfsdf;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label fewr;
        private System.Windows.Forms.Label rer;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label txtbusar;
        private System.Windows.Forms.TextBox tstId;
    }
}

