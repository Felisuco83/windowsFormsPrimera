using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        public Empleado()
        {
            Debug.WriteLine("Construsctor vacio empleado");
            this.SalarioMinimo = 800;
        }

        public Empleado(string nombre, string apellidos):base(33)
        {
            Debug.WriteLine("Constructor empleado con params");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        protected int SalarioMinimo { get; set; }
    }
}
