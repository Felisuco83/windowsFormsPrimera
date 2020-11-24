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
    public partial class Form06CalcularDia : Form
    {
        public Form06CalcularDia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtmes.Text);
            int anio = int.Parse(this.txtanio.Text);
            if (mes == 1)
            {
                mes = 13;
                anio--;
            }
            if (mes == 2)
            {
                mes = 14;
                anio--;
            }
            int op1 =  ((mes+1) *3) /5  ;
            int op2 = (anio / 4);
            int op3 = anio / 100;
            int op4 = anio / 400;
            int op5 = dia + (2 * mes) + anio + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);
            List<string> lista = new List<string>();
            lista.Add("Sabado");
            lista.Add("Domingo");
            lista.Add("Lunes");
            lista.Add("Martes");
            lista.Add("Miércoles");
            lista.Add("Jueves");
            lista.Add("Viernes");
            this.lblresultado.Text = lista[op7];
        }
    }
}
