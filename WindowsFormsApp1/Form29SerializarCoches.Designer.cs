
namespace WindowsFormsApp1
{
    partial class Form29SerializarCoches
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstcoches = new System.Windows.Forms.ListBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnloadimg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(33, 40);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 1;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(33, 99);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 226);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lstcoches
            // 
            this.lstcoches.FormattingEnabled = true;
            this.lstcoches.Location = new System.Drawing.Point(279, 40);
            this.lstcoches.Name = "lstcoches";
            this.lstcoches.Size = new System.Drawing.Size(329, 355);
            this.lstcoches.TabIndex = 5;
            this.lstcoches.SelectedIndexChanged += new System.EventHandler(this.lstcoches_SelectedIndexChanged);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(637, 155);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(137, 56);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Insertar Coche";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(637, 237);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(137, 56);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar datos";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(637, 323);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(137, 56);
            this.btnread.TabIndex = 8;
            this.btnread.Text = "Leer datos";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnloadimg
            // 
            this.btnloadimg.Location = new System.Drawing.Point(33, 400);
            this.btnloadimg.Name = "btnloadimg";
            this.btnloadimg.Size = new System.Drawing.Size(224, 28);
            this.btnloadimg.TabIndex = 9;
            this.btnloadimg.Text = "Cargar imagen";
            this.btnloadimg.UseVisualStyleBackColor = true;
            this.btnloadimg.Click += new System.EventHandler(this.btnloadimg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coches";
            // 
            // Form29SerializarCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnloadimg);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.lstcoches);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label1);
            this.Name = "Form29SerializarCoches";
            this.Text = "Form29SerializarCoches";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstcoches;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnloadimg;
        private System.Windows.Forms.Label label3;
    }
}