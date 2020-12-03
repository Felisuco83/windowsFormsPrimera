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
    public partial class Form27ListaProductosSerializeXML : Form
    {
        private XmlSerializer serial;
        public Form27ListaProductosSerializeXML()
        {
            InitializeComponent();
            this.serial = new XmlSerializer(typeof(Producto));
        }

        private async void btninsert_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtnombre.Text;
            producto.Precio = int.Parse(this.txtprecio.Text);
            StreamWriter writer = new StreamWriter("producto.xml");
            this.serial.Serialize(writer, producto);
            await writer.FlushAsync();
            writer.Close();
            this.txtnombre.Text = "";
            this.txtprecio.Text = "";
            this.lblinfo.Text = "Producto guardado";
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("producto.xml");
            Producto producto = (Producto)this.serial.Deserialize(reader);
            this.txtnombre.Text = producto.Nombre;
            this.txtprecio.Text = producto.Precio.ToString();
            this.lblinfo.Text = "Producto leído";
        }
    }
}
