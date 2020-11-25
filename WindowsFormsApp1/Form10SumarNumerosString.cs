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
    public partial class Form10SumarNumerosString : Form
    {
        public Form10SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            string numeros = this.txtnumeros.Text;
            int suma = 0;
            for (var i=0; i< numeros.Length; i++)
            {
                suma += int.Parse(numeros[i].ToString());
            }
            this.lblsuma.Text = "La suma es " + suma;
        }
    }
}
