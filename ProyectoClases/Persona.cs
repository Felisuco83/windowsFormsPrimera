using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Persona
    {
        #region PROPIEDADES
        //PODEMOS COLAPSAR Y DESPLEGAR TODO LO QUE PONGAMOS AQUÍ
        //VAMOS A PONER LOS CAMPOS DE LA CLASE, NORMALMENTE SON PRIVATE(ENCAPSULACION)
        //public String Nombre { get;  set; }
        //NO SE CREAN CAMPOS ACCESIBLES PORQUE SI NO NO PODEMOS CONTROLAR RANGOS NI NÁ DE NÁ
        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set {
                if (value < 0)
                {
                    this._Edad = 0;
                    throw new Exception("Edad negativa");
                }else { 
                    this._Edad = value; }
            }
        }
        #endregion
    }
}
