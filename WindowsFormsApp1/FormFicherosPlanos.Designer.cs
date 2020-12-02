namespace WindowsFormsApp1
{
    partial class FormFicherosPlanos
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
            this.lblintroduzca = new System.Windows.Forms.Label();
            this.btnleer = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lstnombres = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(49, 63);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(221, 232);
            this.txttexto.TabIndex = 0;
            this.txttexto.Text = "";
            // 
            // lblintroduzca
            // 
            this.lblintroduzca.AutoSize = true;
            this.lblintroduzca.Location = new System.Drawing.Point(46, 34);
            this.lblintroduzca.Name = "lblintroduzca";
            this.lblintroduzca.Size = new System.Drawing.Size(90, 13);
            this.lblintroduzca.TabIndex = 1;
            this.lblintroduzca.Text = "Introduzca Texto:";
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(342, 63);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(108, 60);
            this.btnleer.TabIndex = 2;
            this.btnleer.Text = "Leer fichero";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(342, 156);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(108, 60);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar fichero:";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(484, 63);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(87, 59);
            this.btnnuevo.TabIndex = 15;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // lstnombres
            // 
            this.lstnombres.FormattingEnabled = true;
            this.lstnombres.Location = new System.Drawing.Point(599, 120);
            this.lstnombres.Name = "lstnombres";
            this.lstnombres.Size = new System.Drawing.Size(162, 160);
            this.lstnombres.TabIndex = 14;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(599, 63);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(162, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(596, 28);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 12;
            this.lblnombre.Text = "Nombre:";
            // 
            // FormFicherosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.lstnombres);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.lblintroduzca);
            this.Controls.Add(this.txttexto);
            this.Name = "FormFicherosPlanos";
            this.Text = "FormFicherosPlanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label lblintroduzca;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ListBox lstnombres;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
    }
}