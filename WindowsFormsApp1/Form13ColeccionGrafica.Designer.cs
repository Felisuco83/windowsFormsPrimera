
namespace WindowsFormsApp1
{
    partial class Form13ColeccionGrafica
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
            this.lblelementos = new System.Windows.Forms.Label();
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.lblelemento = new System.Windows.Forms.Label();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.lblposicion = new System.Windows.Forms.Label();
            this.lblseleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblelementos
            // 
            this.lblelementos.AutoSize = true;
            this.lblelementos.Location = new System.Drawing.Point(63, 43);
            this.lblelementos.Name = "lblelementos";
            this.lblelementos.Size = new System.Drawing.Size(56, 13);
            this.lblelementos.TabIndex = 0;
            this.lblelementos.Text = "Elementos";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.Location = new System.Drawing.Point(66, 82);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.Size = new System.Drawing.Size(152, 251);
            this.lstelementos.TabIndex = 1;
            this.lstelementos.SelectedIndexChanged += new System.EventHandler(this.lstelementos_SelectedIndexChanged);
            // 
            // lblelemento
            // 
            this.lblelemento.AutoSize = true;
            this.lblelemento.Location = new System.Drawing.Point(336, 43);
            this.lblelemento.Name = "lblelemento";
            this.lblelemento.Size = new System.Drawing.Size(51, 13);
            this.lblelemento.TabIndex = 2;
            this.lblelemento.Text = "Elemento";
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(339, 82);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(169, 20);
            this.txtelemento.TabIndex = 3;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(339, 147);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(157, 32);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(339, 206);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 32);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(339, 263);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(157, 32);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(339, 323);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(157, 32);
            this.btnmod.TabIndex = 7;
            this.btnmod.Text = "Modificar";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // lblposicion
            // 
            this.lblposicion.AutoSize = true;
            this.lblposicion.Location = new System.Drawing.Point(66, 371);
            this.lblposicion.Name = "lblposicion";
            this.lblposicion.Size = new System.Drawing.Size(56, 13);
            this.lblposicion.TabIndex = 8;
            this.lblposicion.Text = "lblposicion";
            // 
            // lblseleccionado
            // 
            this.lblseleccionado.AutoSize = true;
            this.lblseleccionado.Location = new System.Drawing.Point(66, 405);
            this.lblseleccionado.Name = "lblseleccionado";
            this.lblseleccionado.Size = new System.Drawing.Size(80, 13);
            this.lblseleccionado.TabIndex = 9;
            this.lblseleccionado.Text = "lblseleccionado";
            // 
            // Form13ColeccionGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblseleccionado);
            this.Controls.Add(this.lblposicion);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lblelemento);
            this.Controls.Add(this.lstelementos);
            this.Controls.Add(this.lblelementos);
            this.Name = "Form13ColeccionGrafica";
            this.Text = "Form13ColeccionGrafica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblelementos;
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label lblelemento;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Label lblposicion;
        private System.Windows.Forms.Label lblseleccionado;
    }
}