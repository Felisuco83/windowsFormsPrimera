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
    public partial class Form23ControlesEjecucion : Form
    {
        public Form23ControlesEjecucion()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            CheckBox chk = new CheckBox();
            int posx = 0;
            for (int i = 0; i <5; i++)
            {
                chk = new CheckBox();
                chk.Text = rnd.Next(1, 50).ToString();
                chk.AutoSize = true;
                chk.Location = new Point(posx,10);
                posx += 50;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += RealizarOperacion;
            }
        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtvalor.Text);
            CheckBox chk = (CheckBox)sender;
            if(chk.Checked)
            {
                this.txtvalor.Text = (valor + int.Parse(chk.Text)).ToString();
            } else
            {
                this.txtvalor.Text = (valor - int.Parse(chk.Text)).ToString();
            }
            
        }
    }
}
