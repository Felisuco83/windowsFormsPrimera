using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases;

namespace WindowsFormsApp1
{
    public partial class Form29SerializarCoches : Form
    {
        public XmlSerializer serial;
        public Coches coches;
        public Form29SerializarCoches()
        {
            InitializeComponent();
            coches = new Coches();
            serial = new XmlSerializer(typeof(Coches));

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            var coche = new Coche();
            coche.Marca = this.txtmarca.Text;
            coche.Modelo = this.txtmodelo.Text;
            ImageConverter converter = new ImageConverter();
            coche.Imagen =  (byte[])converter.ConvertTo(this.pictureBox1.Image, typeof(byte[]));
            coches.Add(coche);
            this.lstcoches.Items.Add(coche.Marca + " " + coche.Modelo);
            this.txtmarca.Text = "";
            this.txtmodelo.Text = "";

        }

        private async void btnguardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("coches.xml");
            this.serial.Serialize(writer, this.coches);
            await writer.FlushAsync();
            writer.Close();
            this.lstcoches.Items.Clear();
            this.txtmarca.Text = "";
            this.txtmodelo.Text = "";
        }
       
        private void PintarCoches()
        {
            foreach(Coche coche in this.coches)
            {
                this.lstcoches.Items.Add(coche.Marca + " " + coche.Modelo);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("coches.xml");
            this.coches = (Coches)this.serial.Deserialize(reader);
            PintarCoches();
        }

        private void btnloadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //ShowDialog siempre nos va a devolver DialogResult
            DialogResult respuesta = open.ShowDialog();
            ImageFormat format = ImageFormat.Jpeg;
            if (respuesta == DialogResult.OK)
            {
                string path = open.FileName;
                this.pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }

        private void lstcoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstcoches.SelectedIndex;
            MemoryStream ms = new MemoryStream(this.coches[index].Imagen);
            this.pictureBox1.Image = Image.FromStream(ms);
            this.txtmarca.Text = this.coches[index].Marca;
            this.txtmodelo.Text = this.coches[index].Modelo;
        }
    }
}
