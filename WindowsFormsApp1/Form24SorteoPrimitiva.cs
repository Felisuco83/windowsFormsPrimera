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
    public partial class Form24SorteoPrimitiva : Form
    {
        List<int> numeros;
        List<int> elegidos;
        List<int> numerosSorteo;
        List<int> coincidencias;
        bool sorteado;
        public Form24SorteoPrimitiva()
        {
            InitializeComponent();
            numeros = new List<int>();
            numerosSorteo = new List<int>();
            coincidencias = new List<int>();
            elegidos = new List<int>();
            sorteado = false;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            this.numeros.Clear();
            this.numerosSorteo.Clear();
            this.elegidos.Clear();
            this.coincidencias.Clear();
            this.panel1.Controls.Clear();
            this.lstelegidos.Items.Clear();
            this.sorteado = false;
            var rnd = new Random();
            int rndNum;
            for (int i = 0; i<20; i++)
            {
                rndNum = rnd.Next(1, 100);
                if(!this.numeros.Contains(rndNum))
                {
                    this.numeros.Add(rndNum);
                } else
                {
                    i--;
                    continue;
                }
            }
            var newBtn = new Button();
            int index = 0;
            int posx = 5;
            int posy = 5;
            foreach ( int num in this.numeros)
            {
                newBtn = new Button();
                newBtn.Size = new Size(50,25);
                newBtn.Text = num.ToString();
                if (index %4 == 0)
                {
                    posy += 40;
                    posx = 5;
                } else
                {
                    posx += 60;
                }
                newBtn.Location = new Point(posx, posy);
                newBtn.BackColor = Color.White;
                this.panel1.Controls.Add(newBtn);
                newBtn.Click += AddOrRemoveBet;
                index++;
            }
        }

        private void AddOrRemoveBet(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if(btn.BackColor == Color.White && this.lstelegidos.Items.Count < 6)
            {
                btn.BackColor = Color.Yellow;
                this.lstelegidos.Items.Add(btn.Text);
            } else if(btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.White;
                this.lstelegidos.Items.Remove(btn.Text);
            }
        }

        private void btnsortear_Click(object sender, EventArgs e)
        {
            if (!this.sorteado)
            {
                Random rnd = new Random();
                int rndNum;
                for (int i = 0; i < 6; i++)
                {
                    rndNum = numeros[rnd.Next(numeros.Count)];
                    if (!this.numerosSorteo.Contains(rndNum))
                    {
                        this.numerosSorteo.Add(rndNum);
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                foreach (var item in this.lstelegidos.Items)
                {
                    this.elegidos.Add(int.Parse(item.ToString()));
                }
                this.coincidencias = this.elegidos.Intersect(numerosSorteo).ToList();
                foreach (Button btn in this.panel1.Controls)
                {
                    if (coincidencias.Contains(int.Parse(btn.Text)))
                    {
                        btn.BackColor = Color.LightGreen;
                    }
                    if (btn.BackColor == Color.White && numerosSorteo.Contains(int.Parse(btn.Text)))
                    {
                        btn.BackColor = Color.OrangeRed;
                    }
                }
                this.sorteado = true;
            }   
        }
    }
}
