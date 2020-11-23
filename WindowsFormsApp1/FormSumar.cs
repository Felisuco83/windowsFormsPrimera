using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormSumar : Form
    {
        public FormSumar()
        {
            InitializeComponent();
        }

        private void FormSumar_Load(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            //HAY QUE PARSEAR DE STRING A PRIMITIVO
            int num1, num2;
            num1 = int.Parse(this.txtnum1.Text);
            num2 = int.Parse(this.txtnum2.Text);
            this.lblresultado.Text = (num1 + num2).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
