using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form22TemperaturasAnuales : Form
    {
        List<int> temperaturas;
        public Form22TemperaturasAnuales()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            int random;
            this.temperaturas.Clear();
            this.lstmeses.Items.Clear();
            //PARA HACERLO AUTÓMATICO HARÍAMOS UN BUCLE CON ESTO
            //Debug.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(8));
            List<string> meses = new List<string>() { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            for(var i =0; i< meses.Count; i++)
            {
                random = rnd.Next(-15, 30);
                this.temperaturas.Add(random);
                this.lstmeses.Items.Add(meses[i] + " " + random.ToString());
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            this.txttempmax.Text = this.temperaturas.Max().ToString();
            this.txttempmin.Text = this.temperaturas.Min().ToString();
            this.txttempmed.Text = this.temperaturas.Average().ToString();
        }
    }
}
