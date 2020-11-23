
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnpulsar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnpulsar
            // 
            this.btnpulsar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnpulsar.Location = new System.Drawing.Point(131, 128);
            this.btnpulsar.Name = "btnpulsar";
            this.btnpulsar.Size = new System.Drawing.Size(75, 23);
            this.btnpulsar.TabIndex = 0;
            this.btnpulsar.Text = "Pulsar";
            this.btnpulsar.UseVisualStyleBackColor = false;
            this.btnpulsar.Click += new System.EventHandler(this.btnpulsar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtcaja
            // 
            this.txtcaja.Location = new System.Drawing.Point(116, 79);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(100, 20);
            this.txtcaja.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpulsar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpulsar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcaja;
    }
}

