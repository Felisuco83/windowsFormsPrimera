
namespace WindowsFormsApp1
{
    partial class Form12StringBuilder
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.lbltexto = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnreverse = new System.Windows.Forms.Button();
            this.btnreverseb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(25, 78);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(287, 183);
            this.txttexto.TabIndex = 0;
            this.txttexto.Text = "";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(22, 48);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(37, 13);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "Texto:";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.ForeColor = System.Drawing.Color.Red;
            this.lbltiempo.Location = new System.Drawing.Point(36, 307);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(0, 13);
            this.lbltiempo.TabIndex = 2;
            // 
            // btnreverse
            // 
            this.btnreverse.Location = new System.Drawing.Point(424, 78);
            this.btnreverse.Name = "btnreverse";
            this.btnreverse.Size = new System.Drawing.Size(98, 73);
            this.btnreverse.TabIndex = 3;
            this.btnreverse.Text = "Reverse String";
            this.btnreverse.UseVisualStyleBackColor = true;
            this.btnreverse.Click += new System.EventHandler(this.btnreverse_Click);
            // 
            // btnreverseb
            // 
            this.btnreverseb.Location = new System.Drawing.Point(424, 188);
            this.btnreverseb.Name = "btnreverseb";
            this.btnreverseb.Size = new System.Drawing.Size(98, 73);
            this.btnreverseb.TabIndex = 4;
            this.btnreverseb.Text = "Reverse StringBuilder";
            this.btnreverseb.UseVisualStyleBackColor = true;
            this.btnreverseb.Click += new System.EventHandler(this.btnreverseb_Click);
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreverseb);
            this.Controls.Add(this.btnreverse);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.txttexto);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnreverse;
        private System.Windows.Forms.Button btnreverseb;
    }
}