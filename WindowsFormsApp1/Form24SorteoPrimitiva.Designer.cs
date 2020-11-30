namespace WindowsFormsApp1
{
    partial class Form24SorteoPrimitiva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstart = new System.Windows.Forms.Button();
            this.lstelegidos = new System.Windows.Forms.ListBox();
            this.btnsortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 307);
            this.panel1.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(320, 62);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(98, 49);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Iniciar";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lstelegidos
            // 
            this.lstelegidos.FormattingEnabled = true;
            this.lstelegidos.Location = new System.Drawing.Point(472, 34);
            this.lstelegidos.Name = "lstelegidos";
            this.lstelegidos.Size = new System.Drawing.Size(234, 316);
            this.lstelegidos.TabIndex = 3;
            // 
            // btnsortear
            // 
            this.btnsortear.Location = new System.Drawing.Point(320, 144);
            this.btnsortear.Name = "btnsortear";
            this.btnsortear.Size = new System.Drawing.Size(98, 49);
            this.btnsortear.TabIndex = 4;
            this.btnsortear.Text = "Sortear";
            this.btnsortear.UseVisualStyleBackColor = true;
            this.btnsortear.Click += new System.EventHandler(this.btnsortear_Click);
            // 
            // Form24SorteoPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsortear);
            this.Controls.Add(this.lstelegidos);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.panel1);
            this.Name = "Form24SorteoPrimitiva";
            this.Text = "Form24SorteoPrimitiva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox lstelegidos;
        private System.Windows.Forms.Button btnsortear;
    }
}