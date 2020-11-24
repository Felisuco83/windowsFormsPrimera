namespace WindowsFormsApp1
{
    partial class Form06CalcularDia
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
            this.lbldia = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(133, 61);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(31, 13);
            this.lbldia.TabIndex = 0;
            this.lbldia.Text = "Día: ";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Location = new System.Drawing.Point(136, 110);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(33, 13);
            this.lblmes.TabIndex = 1;
            this.lblmes.Text = "Mes: ";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Location = new System.Drawing.Point(139, 151);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(32, 13);
            this.lblanio.TabIndex = 2;
            this.lblanio.Text = "Año: ";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(223, 61);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(223, 110);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 4;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(223, 151);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(100, 20);
            this.txtanio.TabIndex = 5;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(364, 224);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(399, 110);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(89, 31);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular Día";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form06CalcularDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.lblmes);
            this.Controls.Add(this.lbldia);
            this.Name = "Form06CalcularDia";
            this.Text = "Form06CalcularDia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}