using System;
using System.Collections;
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
    public partial class Form18ColeccionesNoGraficas : Form
    {
        public Form18ColeccionesNoGraficas()
        {
            InitializeComponent();

            //ArrayList coleccion = new ArrayList();
            //coleccion.Add(this.button1);
            //coleccion.Add(this.button2);
            //coleccion.Add(this.button3);
            //coleccion.Add(this.textBox1);
            //// SI QUEREMOS CAMBIAR EL COLOR DE FONDO DE UN BOTÓN
            //((Button)coleccion[0]).BackColor = Color.Yellow;
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.LightGreen;
            //}

            List <Control> coleccion = new List<Control>();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.LightBlue;
                //SI DESEARAMOS PREGUNTAR PARA HACER ALGO SOBRE CIERTOS TIPOS
                if (control is TextBox)
                {
                    control.BackColor = Color.LightGoldenrodYellow;
                    //((TextBox)control).Paste();
                }
            }
        }
    }
}
