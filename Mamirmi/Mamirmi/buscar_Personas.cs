using Buscadores;
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
    public partial class buscar_Personas : Form
    {
        public buscar_Personas()
        {

            InitializeComponent();
        }

        metodos_Buscadores instancia = new metodos_Buscadores();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cmb_Filtrar.Text == "Carné" && txt_Buscar.Text != "")
            {
                instancia.buscar_PersonasCarne(txt_Buscar.Text, dgv_Buscar);
            }
            else if (cmb_Filtrar.Text == "Nombre" && txt_Buscar.Text != "")
            {
                instancia.buscar_PersonasNombre(txt_Buscar.Text, dgv_Buscar);
            }
            else if (cmb_Filtrar.Text == "Identificación" && txt_Buscar.Text != "")
            {
                instancia.buscar_PersonasId(txt_Buscar.Text, dgv_Buscar);
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Error!",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void cmb_Filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Informacion_Click(object sender, EventArgs e)
        {

        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro_Empleados nn = new registro_Empleados();
            nn.Show();
            this.Hide();
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
    }
}
