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
    public partial class Form16TiendaProductos : Form
    {
        public Form16TiendaProductos()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            bool doesExist = false;
            foreach (var obj in this.lsttienda.Items)
            {
                if (obj.ToString() == this.txtproducto.Text)
                {
                    doesExist = true;
                }
            }
            if (!doesExist)
                this.lsttienda.Items.Add(this.txtproducto.Text);
            this.txtproducto.Focus();
            this.txtproducto.SelectAll();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int numelem = this.lsttienda.Items.Count;
            for (int i = numelem - 1; i >= 0; i--)
            {
                if (this.lsttienda.SelectedIndices.Contains(i))
                    this.lsttienda.Items.RemoveAt(i);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.lsttienda.Items.Clear();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (this.lsttienda.SelectedIndices.Count == 1)
            {
                this.lsttienda.Items[this.lsttienda.SelectedIndices[0]] = this.txtproducto.Text;
            }
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lsttienda.Items)
            {
                this.lstalmacen.Items.Add(item);
            }
            this.lsttienda.Items.Clear();
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            foreach (int i in this.lsttienda.SelectedIndices)
            {
                    this.lstalmacen.Items.Add(this.lsttienda.Items[i]);
            }
            int numelem = this.lsttienda.Items.Count;
            for (int i = numelem - 1; i >= 0; i--)
            {
                if (this.lsttienda.SelectedIndices.Contains(i))
                    this.lsttienda.Items.RemoveAt(i);
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstalmacen.SelectedIndex;
            if (selectedIndex > 0)
            {
                this.lstalmacen.Items.Insert(selectedIndex - 1, this.lstalmacen.Items[selectedIndex]);
                this.lstalmacen.Items.RemoveAt(selectedIndex + 1);
                this.lstalmacen.SelectedIndex = selectedIndex - 1;
            }
        }

        private void btnbajar_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstalmacen.SelectedIndex;
            if (selectedIndex < this.lstalmacen.Items.Count - 1 & selectedIndex != -1)
            {
                this.lstalmacen.Items.Insert(selectedIndex + 2, this.lstalmacen.Items[selectedIndex]);
                this.lstalmacen.Items.RemoveAt(selectedIndex);
                this.lstalmacen.SelectedIndex = selectedIndex + 1;

            }
        }
    }
}
