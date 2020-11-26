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
    public partial class Form14SeleccionMultiple : Form
    {
        public Form14SeleccionMultiple()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String elem = this.txtelemento.Text;
            this.lstelementos.Items.Add(elem);
            this.txtelemento.SelectAll();
            this.txtelemento.Focus();
        }

        private void btnseleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            String items = "";
            foreach (int num in this.lstelementos.SelectedIndices)
            {
                indices += num + ",";
            }
            foreach (object obj in this.lstelementos.SelectedItems)
            {
                items = obj + ",";
            }
            this.lblindices.Text = indices.Trim();
            this.lblseleccionados.Text = items.Trim();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //VAMOS A RECORRER TODOS LOS INDICES SELECCIONADOS (SELECTEDINDICES)
            // TODOS LOS ELEMENTOS ESTÁN EN LA COLECCION .SELECTED_ITEMS
            int numelem = this.lstelementos.Items.Count;
            for (int i = numelem-1; i>=0;i--)
            {
                int indSeleccionado = this.lstelementos.SelectedIndices[i];
                this.lstelementos.Items.RemoveAt(indSeleccionado);
            }
        }
    }
}
