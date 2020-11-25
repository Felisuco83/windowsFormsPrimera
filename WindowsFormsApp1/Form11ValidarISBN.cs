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
    public partial class Form11ValidarISBN : Form
    {
        public Form11ValidarISBN()
        {
            InitializeComponent();
        }

        private void btncomprobar_Click(object sender, EventArgs e)
        {
            string numeros = this.txtisbn.Text;
            int suma = 0;
            bool valid = false;
            if (numeros.Length == 10)
            {
                for (var i = 0; i < numeros.Length; i++)
                {
                    suma += int.Parse(numeros[i].ToString()) * (i + 1);
                }
                if (suma % 11 == 0)
                {
                    valid = true;
                }
                this.lblresult.Text = valid ? "ISBN Correcto" : "ISBN Incorrecto";
            } else
            {
                this.lblresult.Text = "El ISBN debe de tener 10 caracteres";
            }
        }
    }
}
