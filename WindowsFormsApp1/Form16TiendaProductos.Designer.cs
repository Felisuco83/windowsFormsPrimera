namespace WindowsFormsApp1
{
    partial class Form16TiendaProductos
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
            this.lblproducto = new System.Windows.Forms.Label();
            this.lbltienda = new System.Windows.Forms.Label();
            this.lblalmacen = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.lsttienda = new System.Windows.Forms.ListBox();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.lstalmacen = new System.Windows.Forms.ListBox();
            this.btnbajar = new System.Windows.Forms.Button();
            this.btnsubir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(51, 30);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(50, 13);
            this.lblproducto.TabIndex = 0;
            this.lblproducto.Text = "Producto";
            // 
            // lbltienda
            // 
            this.lbltienda.AutoSize = true;
            this.lbltienda.Location = new System.Drawing.Point(212, 47);
            this.lbltienda.Name = "lbltienda";
            this.lbltienda.Size = new System.Drawing.Size(40, 13);
            this.lbltienda.TabIndex = 1;
            this.lbltienda.Text = "Tienda";
            // 
            // lblalmacen
            // 
            this.lblalmacen.AutoSize = true;
            this.lblalmacen.Location = new System.Drawing.Point(497, 47);
            this.lblalmacen.Name = "lblalmacen";
            this.lblalmacen.Size = new System.Drawing.Size(48, 13);
            this.lblalmacen.TabIndex = 2;
            this.lblalmacen.Text = "Almacen";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(50, 59);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 20);
            this.txtproducto.TabIndex = 3;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(54, 98);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(96, 36);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(54, 152);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(96, 36);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(54, 205);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(96, 36);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(54, 259);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(96, 36);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // lsttienda
            // 
            this.lsttienda.FormattingEnabled = true;
            this.lsttienda.Location = new System.Drawing.Point(215, 75);
            this.lsttienda.Name = "lsttienda";
            this.lsttienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsttienda.Size = new System.Drawing.Size(149, 225);
            this.lsttienda.TabIndex = 8;
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(382, 129);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(96, 36);
            this.btnseleccion.TabIndex = 10;
            this.btnseleccion.Text = "Selección";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(382, 75);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(96, 36);
            this.btntodos.TabIndex = 9;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // lstalmacen
            // 
            this.lstalmacen.FormattingEnabled = true;
            this.lstalmacen.Location = new System.Drawing.Point(500, 75);
            this.lstalmacen.Name = "lstalmacen";
            this.lstalmacen.Size = new System.Drawing.Size(149, 225);
            this.lstalmacen.TabIndex = 11;
            // 
            // btnbajar
            // 
            this.btnbajar.Location = new System.Drawing.Point(666, 129);
            this.btnbajar.Name = "btnbajar";
            this.btnbajar.Size = new System.Drawing.Size(96, 36);
            this.btnbajar.TabIndex = 13;
            this.btnbajar.Text = "Bajar";
            this.btnbajar.UseVisualStyleBackColor = true;
            this.btnbajar.Click += new System.EventHandler(this.btnbajar_Click);
            // 
            // btnsubir
            // 
            this.btnsubir.Location = new System.Drawing.Point(666, 75);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(96, 36);
            this.btnsubir.TabIndex = 12;
            this.btnsubir.Text = "Subir";
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // Form16TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbajar);
            this.Controls.Add(this.btnsubir);
            this.Controls.Add(this.lstalmacen);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.lsttienda);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.lblalmacen);
            this.Controls.Add(this.lbltienda);
            this.Controls.Add(this.lblproducto);
            this.Name = "Form16TiendaProductos";
            this.Text = "Form16TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lbltienda;
        private System.Windows.Forms.Label lblalmacen;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ListBox lsttienda;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.ListBox lstalmacen;
        private System.Windows.Forms.Button btnbajar;
        private System.Windows.Forms.Button btnsubir;
    }
}