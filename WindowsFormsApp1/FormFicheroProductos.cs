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
using ProyectoClases;
using System.Web;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class FormFicheroProductos : Form
    {
        private List<Producto> productos;
        private int currentIndex;
        public FormFicheroProductos()
        {
            this.productos = new List<Producto>();
            this.currentIndex = 0;
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            this.currentIndex = 0;
            if (this.txtnombre.Text != "" && this.txtprecio.Text != "")
            {
                Producto prod = new Producto();
                prod.Nombre = this.txtnombre.Text;
                prod.Precio = int.Parse(this.txtprecio.Text);
                this.productos.Add(prod);
                this.lstproductos.Items.Add("Nombre: " + prod.Nombre + ", Precio: " + prod.Precio);
            }
            SetLabelContador();
        }

        private async void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //ShowDialog siempre nos va a devolver DialogResult
            DialogResult respuesta = save.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                String path = save.FileName;
                // LA CLASE FILEINFO SIRVE PARA MANEJAR CUALQUIER TIPO DE ARCHIVO
                FileInfo file = new FileInfo(path);
                // A PARTIR DEL FILEINFO PODEMOS CREAR OBJETOS PARA LEER EN BYTES O TEXTO PLANO
                //VAMOS A UTILIZAR using PARA CREAR EL OBJETO, UTILIZARLO Y DESTRUIRLO A LA VEZ
                using (TextWriter writer = file.CreateText())
                {
                    //ESCRIBIR
                    string output = JsonConvert.SerializeObject(this.productos);
                    await writer.WriteAsync(output);
                    //INDEPENDIENTEMENTE DE A TEXTO PLANO O BYTE AL ESCRIBIR DEBEMOS LIBERAR EL FLUJO DE MEMORIA
                    // O CERRAR EL FICHERO
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstproductos.Items.Clear();
                this.txtnombre.Text = "";
                this.txtprecio.Text = "";
            }
        }

        private async void btnread_Click(object sender, EventArgs e)
        {
            this.lstproductos.Items.Clear();
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                string path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    string contenido = await reader.ReadToEndAsync();
                    this.productos = JsonConvert.DeserializeObject<List<Producto>>(contenido);
                    foreach (Producto prod in this.productos)
                    {
                        this.lstproductos.Items.Add("Nombre: " + prod.Nombre + ", " + prod.Precio.ToString()); 
                    }
                    reader.Close();
                }
            }
            SetLabelContador();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (this.productos.Count() >= 1){
                this.txtnombre.Text = this.productos[0].Nombre;
                this.txtprecio.Text = this.productos[0].Precio.ToString();
            }
            this.currentIndex = 0;
            SetLabelContador();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            if (this.productos.Count() >= 1)
            {
                this.txtnombre.Text = this.productos[this.productos.Count()-1].Nombre;
                this.txtprecio.Text = this.productos[this.productos.Count() - 1].Precio.ToString();
            }
            this.currentIndex = this.productos.Count() - 1;
            SetLabelContador();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (this.productos.Count > 0 && this.currentIndex != 0)
            {
                this.currentIndex--;
                this.txtnombre.Text = this.productos[currentIndex].Nombre;
                this.txtprecio.Text = this.productos[currentIndex].Precio.ToString();
                SetLabelContador();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (this.productos.Count > 0 && this.currentIndex < (this.productos.Count()-1))
            {
                this.currentIndex++;
                this.txtnombre.Text = this.productos[currentIndex].Nombre;
                this.txtprecio.Text = this.productos[currentIndex].Precio.ToString();
                SetLabelContador();
            }
        }

        private void SetLabelContador()
        {
            Producto currentProd = this.productos[this.currentIndex];
            this.lblcontadorproductos.Text = "Producto " + (this.currentIndex + 1) + " de " +
                this.productos.Count();
        }
    }
}
