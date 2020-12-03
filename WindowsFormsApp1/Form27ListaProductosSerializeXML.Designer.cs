
namespace WindowsFormsApp1
{
    partial class Form27ListaProductosSerializeXML
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
            this.btnread = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(320, 166);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(97, 61);
            this.btnread.TabIndex = 18;
            this.btnread.Text = "Leer productos";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(320, 99);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(97, 61);
            this.btninsert.TabIndex = 17;
            this.btninsert.Text = "Insertar producto";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(170, 160);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(170, 99);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(106, 250);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 13);
            this.lblinfo.TabIndex = 20;
            // 
            // Form27ListaProductosSerializeXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form27ListaProductosSerializeXML";
            this.Text = "Form27ListaProductosSerializeXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinfo;
    }
}