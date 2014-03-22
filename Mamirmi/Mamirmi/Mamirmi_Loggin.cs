using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mamirmi
{
    public partial class Mamirmi_Loggin : Form
    {
        public Mamirmi_Loggin()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=localhost;Initial Catalog=Mamirmi;Integrated Security=True");
            try
            {
                myConnection.Open();
                object[] res = Login.log_in(txtUsuario.Text, txtContraseña.Text);
                if (res[0].Equals(true))
                {
                    if (res[1].Equals(1))
                    {
                        MessageBox.Show("Conexión Establecida\n Bienvenido\n Tipo de Usuario: Administrador");

                    }
                    if (res[1].Equals(2))
                    {
                        Mamirmi_Registro nn = new Mamirmi_Registro();
                        //Form1 nn = new Form1();
                        nn.Show();
                        this.Hide();
                    }
                    if (res[1].Equals(3))
                    {
                        MessageBox.Show("Conexión Establecida\n Bienvenido\n Tipo de Usuario: Planilla");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Fallo la Conexión con la Base de Datos\n" + ex.Message);
            }
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }
    }
}
