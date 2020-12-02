namespace WindowsFormsApp1
{
    partial class FormFicheroProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.lblcontadorproductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(24, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(24, 99);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(174, 38);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(97, 61);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insertar producto";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(174, 105);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(97, 61);
            this.btnread.TabIndex = 5;
            this.btnread.Text = "Leer productos";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(174, 172);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 61);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Guardar productos";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Productos";
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.Location = new System.Drawing.Point(339, 71);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(148, 160);
            this.lstproductos.TabIndex = 8;
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(33, 273);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(91, 35);
            this.btnfirst.TabIndex = 9;
            this.btnfirst.Text = "Primero";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(147, 273);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(91, 35);
            this.btnprev.TabIndex = 10;
            this.btnprev.Text = "Anterior";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(257, 273);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(91, 35);
            this.btnnext.TabIndex = 11;
            this.btnnext.Text = "Siguiente";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(372, 273);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(91, 35);
            this.btnlast.TabIndex = 12;
            this.btnlast.Text = "Ultimo";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // lblcontadorproductos
            // 
            this.lblcontadorproductos.AutoSize = true;
            this.lblcontadorproductos.ForeColor = System.Drawing.Color.Red;
            this.lblcontadorproductos.Location = new System.Drawing.Point(29, 343);
            this.lblcontadorproductos.Name = "lblcontadorproductos";
            this.lblcontadorproductos.Size = new System.Drawing.Size(83, 13);
            this.lblcontadorproductos.TabIndex = 13;
            this.lblcontadorproductos.Text = "Producto 1 de 5";
            // 
            // FormFicheroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcontadorproductos);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "FormFicheroProductos";
            this.Text = "FormFicheroProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Label lblcontadorproductos;
    }
}