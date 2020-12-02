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

namespace WindowsFormsApp1
{
    public partial class FormFicherosPlanos : Form
    {
        public FormFicherosPlanos()
        {
            InitializeComponent();
        }

        private async void btnguardar_Click(object sender, EventArgs e)
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
                    await writer.WriteAsync(this.GetStringNombres());
                    //INDEPENDIENTEMENTE DE A TEXTO PLANO O BYTE AL ESCRIBIR DEBEMOS LIBERAR EL FLUJO DE MEMORIA
                    // O CERRAR EL FICHERO
                    await writer.FlushAsync();
                    writer.Close();
                }
                this.lstnombres.Items.Clear();
                this.txttexto.Text = "";
                this.SetStringNombres(this.lstnombres.Text);
            }
        }

        private async void btnleer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult respuesta = open.ShowDialog();
            if (respuesta == DialogResult.OK) 
            {
                string path = open.FileName;
                FileInfo file = new FileInfo(path);
                using (TextReader reader = file.OpenText())
                {
                    string contenido = await reader.ReadToEndAsync();
                    reader.Close();
                    this.txttexto.Text = contenido;
                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            string nombre = this.txtnombre.Text;
            this.lstnombres.Items.Add(nombre);
            this.txtnombre.Text = "";
            this.txtnombre.Focus();
        }
        public string GetStringNombres()
        {
            string datos = "";
            foreach(string nombre in this.lstnombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        public void SetStringNombres( string data )
        {
            List<string> nombres = data.Split(',').ToList<string>();
            this.lstnombres.Items.Clear();
            foreach (string nombre in nombres)
            {
                this.lstnombres.Items.Add(nombre);
            }
        }
    }
}
