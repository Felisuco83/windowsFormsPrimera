
namespace WindowsFormsApp1
{
    partial class Form28SerializarColecciones
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
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.Location = new System.Drawing.Point(377, 103);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(148, 160);
            this.lstproductos.TabIndex = 17;
            this.lstproductos.SelectedIndexChanged += new System.EventHandler(this.lstproductos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Productos";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(212, 204);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 61);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Guardar productos";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(212, 137);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(97, 61);
            this.btnread.TabIndex = 14;
            this.btnread.Text = "Leer productos";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(212, 70);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(97, 61);
            this.btninsert.TabIndex = 13;
            this.btninsert.Text = "Insertar producto";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(62, 131);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(62, 70);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Form28SerializarColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form28SerializarColecciones";
            this.Text = "Form28SerializarColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
    }
}