using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
        }

        private void btnreverse_Click(object sender, EventArgs e)
        {
            //QUEREMOS MEDIR EL TIEMPO DE EJECUCION DEL PROCESO
            Stopwatch krono = new Stopwatch();
            krono.Start();
            string texto = this.txttexto.Text;
            for (int i = 0; i < texto.Length; i++)
            {
                char caracter = texto[i];
                texto = texto.Insert(0, caracter.ToString());
                texto = texto.Remove(i + 1, 1);
            }
            this.txttexto.Text = texto;
            krono.Stop();
            this.lbltiempo.Text = "Ha tardado" + krono.Elapsed.TotalSeconds.ToString() + " segundos \n " + krono.Elapsed.TotalMilliseconds + " milisegundos";
        }

        private void btnreverseb_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder(this.txttexto.Text);
            foreach( var letra in texto.ToString())
            {

            }
            //tambien lo podría iniciar vacio y utilizar el método Append
            for (int i = 0; i< texto.Length; i++)
            {
                char caracter = texto[i];
                texto = texto.Insert(0, caracter.ToString());
                texto = texto.Remove(i + 1, 1);
            }
            this.txttexto.Text = texto.ToString();
            krono.Stop();
            this.lbltiempo.Text = "Ha tardado" + krono.Elapsed.TotalSeconds.ToString() + " segundos \n " + krono.Elapsed.TotalMilliseconds + " milisegundos";
        }
    }
}
