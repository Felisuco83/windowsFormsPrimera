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
    public partial class Form05Mayor3Numeros : Form
    {
        public Form05Mayor3Numeros()
        {
            InitializeComponent();
        }

        private void btnresolver_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>();
            numeros.Add(int.Parse(this.txtnum1.Text));
            numeros.Add(int.Parse(this.txtnum2.Text));
            numeros.Add(int.Parse(this.txtnum3.Text));
            numeros.Sort();
            //AQUÍ PONDRIAMOS LAS CONCATENACIONES, SI QUEREMOS UNA NUEVA LÍNEA LE METEMOS \N
            this.lblresultado.Text = numeros[2].ToString();
        }
    }
}
