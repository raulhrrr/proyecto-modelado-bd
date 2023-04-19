namespace ClientesProveedores
{
    partial class AnadirProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirProducto));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btgGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(139, 71);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(371, 20);
            this.txtPrecioU.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio U.";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(139, 121);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(371, 20);
            this.txtCantidad.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(152, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 38);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btgGuardar
            // 
            this.btgGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.btgGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btgGuardar.Location = new System.Drawing.Point(277, 156);
            this.btgGuardar.Name = "btgGuardar";
            this.btgGuardar.Size = new System.Drawing.Size(119, 38);
            this.btgGuardar.TabIndex = 28;
            this.btgGuardar.Text = "Guardar";
            this.btgGuardar.UseVisualStyleBackColor = false;
            this.btgGuardar.Click += new System.EventHandler(this.btgGuardar_Click);
            // 
            // AnadirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btgGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirProducto";
            this.Text = "Añadir Producto";
            this.Load += new System.EventHandler(this.AnadirProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btgGuardar;
    }
}