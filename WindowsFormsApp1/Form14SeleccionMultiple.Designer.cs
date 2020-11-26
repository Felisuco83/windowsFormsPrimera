namespace WindowsFormsApp1
{
    partial class Form14SeleccionMultiple
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
            this.lblseleccionados = new System.Windows.Forms.Label();
            this.lblindices = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.lblelemento = new System.Windows.Forms.Label();
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.lblelementos = new System.Windows.Forms.Label();
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblseleccionados
            // 
            this.lblseleccionados.AutoSize = true;
            this.lblseleccionados.Location = new System.Drawing.Point(54, 391);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(80, 13);
            this.lblseleccionados.TabIndex = 19;
            this.lblseleccionados.Text = "lblseleccionado";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.Location = new System.Drawing.Point(54, 357);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(56, 13);
            this.lblindices.TabIndex = 18;
            this.lblindices.Text = "lblposicion";
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(327, 250);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 32);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(327, 133);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(157, 32);
            this.btninsertar.TabIndex = 14;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(327, 68);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(169, 20);
            this.txtelemento.TabIndex = 13;
            // 
            // lblelemento
            // 
            this.lblelemento.AutoSize = true;
            this.lblelemento.Location = new System.Drawing.Point(324, 29);
            this.lblelemento.Name = "lblelemento";
            this.lblelemento.Size = new System.Drawing.Size(51, 13);
            this.lblelemento.TabIndex = 12;
            this.lblelemento.Text = "Elemento";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.Location = new System.Drawing.Point(54, 68);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.Size = new System.Drawing.Size(152, 251);
            this.lstelementos.TabIndex = 11;
            // 
            // lblelementos
            // 
            this.lblelementos.AutoSize = true;
            this.lblelementos.Location = new System.Drawing.Point(51, 29);
            this.lblelementos.Name = "lblelementos";
            this.lblelementos.Size = new System.Drawing.Size(56, 13);
            this.lblelementos.TabIndex = 10;
            this.lblelementos.Text = "Elementos";
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.ForeColor = System.Drawing.Color.Black;
            this.btnseleccionados.Location = new System.Drawing.Point(327, 195);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(157, 32);
            this.btnseleccionados.TabIndex = 20;
            this.btnseleccionados.Text = "Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // Form14SeleccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.lblseleccionados);
            this.Controls.Add(this.lblindices);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lblelemento);
            this.Controls.Add(this.lstelementos);
            this.Controls.Add(this.lblelementos);
            this.Name = "Form14SeleccionMultiple";
            this.Text = "Form14SeleccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblseleccionados;
        private System.Windows.Forms.Label lblindices;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Label lblelemento;
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label lblelementos;
        private System.Windows.Forms.Button btnseleccionados;
    }
}