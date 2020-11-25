
namespace WindowsFormsApp1
{
    partial class Form09ValidarMail
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnvalidaremail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(110, 108);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.lblmensaje.Location = new System.Drawing.Point(196, 278);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 13);
            this.lblmensaje.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(212, 108);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(172, 20);
            this.txtemail.TabIndex = 2;
            // 
            // btnvalidaremail
            // 
            this.btnvalidaremail.Location = new System.Drawing.Point(249, 183);
            this.btnvalidaremail.Name = "btnvalidaremail";
            this.btnvalidaremail.Size = new System.Drawing.Size(164, 23);
            this.btnvalidaremail.TabIndex = 3;
            this.btnvalidaremail.Text = "Comprobar email";
            this.btnvalidaremail.UseVisualStyleBackColor = true;
            this.btnvalidaremail.Click += new System.EventHandler(this.btnvalidaremail_Click);
            // 
            // Form09ValidarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvalidaremail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblemail);
            this.Name = "Form09ValidarMail";
            this.Text = "Form09ValidarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnvalidaremail;
    }
}