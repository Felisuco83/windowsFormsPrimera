using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public Direccion()
        {
            Debug.WriteLine("Creando dirección sin params");
        }
        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Creando dirección 2 params");
        }
        public Direccion(string calle, string ciudad, string cp): this(calle,ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Creando dirección 3 params");
        }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
    }
}
