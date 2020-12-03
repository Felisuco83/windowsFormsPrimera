using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases;

namespace WindowsFormsApp1
{
    public partial class Form28SerializarColecciones : Form
    {
        private XmlSerializer serial;
        Productos productos;
        public Form28SerializarColecciones()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Productos));
            productos = new Productos();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = this.txtnombre.Text;
            prod.Precio = int.Parse(this.txtprecio.Text);
            this.productos.Add(prod);
            this.PintarProductos();
            this.txtprecio.Text = "";
            this.txtnombre.Text = "";
            this.txtnombre.Focus();
        }
        private void PintarProductos()
        {
            this.lstproductos.Items.Clear();
            foreach(Producto prod in this.productos)
            {
                this.lstproductos.Items.Add(prod.Nombre);
            }
        }

        private void lstproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstproductos.SelectedIndex != -1)
            {
                int indice = this.lstproductos.SelectedIndex;
                Producto prod = this.productos[indice];
                this.txtnombre.Text = prod.Nombre;
                this.txtprecio.Text = prod.Precio.ToString();
            }
            
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listaproductos.xml");
            this.serial.Serialize(writer, this.productos);
            await writer.FlushAsync();
            writer.Close();
            this.productos.Clear();
            this.lstproductos.Items.Clear();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (Productos)this.serial.Deserialize(reader);
            reader.Close();
            this.PintarProductos();
        }
    }
}
