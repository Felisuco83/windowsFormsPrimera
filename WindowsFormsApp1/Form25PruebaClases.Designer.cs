﻿namespace WindowsFormsApp1
{
    partial class Form25PruebaClases
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
            this.lstdatos = new System.Windows.Forms.ListBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstdatos
            // 
            this.lstdatos.FormattingEnabled = true;
            this.lstdatos.Location = new System.Drawing.Point(68, 69);
            this.lstdatos.Name = "lstdatos";
            this.lstdatos.Size = new System.Drawing.Size(225, 134);
            this.lstdatos.TabIndex = 0;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Location = new System.Drawing.Point(65, 39);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(35, 13);
            this.lbldatos.TabIndex = 1;
            this.lbldatos.Text = "Datos";
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(318, 87);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(87, 59);
            this.btncrear.TabIndex = 2;
            this.btncrear.Text = "Crear personas";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form25PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.lstdatos);
            this.Name = "Form25PruebaClases";
            this.Text = "Form24PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstdatos;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button button1;
    }
}