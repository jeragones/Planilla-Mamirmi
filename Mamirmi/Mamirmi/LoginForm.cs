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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=localhost;Initial Catalog=prueba_login;Integrated Security=True");
            try
            {
                myConnection.Open();

                if (Login.log_in(txtUsuario.Text, txtContraseña.Text) == true)
                {

                    MessageBox.Show("Conexión Establecida\n Bienvenido");
                    this.Dispose();
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
