using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mamirmi
{
    public partial class Mamirmi_Principal : Form
    {
        public Mamirmi_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mamirmi_Registro nn = new Mamirmi_Registro();
            nn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mamirmi_Buscadores nn = new Mamirmi_Buscadores();
            nn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mamirmi_Loggin nn = new Mamirmi_Loggin();
            nn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
