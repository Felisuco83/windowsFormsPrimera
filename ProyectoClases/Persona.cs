using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
    //SI NO LE PONEMOS VALORES LOS ASIGNA EN ORDEN
    public enum TipoGenero
    {
        Masculino = 0, Femenino = 1
    }

    public enum Paises
    {
        España = 0, Inglaterra = 1, Francia = 2, Argentina = 3
    }

    #endregion
    public class Persona
    {
        #region constructores persona
        public Persona()
        {
            Debug.WriteLine("Constructor persona vacio");
        }
        public Persona (string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor persona con params");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        public Persona(int edad)
        {
            Debug.WriteLine("Constructor persona con params");
            this.Edad = edad;
        }
        #endregion
        #region PROPIEDADES
        //PODEMOS COLAPSAR Y DESPLEGAR TODO LO QUE PONGAMOS AQUÍ
        //VAMOS A PONER LOS CAMPOS DE LA CLASE, NORMALMENTE SON PRIVATE(ENCAPSULACION)
        //public String Nombre { get;  set; }
        //NO SE CREAN CAMPOS ACCESIBLES PORQUE SI NO NO PODEMOS CONTROLAR RANGOS NI NÁ DE NÁ
        private Direccion _Domicilio;
        public Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }
        }
        public Direccion DomicilioVacaciones { get; set; }
        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set { 
                if(value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Rango de generos no soportado");
                }
                this._Genero = value; }
        }
        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }
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
        private String _Apellidos;
        public String Apellidos
        {
            get { return this._Apellidos; }
            set { this._Apellidos = value; }
        }

        //PROPIEDAD INDIZADA CONTIENE MULTIPLES ELEMENTOS, NECESITAMOS UN CAMPO PARA MANEJAR LA PROPIEDAD
        // UNA PROPIEDAD QUE CONTENGA ESPACIO PARA 5 DESCRIPCIONES DE PERSONA
        private string[] _Descripciones = new string[5];
        public String this[int indice]
        {
            get { return this._Descripciones[indice]; }
            set { this._Descripciones[indice] = value; }
        }
        //UNA PROPIEDAD INDIZADA NO TIENE NAME, SE UTILIZA LA PALABRA THIS PARA CREARLA
        #endregion
        #region METODOS DE LA CLASE PERSONA
        //METODOS CON PARAMETROS OPCIONALES
        public void MetodoParametrosOpcionales(int numero, int parametroopcional = 99)
        {

        }
        //VAMOS A VER LA SOBRECARGA

        #endregion
    }
}
