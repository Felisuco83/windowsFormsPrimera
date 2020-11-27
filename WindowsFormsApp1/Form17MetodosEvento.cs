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
    public partial class Form17MetodosEvento : Form
    {
        public Form17MetodosEvento()
        {
            InitializeComponent();
        }

        private void lblraton_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblraton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblraton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DESEAMOS INCLUIR LA TECLA DE BORRAR, USAREMOS EL CÓDIGO ASCII
            char teclaBack = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBack = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }
    }
}
