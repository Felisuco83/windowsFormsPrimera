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
    public partial class Form17MetodoReferencia : Form
    {
        public Form17MetodoReferencia()
        {
            InitializeComponent();
        }

        //metodo para comprobar valor en tipos wrapper

        //void DobleNumero (ref int num)
        //{
        //    num = num * 2;
        //}

        int GetDoble (int num)
        {
            return num * 2;
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            //SI QUEREMOS PASARLE EL NUMERO POR REFERENCIA HAY QUE USAR LA PALABRA CLAVE REF
            //this.DobleNumero(ref numero);
            //AÚN ASI ES MEJOR HACERLO CON RETURN
            //this.lblresultado.Text = "Doble: " + numero;
            this.lblresultado.Text = "Doble: " + this.GetDoble(numero);
            this.CambiarColor(this.btnllamada);
        }

        //METODO QUE RECIBE UNA CLASE POR REFERENCIA
        void CambiarColor (Button btn)
        {
            btn.BackColor = Color.DarkOrange;
        }
    }
}
