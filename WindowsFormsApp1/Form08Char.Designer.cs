namespace WindowsFormsApp1
{
    partial class Form08Char
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
            this.lblLetras = new System.Windows.Forms.Label();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.lblnumeros = new System.Windows.Forms.Label();
            this.txtsimbolos = new System.Windows.Forms.TextBox();
            this.lblsimbolos = new System.Windows.Forms.Label();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.lblpuntuacion = new System.Windows.Forms.Label();
            this.btnrecorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Location = new System.Drawing.Point(18, 13);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(39, 13);
            this.lblLetras.TabIndex = 0;
            this.lblLetras.Text = "Letras:";
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(21, 39);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(204, 145);
            this.txtletras.TabIndex = 1;
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(21, 254);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(204, 145);
            this.txtnumeros.TabIndex = 3;
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Location = new System.Drawing.Point(18, 228);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(52, 13);
            this.lblnumeros.TabIndex = 2;
            this.lblnumeros.Text = "Numeros:";
            // 
            // txtsimbolos
            // 
            this.txtsimbolos.Location = new System.Drawing.Point(297, 39);
            this.txtsimbolos.Multiline = true;
            this.txtsimbolos.Name = "txtsimbolos";
            this.txtsimbolos.Size = new System.Drawing.Size(204, 145);
            this.txtsimbolos.TabIndex = 5;
            // 
            // lblsimbolos
            // 
            this.lblsimbolos.AutoSize = true;
            this.lblsimbolos.Location = new System.Drawing.Point(294, 13);
            this.lblsimbolos.Name = "lblsimbolos";
            this.lblsimbolos.Size = new System.Drawing.Size(52, 13);
            this.lblsimbolos.TabIndex = 4;
            this.lblsimbolos.Text = "Simbolos:";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Location = new System.Drawing.Point(297, 254);
            this.txtpuntuacion.Multiline = true;
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(204, 145);
            this.txtpuntuacion.TabIndex = 7;
            // 
            // lblpuntuacion
            // 
            this.lblpuntuacion.AutoSize = true;
            this.lblpuntuacion.Location = new System.Drawing.Point(294, 228);
            this.lblpuntuacion.Name = "lblpuntuacion";
            this.lblpuntuacion.Size = new System.Drawing.Size(64, 13);
            this.lblpuntuacion.TabIndex = 6;
            this.lblpuntuacion.Text = "Puntuación:";
            // 
            // btnrecorrer
            // 
            this.btnrecorrer.Location = new System.Drawing.Point(597, 182);
            this.btnrecorrer.Name = "btnrecorrer";
            this.btnrecorrer.Size = new System.Drawing.Size(113, 82);
            this.btnrecorrer.TabIndex = 8;
            this.btnrecorrer.Text = "Recorrer ASCII";
            this.btnrecorrer.UseVisualStyleBackColor = true;
            this.btnrecorrer.Click += new System.EventHandler(this.btnrecorrer_Click);
            // 
            // Form08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrecorrer);
            this.Controls.Add(this.txtpuntuacion);
            this.Controls.Add(this.lblpuntuacion);
            this.Controls.Add(this.txtsimbolos);
            this.Controls.Add(this.lblsimbolos);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.lblnumeros);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.lblLetras);
            this.Name = "Form08Char";
            this.Text = "Form08Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.TextBox txtsimbolos;
        private System.Windows.Forms.Label lblsimbolos;
        private System.Windows.Forms.TextBox txtpuntuacion;
        private System.Windows.Forms.Label lblpuntuacion;
        private System.Windows.Forms.Button btnrecorrer;
    }
}