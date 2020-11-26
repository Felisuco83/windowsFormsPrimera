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
    public partial class Form15ColeccionNumerosListBox : Form
    {
        public Form15ColeccionNumerosListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            this.lstnumeros.Items.Clear();
            for (int i = 0; i <10; i++) {
                int rndNum = rnd.Next(0, 100);
                this.lstnumeros.Items.Add(rndNum);
            }
        }

        private void btnmostrardatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;
            foreach (var num in this.lstnumeros.Items)
            {
                suma += int.Parse(num.ToString());
            }
            foreach (var num in this.lstnumeros.Items)
            {
                if(int.Parse(num.ToString()) % 2 == 0)
                    pares += int.Parse(num.ToString());
            }
            foreach (var num in this.lstnumeros.Items)
            {
                if (int.Parse(num.ToString()) % 2 != 0)
                    impares += int.Parse(num.ToString());
            }
            this.txtsuma.Text = suma.ToString();
            this.txtpares.Text = pares.ToString();
            this.txtimpares.Text = impares.ToString();
        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int pares = 0;
            int impares = 0;
            foreach (var num in this.lstnumeros.SelectedItems)
            {
                suma += int.Parse(num.ToString());
            }
            foreach (var num in this.lstnumeros.SelectedItems)
            {
                if (int.Parse(num.ToString()) % 2 == 0)
                    pares += int.Parse(num.ToString());
            }
            foreach (var num in this.lstnumeros.SelectedItems)
            {
                if (int.Parse(num.ToString()) % 2 != 0)
                    impares += int.Parse(num.ToString());
            }
            this.txtsuma.Text = suma.ToString();
            this.txtpares.Text = pares.ToString();
            this.txtimpares.Text = impares.ToString();
        }
    }
}
