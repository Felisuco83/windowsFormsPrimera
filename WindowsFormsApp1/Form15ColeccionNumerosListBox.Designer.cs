namespace WindowsFormsApp1
{
    partial class Form15ColeccionNumerosListBox
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnmostrardatos = new System.Windows.Forms.Button();
            this.lblsuma = new System.Windows.Forms.Label();
            this.lblpares = new System.Windows.Forms.Label();
            this.lblimpares = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtpares = new System.Windows.Forms.TextBox();
            this.txtimpares = new System.Windows.Forms.TextBox();
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Location = new System.Drawing.Point(146, 89);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(49, 13);
            this.lblnumeros.TabIndex = 0;
            this.lblnumeros.Text = "Numeros";
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.Location = new System.Drawing.Point(139, 124);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstnumeros.Size = new System.Drawing.Size(143, 160);
            this.lstnumeros.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(372, 24);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(117, 43);
            this.btngenerar.TabIndex = 2;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmostrardatos
            // 
            this.btnmostrardatos.Location = new System.Drawing.Point(372, 73);
            this.btnmostrardatos.Name = "btnmostrardatos";
            this.btnmostrardatos.Size = new System.Drawing.Size(117, 36);
            this.btnmostrardatos.TabIndex = 3;
            this.btnmostrardatos.Text = "Mostrar datos";
            this.btnmostrardatos.UseVisualStyleBackColor = true;
            this.btnmostrardatos.Click += new System.EventHandler(this.btnmostrardatos_Click);
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(322, 184);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(34, 13);
            this.lblsuma.TabIndex = 4;
            this.lblsuma.Text = "Suma";
            // 
            // lblpares
            // 
            this.lblpares.AutoSize = true;
            this.lblpares.Location = new System.Drawing.Point(325, 219);
            this.lblpares.Name = "lblpares";
            this.lblpares.Size = new System.Drawing.Size(34, 13);
            this.lblpares.TabIndex = 5;
            this.lblpares.Text = "Pares";
            // 
            // lblimpares
            // 
            this.lblimpares.AutoSize = true;
            this.lblimpares.Location = new System.Drawing.Point(325, 265);
            this.lblimpares.Name = "lblimpares";
            this.lblimpares.Size = new System.Drawing.Size(44, 13);
            this.lblimpares.TabIndex = 6;
            this.lblimpares.Text = "Impares";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(389, 184);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(100, 20);
            this.txtsuma.TabIndex = 7;
            // 
            // txtpares
            // 
            this.txtpares.Location = new System.Drawing.Point(389, 219);
            this.txtpares.Name = "txtpares";
            this.txtpares.Size = new System.Drawing.Size(100, 20);
            this.txtpares.TabIndex = 8;
            // 
            // txtimpares
            // 
            this.txtimpares.Location = new System.Drawing.Point(389, 265);
            this.txtimpares.Name = "txtimpares";
            this.txtimpares.Size = new System.Drawing.Size(100, 20);
            this.txtimpares.TabIndex = 9;
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.Location = new System.Drawing.Point(372, 115);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(117, 36);
            this.btnseleccionados.TabIndex = 10;
            this.btnseleccionados.Text = "Datos Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // Form15ColeccionNumerosListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.txtimpares);
            this.Controls.Add(this.txtpares);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.lblimpares);
            this.Controls.Add(this.lblpares);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.btnmostrardatos);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.lblnumeros);
            this.Name = "Form15ColeccionNumerosListBox";
            this.Text = "Form15ColeccionNumerosListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnmostrardatos;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label lblpares;
        private System.Windows.Forms.Label lblimpares;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.TextBox txtpares;
        private System.Windows.Forms.TextBox txtimpares;
        private System.Windows.Forms.Button btnseleccionados;
    }
}