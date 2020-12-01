
namespace WindowsFormsApp1
{
    partial class Form26ClaseMes
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
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.lblmeses = new System.Windows.Forms.Label();
            this.lblmaxima = new System.Windows.Forms.Label();
            this.txtmaxima = new System.Windows.Forms.TextBox();
            this.txtminima = new System.Windows.Forms.TextBox();
            this.lblminima = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.lblmedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.Location = new System.Drawing.Point(22, 58);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(184, 225);
            this.lstmeses.TabIndex = 0;
            this.lstmeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(261, 243);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(98, 51);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // lblmeses
            // 
            this.lblmeses.AutoSize = true;
            this.lblmeses.Location = new System.Drawing.Point(40, 39);
            this.lblmeses.Name = "lblmeses";
            this.lblmeses.Size = new System.Drawing.Size(37, 13);
            this.lblmeses.TabIndex = 2;
            this.lblmeses.Text = "meses";
            // 
            // lblmaxima
            // 
            this.lblmaxima.AutoSize = true;
            this.lblmaxima.Location = new System.Drawing.Point(258, 58);
            this.lblmaxima.Name = "lblmaxima";
            this.lblmaxima.Size = new System.Drawing.Size(43, 13);
            this.lblmaxima.TabIndex = 4;
            this.lblmaxima.Text = "Maxima";
            // 
            // txtmaxima
            // 
            this.txtmaxima.Location = new System.Drawing.Point(261, 75);
            this.txtmaxima.Name = "txtmaxima";
            this.txtmaxima.Size = new System.Drawing.Size(100, 20);
            this.txtmaxima.TabIndex = 5;
            // 
            // txtminima
            // 
            this.txtminima.Location = new System.Drawing.Point(261, 133);
            this.txtminima.Name = "txtminima";
            this.txtminima.Size = new System.Drawing.Size(100, 20);
            this.txtminima.TabIndex = 7;
            // 
            // lblminima
            // 
            this.lblminima.AutoSize = true;
            this.lblminima.Location = new System.Drawing.Point(258, 117);
            this.lblminima.Name = "lblminima";
            this.lblminima.Size = new System.Drawing.Size(42, 13);
            this.lblminima.TabIndex = 6;
            this.lblminima.Text = "Mínima";
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(261, 203);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 20);
            this.txtmedia.TabIndex = 9;
            // 
            // lblmedia
            // 
            this.lblmedia.AutoSize = true;
            this.lblmedia.Location = new System.Drawing.Point(258, 186);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(36, 13);
            this.lblmedia.TabIndex = 8;
            this.lblmedia.Text = "Media";
            // 
            // Form26ClaseMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.txtminima);
            this.Controls.Add(this.lblminima);
            this.Controls.Add(this.txtmaxima);
            this.Controls.Add(this.lblmaxima);
            this.Controls.Add(this.lblmeses);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.lstmeses);
            this.Name = "Form26ClaseMes";
            this.Text = "Form26ClaseMes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label lblmeses;
        private System.Windows.Forms.Label lblmaxima;
        private System.Windows.Forms.TextBox txtmaxima;
        private System.Windows.Forms.TextBox txtminima;
        private System.Windows.Forms.Label lblminima;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label lblmedia;
    }
}