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
        


        /*private void btn_Buscar_Click(object sender, EventArgs e)
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

        }*/

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
    }
}
