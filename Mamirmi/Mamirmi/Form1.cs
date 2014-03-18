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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPersona nn = new formPersona();
            nn.Show();
            this.Hide();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscar_Personas nn = new buscar_Personas();
            nn.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro_Empleados nn = new registro_Empleados();
            nn.Show();
            this.Hide();
        }
    }
}
