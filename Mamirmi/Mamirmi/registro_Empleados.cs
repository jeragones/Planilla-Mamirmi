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
    public partial class registro_Empleados : Form
    {
      public registro_Empleados()
        {
            InitializeComponent();
        }

        metodos_Buscadores instancia = new metodos_Buscadores();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pbl_Información_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registro_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (txt_cuentaBN.Text.Equals("") || txtCuentaBp.Text.Equals("") || txtProfesion.Text.Equals("") || txtManipulacionA.Text.Equals("")
               || txtEnfermedades.Text.Equals("") || txtCarne.Text.Equals("") || txtExperiencia.Text.Equals("") || txtFIngreso.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los datos", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //instancia.insertar_Empleado("11","1","bncuenta","bpcuenta", 
                //   "Gerente", "Universidad","Curso general","Ninguna","123456",
                //  "4 años","daddadsa","Administrativo",null,null,"Activo");
                instancia.insertar_Empleado(cmbPersonaid.Text, txt_cuentaBN.Text, txtCuentaBp.Text,
                    txtProfesion.Text, cmbEstudios.Text, txtManipulacionA.Text, txtEnfermedades.Text,
                    txtCarne.Text, txtExperiencia.Text, txtFIngreso.Text, cmbDepartamento.Text, "", "", "Activo");
                txt_cuentaBN.Text = "";
                txtCuentaBp.Text = "";
                txtProfesion.Text = "";
                txtManipulacionA.Text = "";
                txtEnfermedades.Text = "";
                txtCarne.Text = "";
                txtExperiencia.Text = "";
                txtFIngreso.Text = ""; 
            }
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
    }
}
