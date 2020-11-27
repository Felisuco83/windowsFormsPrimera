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
    public partial class Form19MetodosEventoColecciones : Form
    {
        private List<Button> botones;
        private int contador;

        public Form19MetodosEventoColecciones()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //TENEMOS LA COLECCIÓN CONTROLS, SI NO PUES HABRÍA QUE HACER UN ADD MANUAL POR CADA UNO
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    
                }
            }
        }

        private void chkasociar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkasociar.Checked == true)
            {
                foreach(Button boton in this.botones)
                {
                    boton.Click += MostrarMensaje;
                }
            } else
            {
                foreach (Button boton in this.botones)
                {
                    boton.Click -= MostrarMensaje;
                }
            }
            contador++;
        }
        private void MostrarMensaje (object sender, EventArgs e)
        {
            //MessageBox.Show("Pulsado");
            Button boton = (Button)sender;
            boton.BackColor = Color.LightGreen;
        }
    }
}
