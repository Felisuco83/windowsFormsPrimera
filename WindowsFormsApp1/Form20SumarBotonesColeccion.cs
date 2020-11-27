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
    public partial class Form20SumarBotonesColeccion : Form
    {
        int suma;
        public Form20SumarBotonesColeccion()
        {
            InitializeComponent();
            this.suma = 0;
            Random rnd = new Random();
            foreach(Control ctrl in this.panel1.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.Text = rnd.Next(0, 100).ToString();
                    ctrl.Click += SumarContenido;
                }
            }
        }
        public void SumarContenido(Object sender, EventArgs arg)
        {
            //int suma = int.Parse(this.txtsumanumeros.Text);
            //var btn = (Button)sender;
            //this.txtsumanumeros.Text = (suma + int.Parse(btn.Text)).ToString();
            var btn = (Button)sender;
            btn.BackColor = Color.Yellow;
            suma += int.Parse(btn.Text);
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            this.txtsumanumeros.Text = this.suma.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            foreach (Button btn in this.panel1.Controls)
            {
                btn.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
            this.suma = 0;
            this.txtsumanumeros.Text = "0";
        }
    }
}
