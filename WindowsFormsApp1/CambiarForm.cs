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
    public partial class CambiarForm : Form
    {
        public CambiarForm()
        {
            InitializeComponent();
        }

        private void CambiarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtposx.Text);
            int posY = int.Parse(this.txtposy.Text);
            this.btnpos.Location = new Point(posX,posY);
        }

        private void Color_Click(object sender, EventArgs e)
        {
            this.FindForm().BackColor = Color.FromArgb(int.Parse(txtrojo.Text), int.Parse(txtverde.Text), int.Parse(txtazul.Text));
        }
    }
}
