namespace WindowsFormsApp1
{
    partial class Form22TemperaturasAnuales
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
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.lblmeses = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lbltempmax = new System.Windows.Forms.Label();
            this.txttempmax = new System.Windows.Forms.TextBox();
            this.lbltmpmin = new System.Windows.Forms.Label();
            this.txttempmin = new System.Windows.Forms.TextBox();
            this.txttempmed = new System.Windows.Forms.TextBox();
            this.lbltempmed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.Location = new System.Drawing.Point(42, 71);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(160, 186);
            this.lstmeses.TabIndex = 0;
            // 
            // lblmeses
            // 
            this.lblmeses.AutoSize = true;
            this.lblmeses.Location = new System.Drawing.Point(42, 39);
            this.lblmeses.Name = "lblmeses";
            this.lblmeses.Size = new System.Drawing.Size(38, 13);
            this.lblmeses.TabIndex = 1;
            this.lblmeses.Text = "Meses";
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(274, 71);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(75, 23);
            this.btngenerate.TabIndex = 2;
            this.btngenerate.Text = "Generar Meses";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(274, 113);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar datos";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lbltempmax
            // 
            this.lbltempmax.AutoSize = true;
            this.lbltempmax.Location = new System.Drawing.Point(274, 161);
            this.lbltempmax.Name = "lbltempmax";
            this.lbltempmax.Size = new System.Drawing.Size(105, 13);
            this.lbltempmax.TabIndex = 4;
            this.lbltempmax.Text = "Temperatura máxima";
            // 
            // txttempmax
            // 
            this.txttempmax.AcceptsReturn = true;
            this.txttempmax.Location = new System.Drawing.Point(277, 187);
            this.txttempmax.Name = "txttempmax";
            this.txttempmax.Size = new System.Drawing.Size(100, 20);
            this.txttempmax.TabIndex = 5;
            // 
            // lbltmpmin
            // 
            this.lbltmpmin.AutoSize = true;
            this.lbltmpmin.Location = new System.Drawing.Point(274, 220);
            this.lbltmpmin.Name = "lbltmpmin";
            this.lbltmpmin.Size = new System.Drawing.Size(104, 13);
            this.lbltmpmin.TabIndex = 6;
            this.lbltmpmin.Text = "Temperatura mínima";
            // 
            // txttempmin
            // 
            this.txttempmin.Location = new System.Drawing.Point(277, 245);
            this.txttempmin.Name = "txttempmin";
            this.txttempmin.Size = new System.Drawing.Size(100, 20);
            this.txttempmin.TabIndex = 7;
            // 
            // txttempmed
            // 
            this.txttempmed.Location = new System.Drawing.Point(277, 308);
            this.txttempmed.Name = "txttempmed";
            this.txttempmed.Size = new System.Drawing.Size(100, 20);
            this.txttempmed.TabIndex = 9;
            // 
            // lbltempmed
            // 
            this.lbltempmed.AutoSize = true;
            this.lbltempmed.Location = new System.Drawing.Point(274, 283);
            this.lbltempmed.Name = "lbltempmed";
            this.lbltempmed.Size = new System.Drawing.Size(98, 13);
            this.lbltempmed.TabIndex = 8;
            this.lbltempmed.Text = "Temperatura media";
            // 
            // Form22TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttempmed);
            this.Controls.Add(this.lbltempmed);
            this.Controls.Add(this.txttempmin);
            this.Controls.Add(this.lbltmpmin);
            this.Controls.Add(this.txttempmax);
            this.Controls.Add(this.lbltempmax);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.lblmeses);
            this.Controls.Add(this.lstmeses);
            this.Name = "Form22TemperaturasAnuales";
            this.Text = "Form22TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Label lblmeses;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lbltempmax;
        private System.Windows.Forms.TextBox txttempmax;
        private System.Windows.Forms.Label lbltmpmin;
        private System.Windows.Forms.TextBox txttempmin;
        private System.Windows.Forms.TextBox txttempmed;
        private System.Windows.Forms.Label lbltempmed;
    }
}