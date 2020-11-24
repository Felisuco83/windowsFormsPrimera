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
    public partial class Form07DateTime : Form
    {
        public Form07DateTime()
        {
            InitializeComponent();
            this.txtcurrentdate.Text = DateTime.Now.ToString();
        }

        private void chkchangeformat_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtcurrentdate.Text);
            if (this.chkchangeformat.Checked == true)
            {
                this.txtcurrentdate.Text = fecha.ToLongDateString();
            } else
            {
                this.txtcurrentdate.Text = fecha.ToShortDateString();
            }
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtincr.Text);
            DateTime fecha = DateTime.Parse(this.txtcurrentdate.Text);
            DateTime fecha2 = DateTime.Now;
            if (this.rdbdays.Checked == true)
            {
               fecha2 = fecha.AddDays(incremento);
            } else if (this.rdbmonths.Checked == true)
            {
                fecha2 = fecha.AddMonths(incremento);
            } else
            {
                fecha2 = fecha.AddYears(incremento);
            }
            this.txtnewdate.Text = fecha2.ToString();
            this.lblresult.Text = "Bisiesto: " + DateTime.IsLeapYear(fecha2.Year) + "\nDía Semana" + fecha2.DayOfWeek
                + "\nDía año: " + fecha2.DayOfYear;
        }
    }
}
