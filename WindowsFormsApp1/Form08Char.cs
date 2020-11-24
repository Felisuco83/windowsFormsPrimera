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
    public partial class Form08Char : Form
    {
        public Form08Char()
        {
            InitializeComponent();
        }

        private void btnrecorrer_Click(object sender, EventArgs e)
        {
            for (int i=0; i<255; i++)
            {
                //QUEREMOS CONVERITR COADA INT A CHAR
                char caracter = (char)i;
                if (char.IsLetter(caracter) == true)
                {
                    this.txtletras.Text += caracter;
                }
                if (char.IsNumber(caracter) == true)
                {
                    this.txtnumeros.Text += caracter;
                }
                if (char.IsSymbol(caracter) == true)
                {
                    this.txtsimbolos.Text += caracter;
                }
                if (char.IsPunctuation(caracter) == true)
                {
                    this.txtpuntuacion.Text += caracter;
                }
            }
        }
    }
}
