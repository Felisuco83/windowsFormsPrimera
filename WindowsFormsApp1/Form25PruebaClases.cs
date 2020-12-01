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
            this.lstdatos.Items.Clear();
            Persona person = new Persona();
            person.Edad = 33;
            person.Nombre = "Jesús";
            person.Genero = TipoGenero.Masculino;
            person.Nacionalidad = Paises.España;
            person[0] = "Ojos claros";
            person[1] = "Mandibula cuadrada";
            this.lstdatos.Items.Add("Nombre: " + person.Nombre);
            this.lstdatos.Items.Add("Edad: " + person.Edad);
            this.lstdatos.Items.Add("Genero: " + person.Genero);
            this.lstdatos.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstdatos.Items.Add("Descripcion 0: " + person[0]);
            this.lstdatos.Items.Add("Descripcion 1: " + person[1]);
            person.Domicilio = new Direccion();
            person.Domicilio.Calle = "Calle Pez";
            this.lstdatos.Items.Add("Casa " + person.Domicilio.Calle);
            person.DomicilioVacaciones = new Direccion();
            person.DomicilioVacaciones.Ciudad = "Marina d'or";
            this.lstdatos.Items.Add("Casa vacaciones: " + person.DomicilioVacaciones.Ciudad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstdatos.Items.Clear();
            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Apellidos emp";
            this.lstdatos.Items.Add("Datos empleado: " + emp.Nombre + " " + emp.Apellidos);
            Empleado empleado = new Empleado("EMp", "EMPAPE");
            Director dire = new Director();
            this.lstdatos.Items.Add("Director :" dire.)
        }
    }
}
