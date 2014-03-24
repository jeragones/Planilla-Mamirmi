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
    public partial class Mamirmi_Buscadores : Form
    {
        public Mamirmi_Buscadores()
        {

            InitializeComponent();
        }

        metodos_Buscadores instancia = new metodos_Buscadores();

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {
            Mamirmi_Registro nn = new Mamirmi_Registro();
            nn.Show();
            this.Hide();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Mamirmi_Loggin nn = new Mamirmi_Loggin();
            nn.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_Buscar.Rows.Clear();

            if (chk_Nombre.Checked)
            {
                instancia.buscar_PersonasNombre(txt_Buscar.Text, dgv_Buscar);
            }
            if (chk_Carne.Checked)
            {
                instancia.buscar_PersonasCarne(txt_Buscar.Text, dgv_Buscar);
            }
            if (chk_Identificacion.Checked)
            {
                instancia.buscar_PersonasId(txt_Buscar.Text, dgv_Buscar);
            }
            if (chk_Estado.Checked)
            {
                instancia.buscar_PersonasEstado(cbx_activo.Text, dgv_Buscar);
            }
            if (!chk_Identificacion.Checked && !chk_Nombre.Checked && !chk_Carne.Checked && !chk_Estado.Checked)
            {
                instancia.buscar_PersonasSinFiltro(dgv_Buscar);
            }
        }

        private void chk_Estado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Estado.Checked)
            {
                cbx_activo.Visible = true;
            }
            else
            {
                cbx_activo.Visible = false;
            }
        }
    }
}
