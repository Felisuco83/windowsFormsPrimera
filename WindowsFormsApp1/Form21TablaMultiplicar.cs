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
    public partial class Form21TablaMultiplicar : Form
    {
        public Form21TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            bool shouldDo = false;
            if (this.txtnumero.TextLength == 1 && char.IsDigit(this.txtnumero.Text[0]))
            {
                shouldDo = true;
            }
            if (shouldDo)
            {
                for(int i =0; i< this.panel1.Controls.Count; i++)
                {
                    this.panel1.Controls[i].Text = (int.Parse(this.txtnumero.Text) * (i + 1)).ToString();
                }
            }
        }
    }
}
