using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo = 1000;
        }
        //public override int GetVacaciones()
        //{
        //    //AL SUSTITUIR DEJAMOS DE LEER EL MÉTODO DE LA CLASE BASE
        //    Debug.WriteLine("GetVacaciones() director");
        //    return base.GetVacaciones() + 3;
        //}
        public new int GetVacaciones()
        {
            //AL SUSTITUIR DEJAMOS DE LEER EL MÉTODO DE LA CLASE BASE
            Debug.WriteLine("GetVacaciones() director");
            return base.GetVacaciones() + 3;
        }
    }
}
