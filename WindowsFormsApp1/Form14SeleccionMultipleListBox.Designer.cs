
namespace WindowsFormsApp1
{
    partial class Form14SeleccionMultipleListBox
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
            this.lblelementos = new System.Windows.Forms.Label();
            this.btnseleccionados = new System.Windows.Forms.Button();
            lstelementos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstelementos
            // 
            lstelementos.FormattingEnabled = true;
            lstelementos.Location = new System.Drawing.Point(43, 55);
            lstelementos.Name = "lstelementos";
            lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            lstelementos.Size = new System.Drawing.Size(152, 251);
            lstelementos.TabIndex = 11;
            lstelementos.SelectedIndexChanged += new System.EventHandler(this.lstelementos_SelectedIndexChanged);
            // 
            // lblseleccionados
            // 
            this.lblseleccionados.AutoSize = true;
            this.lblseleccionados.Location = new System.Drawing.Point(43, 378);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(85, 13);
            this.lblseleccionados.TabIndex = 19;
            this.lblseleccionados.Text = "lblseleccionados";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.Location = new System.Drawing.Point(43, 344);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(50, 13);
            this.lblindices.TabIndex = 18;
            this.lblindices.Text = "lblindices";
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(316, 220);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 32);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(316, 120);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(157, 32);
            this.btninsertar.TabIndex = 14;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(316, 55);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(169, 20);
            this.txtelemento.TabIndex = 13;
            // 
            // lblelemento
            // 
            this.lblelemento.AutoSize = true;
            this.lblelemento.Location = new System.Drawing.Point(313, 16);
            this.lblelemento.Name = "lblelemento";
            this.lblelemento.Size = new System.Drawing.Size(51, 13);
            this.lblelemento.TabIndex = 12;
            this.lblelemento.Text = "Elemento";
            // 
            // lblelementos
            // 
            this.lblelementos.AutoSize = true;
            this.lblelementos.Location = new System.Drawing.Point(40, 16);
            this.lblelementos.Name = "lblelementos";
            this.lblelementos.Size = new System.Drawing.Size(56, 13);
            this.lblelementos.TabIndex = 10;
            this.lblelementos.Text = "Elementos";
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.Location = new System.Drawing.Point(316, 168);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(157, 32);
            this.btnseleccionados.TabIndex = 20;
            this.btnseleccionados.Text = "Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            // 
            // Form14SeleccionMultipleListBox
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
            this.Name = "Form14SeleccionMultipleListBox";
            this.Text = "Form14SeleccionMultipleListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label lblseleccionados;
        private System.Windows.Forms.Label lblindices;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Label lblelemento;
        private System.Windows.Forms.Label lblelementos;
        private System.Windows.Forms.Button btnseleccionados;
    }
}