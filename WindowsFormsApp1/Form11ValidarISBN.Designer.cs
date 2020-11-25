
namespace WindowsFormsApp1
{
    partial class Form11ValidarISBN
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
            this.lblisbn = new System.Windows.Forms.Label();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.btncomprobar = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(147, 111);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(38, 13);
            this.lblisbn.TabIndex = 0;
            this.lblisbn.Text = "ISBN: ";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(234, 108);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(212, 20);
            this.txtisbn.TabIndex = 1;
            // 
            // btncomprobar
            // 
            this.btncomprobar.Location = new System.Drawing.Point(254, 200);
            this.btncomprobar.Name = "btncomprobar";
            this.btncomprobar.Size = new System.Drawing.Size(127, 41);
            this.btncomprobar.TabIndex = 2;
            this.btncomprobar.Text = "Comprobar ISBN";
            this.btncomprobar.UseVisualStyleBackColor = true;
            this.btncomprobar.Click += new System.EventHandler(this.btncomprobar_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.ForeColor = System.Drawing.Color.Red;
            this.lblresult.Location = new System.Drawing.Point(231, 303);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 3;
            // 
            // Form11ValidarISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btncomprobar);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.lblisbn);
            this.Name = "Form11ValidarISBN";
            this.Text = "Form11ValidarISBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Button btncomprobar;
        private System.Windows.Forms.Label lblresult;
    }
}