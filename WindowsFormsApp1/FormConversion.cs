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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //CONVERSION AUTÓMATICA
            double mayor = 99;
            int menor = 99;
            //SI IGUALAMOS MAYOR CAPACIDAD A MENOR LA CONVERSIÓN ES AUTOMÁTICA
            mayor = menor;
            //ERROR DE COMPILACION SI LO HACEMOS AL REVES menor = mayor;
            //CASTING ENTRE PRIMITIVOS : LOS PRIMITIVOS ESTAN TODOS EN MINUSCULAS
            // (TIPO A CONVERTIR) OBJETO
            short mini = 44; //menor
            int numero = 88; //mayor
            mini = (short)numero;
            //CONVERSION DE STRING A TIPO PRIMITIVO
            //UN TIPO String ES UNA CLASE, TIENE LA PRIMERA LETRA MAYÚSCULA
            //PARA PODER CONVERTIR CUALQUIER STRING A PRIMITIVO SE UTILIZAN MÉTODOS PARSE DE LAS CLASES PRIMITIVAS
            //tipprimitivo.Parse(string)
            String texto = "34567";
            int num = int.Parse(texto);
            double doble = double.Parse(texto);
            //CONVERTIR PRIMITIVOS A STRING
            // LA CLASE SYSTEM.OBJECT TIENE UN METODO PARA CONVERTIR A STRING .ToString()
            int valor = 999;
            String dato = valor.ToString();
            //LOS METODOS PUEDEN TENER TAMBIEN SOBRECARGA
            MessageBox.Show("Texto", "titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
    }
}
