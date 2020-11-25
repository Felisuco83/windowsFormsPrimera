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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items.Add(this.txtelemento.Text);
            this.txtelemento.SelectAll();
            this.txtelemento.Focus();
        }

        private void lstelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblposicion.Text = "Posición: " + this.lstelementos.SelectedIndex;
            this.lblseleccionado.Text = "Seleccionado: " + this.lstelementos.SelectedItem;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //.REMOVE(OBJETO) REMOVEAT(INDICE
            this.lstelementos.Items.RemoveAt(this.lstelementos.SelectedIndex);
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items[this.lstelementos.SelectedIndex] = this.txtelemento.Text;
        }
    }
}
