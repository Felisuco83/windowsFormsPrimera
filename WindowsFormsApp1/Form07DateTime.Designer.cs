namespace WindowsFormsApp1
{
    partial class Form07DateTime
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
            this.lblcurrentdate = new System.Windows.Forms.Label();
            this.txtcurrentdate = new System.Windows.Forms.TextBox();
            this.chkchangeformat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.txtincr = new System.Windows.Forms.TextBox();
            this.lblincr = new System.Windows.Forms.Label();
            this.rdbyears = new System.Windows.Forms.RadioButton();
            this.rdbmonths = new System.Windows.Forms.RadioButton();
            this.rdbdays = new System.Windows.Forms.RadioButton();
            this.lblnewdate = new System.Windows.Forms.Label();
            this.txtnewdate = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcurrentdate
            // 
            this.lblcurrentdate.AutoSize = true;
            this.lblcurrentdate.Location = new System.Drawing.Point(64, 13);
            this.lblcurrentdate.Name = "lblcurrentdate";
            this.lblcurrentdate.Size = new System.Drawing.Size(72, 13);
            this.lblcurrentdate.TabIndex = 0;
            this.lblcurrentdate.Text = "Fecha actual:";
            // 
            // txtcurrentdate
            // 
            this.txtcurrentdate.Location = new System.Drawing.Point(67, 29);
            this.txtcurrentdate.Name = "txtcurrentdate";
            this.txtcurrentdate.Size = new System.Drawing.Size(314, 20);
            this.txtcurrentdate.TabIndex = 1;
            // 
            // chkchangeformat
            // 
            this.chkchangeformat.AutoSize = true;
            this.chkchangeformat.Location = new System.Drawing.Point(103, 93);
            this.chkchangeformat.Name = "chkchangeformat";
            this.chkchangeformat.Size = new System.Drawing.Size(105, 17);
            this.chkchangeformat.TabIndex = 2;
            this.chkchangeformat.Text = "Cambiar Formato";
            this.chkchangeformat.UseVisualStyleBackColor = true;
            this.chkchangeformat.CheckedChanged += new System.EventHandler(this.chkchangeformat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnshowdate);
            this.groupBox1.Controls.Add(this.txtincr);
            this.groupBox1.Controls.Add(this.lblincr);
            this.groupBox1.Controls.Add(this.rdbyears);
            this.groupBox1.Controls.Add(this.rdbmonths);
            this.groupBox1.Controls.Add(this.rdbdays);
            this.groupBox1.Location = new System.Drawing.Point(83, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // btnshowdate
            // 
            this.btnshowdate.Location = new System.Drawing.Point(218, 108);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(148, 36);
            this.btnshowdate.TabIndex = 5;
            this.btnshowdate.Text = "Mostrar Fecha";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // txtincr
            // 
            this.txtincr.Location = new System.Drawing.Point(218, 65);
            this.txtincr.Name = "txtincr";
            this.txtincr.Size = new System.Drawing.Size(100, 20);
            this.txtincr.TabIndex = 4;
            // 
            // lblincr
            // 
            this.lblincr.AutoSize = true;
            this.lblincr.Location = new System.Drawing.Point(215, 48);
            this.lblincr.Name = "lblincr";
            this.lblincr.Size = new System.Drawing.Size(60, 13);
            this.lblincr.TabIndex = 3;
            this.lblincr.Text = "Incremento";
            // 
            // rdbyears
            // 
            this.rdbyears.AutoSize = true;
            this.rdbyears.Location = new System.Drawing.Point(35, 108);
            this.rdbyears.Name = "rdbyears";
            this.rdbyears.Size = new System.Drawing.Size(52, 17);
            this.rdbyears.TabIndex = 2;
            this.rdbyears.TabStop = true;
            this.rdbyears.Text = "Años:";
            this.rdbyears.UseVisualStyleBackColor = true;
            // 
            // rdbmonths
            // 
            this.rdbmonths.AutoSize = true;
            this.rdbmonths.Location = new System.Drawing.Point(35, 65);
            this.rdbmonths.Name = "rdbmonths";
            this.rdbmonths.Size = new System.Drawing.Size(59, 17);
            this.rdbmonths.TabIndex = 1;
            this.rdbmonths.TabStop = true;
            this.rdbmonths.Text = "Meses:";
            this.rdbmonths.UseVisualStyleBackColor = true;
            // 
            // rdbdays
            // 
            this.rdbdays.AutoSize = true;
            this.rdbdays.Location = new System.Drawing.Point(35, 19);
            this.rdbdays.Name = "rdbdays";
            this.rdbdays.Size = new System.Drawing.Size(51, 17);
            this.rdbdays.TabIndex = 0;
            this.rdbdays.TabStop = true;
            this.rdbdays.Text = "Días:";
            this.rdbdays.UseVisualStyleBackColor = true;
            // 
            // lblnewdate
            // 
            this.lblnewdate.AutoSize = true;
            this.lblnewdate.Location = new System.Drawing.Point(80, 328);
            this.lblnewdate.Name = "lblnewdate";
            this.lblnewdate.Size = new System.Drawing.Size(72, 13);
            this.lblnewdate.TabIndex = 4;
            this.lblnewdate.Text = "Nueva Fecha";
            // 
            // txtnewdate
            // 
            this.txtnewdate.Location = new System.Drawing.Point(83, 354);
            this.txtnewdate.Name = "txtnewdate";
            this.txtnewdate.Size = new System.Drawing.Size(245, 20);
            this.txtnewdate.TabIndex = 5;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.SystemColors.Control;
            this.lblresult.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblresult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblresult.Location = new System.Drawing.Point(80, 387);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "label3";
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtnewdate);
            this.Controls.Add(this.lblnewdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkchangeformat);
            this.Controls.Add(this.txtcurrentdate);
            this.Controls.Add(this.lblcurrentdate);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcurrentdate;
        private System.Windows.Forms.TextBox txtcurrentdate;
        private System.Windows.Forms.CheckBox chkchangeformat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.TextBox txtincr;
        private System.Windows.Forms.Label lblincr;
        private System.Windows.Forms.RadioButton rdbyears;
        private System.Windows.Forms.RadioButton rdbmonths;
        private System.Windows.Forms.RadioButton rdbdays;
        private System.Windows.Forms.Label lblnewdate;
        private System.Windows.Forms.TextBox txtnewdate;
        private System.Windows.Forms.Label lblresult;
    }
}