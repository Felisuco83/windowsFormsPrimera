using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace WindowsFormsApp1
{
    public partial class Form26ClaseMes : Form
    {
        public List<Mes> meses;
        public Random rnd;
        public Form26ClaseMes()
        {
            InitializeComponent();
            meses = new List<Mes>();
            this.rnd = new Random();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.lstmeses.Items.Clear();
            this.meses.Clear();
            List<string> mesestring = new List<string>() { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            foreach (string mes in mesestring)
            {
                this.meses.Add(new Mes(mes, this.rnd.Next(-10,5), this.rnd.Next(5,30)));
                this.lstmeses.Items.Add(mes);
            }
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mes mes = this.meses[this.lstmeses.SelectedIndex];
            this.txtmaxima.Text = mes.Maxima.ToString();
            this.txtminima.Text = mes.Minima.ToString();
            this.txtmedia.Text = mes.Media.ToString();
        }
    }
}
