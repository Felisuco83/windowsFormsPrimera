namespace WindowsFormsApp1
{
    partial class Form17MetodoReferencia
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnllamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(94, 57);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(44, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Numero";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(193, 57);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(97, 228);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(60, 13);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "lblresultado";
            // 
            // btnllamada
            // 
            this.btnllamada.Location = new System.Drawing.Point(193, 144);
            this.btnllamada.Name = "btnllamada";
            this.btnllamada.Size = new System.Drawing.Size(100, 45);
            this.btnllamada.TabIndex = 3;
            this.btnllamada.Text = "Llamada";
            this.btnllamada.UseVisualStyleBackColor = true;
            this.btnllamada.Click += new System.EventHandler(this.btnllamada_Click);
            // 
            // Form17MetodoReferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnllamada);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Name = "Form17MetodoReferencia";
            this.Text = "Form16MetodoReferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnllamada;
    }
}