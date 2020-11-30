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
    public partial class Form25PruebaClases : Form
    {
        public Form25PruebaClases()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            //TODA CLASE DEBEMOS INSTANCIARLA PARA PODER UTILIZARLA
            Persona person = new Persona();
            person.Edad = 33;
            person.Nombre = "Jesús";
            this.lstdatos.Items.Add("Nombre: " + person.Nombre);
            this.lstdatos.Items.Add("Edad: " + person.Edad);
        }
    }
}
