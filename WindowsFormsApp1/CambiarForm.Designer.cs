
namespace WindowsFormsApp1
{
    partial class CambiarForm
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
            this.lblposx = new System.Windows.Forms.Label();
            this.lblposy = new System.Windows.Forms.Label();
            this.txtposx = new System.Windows.Forms.TextBox();
            this.txtposy = new System.Windows.Forms.TextBox();
            this.btnpos = new System.Windows.Forms.Button();
            this.lblrojo = new System.Windows.Forms.Label();
            this.lblverde = new System.Windows.Forms.Label();
            this.lblazul = new System.Windows.Forms.Label();
            this.txtrojo = new System.Windows.Forms.TextBox();
            this.txtverde = new System.Windows.Forms.TextBox();
            this.txtazul = new System.Windows.Forms.TextBox();
            this.btncolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblposx
            // 
            this.lblposx.AutoSize = true;
            this.lblposx.Location = new System.Drawing.Point(104, 57);
            this.lblposx.Name = "lblposx";
            this.lblposx.Size = new System.Drawing.Size(60, 13);
            this.lblposx.TabIndex = 0;
            this.lblposx.Text = "Posicion X:";
            // 
            // lblposy
            // 
            this.lblposy.AutoSize = true;
            this.lblposy.Location = new System.Drawing.Point(107, 109);
            this.lblposy.Name = "lblposy";
            this.lblposy.Size = new System.Drawing.Size(60, 13);
            this.lblposy.TabIndex = 1;
            this.lblposy.Text = "Posicion Y:";
            // 
            // txtposx
            // 
            this.txtposx.Location = new System.Drawing.Point(181, 57);
            this.txtposx.Name = "txtposx";
            this.txtposx.Size = new System.Drawing.Size(100, 20);
            this.txtposx.TabIndex = 2;
            // 
            // txtposy
            // 
            this.txtposy.Location = new System.Drawing.Point(181, 109);
            this.txtposy.Name = "txtposy";
            this.txtposy.Size = new System.Drawing.Size(100, 20);
            this.txtposy.TabIndex = 3;
            // 
            // btnpos
            // 
            this.btnpos.Location = new System.Drawing.Point(251, 191);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(75, 23);
            this.btnpos.TabIndex = 4;
            this.btnpos.Text = "Posicion";
            this.btnpos.UseVisualStyleBackColor = true;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // lblrojo
            // 
            this.lblrojo.AutoSize = true;
            this.lblrojo.Location = new System.Drawing.Point(421, 57);
            this.lblrojo.Name = "lblrojo";
            this.lblrojo.Size = new System.Drawing.Size(32, 13);
            this.lblrojo.TabIndex = 5;
            this.lblrojo.Text = "Rojo:";
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.Location = new System.Drawing.Point(424, 82);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(35, 13);
            this.lblverde.TabIndex = 6;
            this.lblverde.Text = "Verde";
            // 
            // lblazul
            // 
            this.lblazul.AutoSize = true;
            this.lblazul.Location = new System.Drawing.Point(424, 115);
            this.lblazul.Name = "lblazul";
            this.lblazul.Size = new System.Drawing.Size(33, 13);
            this.lblazul.TabIndex = 7;
            this.lblazul.Text = "Azul: ";
            // 
            // txtrojo
            // 
            this.txtrojo.Location = new System.Drawing.Point(534, 56);
            this.txtrojo.Name = "txtrojo";
            this.txtrojo.Size = new System.Drawing.Size(100, 20);
            this.txtrojo.TabIndex = 8;
            // 
            // txtverde
            // 
            this.txtverde.Location = new System.Drawing.Point(534, 82);
            this.txtverde.Name = "txtverde";
            this.txtverde.Size = new System.Drawing.Size(100, 20);
            this.txtverde.TabIndex = 9;
            // 
            // txtazul
            // 
            this.txtazul.Location = new System.Drawing.Point(534, 116);
            this.txtazul.Name = "txtazul";
            this.txtazul.Size = new System.Drawing.Size(100, 20);
            this.txtazul.TabIndex = 10;
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(484, 190);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 23);
            this.btncolor.TabIndex = 11;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.Color_Click);
            // 
            // CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.txtazul);
            this.Controls.Add(this.txtverde);
            this.Controls.Add(this.txtrojo);
            this.Controls.Add(this.lblazul);
            this.Controls.Add(this.lblverde);
            this.Controls.Add(this.lblrojo);
            this.Controls.Add(this.btnpos);
            this.Controls.Add(this.txtposy);
            this.Controls.Add(this.txtposx);
            this.Controls.Add(this.lblposy);
            this.Controls.Add(this.lblposx);
            this.Name = "CambiarForm";
            this.Text = "CambiarForm";
            this.Load += new System.EventHandler(this.CambiarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblposx;
        private System.Windows.Forms.Label lblposy;
        private System.Windows.Forms.TextBox txtposx;
        private System.Windows.Forms.TextBox txtposy;
        private System.Windows.Forms.Button btnpos;
        private System.Windows.Forms.Label lblrojo;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Label lblazul;
        private System.Windows.Forms.TextBox txtrojo;
        private System.Windows.Forms.TextBox txtverde;
        private System.Windows.Forms.TextBox txtazul;
        private System.Windows.Forms.Button btncolor;
    }
}