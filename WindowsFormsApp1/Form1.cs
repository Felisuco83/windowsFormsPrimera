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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpulsar_Click(object sender, EventArgs e)
        {
            txtcaja.Text = "Soy texto";
            //LA PALABRA CLAVE THIS SE REFIERE AL OBJETO SOBRE EL QUE TRABAJAMOS SI NO LO PONEMOS RECUPERA LA VARIABLE POR CERCANÍA
            //DEBEMOS USAR THIS PARA RECUPERAR OBJETOS DEL FORMULARIO
            this.txtcaja.Width = 400;
            //VAMOS A CAMBIAR EL TAMAÑO DEL BOTON, AL NO SER UNA PROPIEDAD DE TIPO PRIMITIVO TENEMOS QUE CREAR UN NUEVO OBJETO
            this.btnpulsar.Size = new Size(350, 250);
            //ALGUNAS CLASES NO SE CREAN, SE UTILIZAN DIRECTAMENTE
            this.BackColor = Color.Gold;
            //ENUMERACIONES. EN AMARILLO
            //UNA ENUMERACION ES UNA SERIE DE POSIBILIDADES PARA UNA PROPIEDAD. EN REALIDAD SON TIPOS INT PERO SE MUESTRAN COMO STRING
            this.txtcaja.TextAlign = HorizontalAlignment.Center;
        }
    }
}
