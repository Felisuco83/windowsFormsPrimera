
namespace WindowsFormsApp1
{
    partial class Form10SumarNumerosString
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
            this.lblnumeros = new System.Windows.Forms.Label();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.lblsuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Location = new System.Drawing.Point(219, 96);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(49, 13);
            this.lblnumeros.TabIndex = 0;
            this.lblnumeros.Text = "Numeros";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(312, 96);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(219, 20);
            this.txtnumeros.TabIndex = 1;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(312, 154);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(147, 45);
            this.btnsumar.TabIndex = 2;
            this.btnsumar.Text = "Sumar números";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.ForeColor = System.Drawing.Color.Blue;
            this.lblsuma.Location = new System.Drawing.Point(312, 230);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(0, 13);
            this.lblsuma.TabIndex = 3;
            // 
            // Form10SumarNumerosString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.lblnumeros);
            this.Name = "Form10SumarNumerosString";
            this.Text = "Form10SumarNumerosString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label lblsuma;
    }
}