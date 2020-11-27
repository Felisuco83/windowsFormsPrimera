namespace WindowsFormsApp1
{
    partial class Form17MetodosEvento
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
            this.txtletras = new System.Windows.Forms.TextBox();
            this.lblletras = new System.Windows.Forms.Label();
            this.lblraton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Location = new System.Drawing.Point(89, 48);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(74, 13);
            this.lblnumeros.TabIndex = 0;
            this.lblnumeros.Text = "Solo números:";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(205, 48);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(100, 20);
            this.txtnumeros.TabIndex = 1;
            this.txtnumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeros_KeyPress);
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(205, 96);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(100, 20);
            this.txtletras.TabIndex = 3;
            this.txtletras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtletras_KeyPress);
            // 
            // lblletras
            // 
            this.lblletras.AutoSize = true;
            this.lblletras.Location = new System.Drawing.Point(89, 96);
            this.lblletras.Name = "lblletras";
            this.lblletras.Size = new System.Drawing.Size(56, 13);
            this.lblletras.TabIndex = 2;
            this.lblletras.Text = "Sólo letras";
            // 
            // lblraton
            // 
            this.lblraton.BackColor = System.Drawing.Color.PeachPuff;
            this.lblraton.Location = new System.Drawing.Point(145, 153);
            this.lblraton.Name = "lblraton";
            this.lblraton.Size = new System.Drawing.Size(449, 229);
            this.lblraton.TabIndex = 4;
            this.lblraton.Text = "label1";
            this.lblraton.MouseHover += new System.EventHandler(this.lblraton_MouseHover);
            this.lblraton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblraton_MouseMove);
            // 
            // Form17MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblraton);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.lblletras);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.lblnumeros);
            this.Name = "Form17MetodosEvento";
            this.Text = "Form17MetodosEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.Label lblletras;
        private System.Windows.Forms.Label lblraton;
    }
}