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
using Mamirmi.Data;
using Mamirmi.Controller;

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
            Mamirmi_Principal nn = new Mamirmi_Principal();
            nn.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

         private void rowautosize()
         {
             dgv_Buscar.Columns[0].Width = (dgv_Buscar.Width / 5)-20;
             dgv_Buscar.Columns[1].Width = (dgv_Buscar.Width / 5);
             dgv_Buscar.Columns[2].Width = (dgv_Buscar.Width / 5);
             dgv_Buscar.Columns[3].Width = (dgv_Buscar.Width / 5);
             dgv_Buscar.Columns[4].Width = (dgv_Buscar.Width / 5);
             dgv_Buscar.BackgroundColor = this.BackColor;
             dgv_Buscar.BorderStyle = BorderStyle.None;
         }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DBcontroller controlador = new DBcontroller();
                label1.Text = "";
                dgv_Buscar.DataSource = controlador.view_Personas(txt_Buscar.Text);
                rowautosize();
            }
            catch (Exception)
            {
                label1.Text = "Error Inesperado favor intente mas tarde.";
                label1.ForeColor = Color.Red;
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBcontroller controlador = new DBcontroller();
                label1.Text = "";
                dgv_Buscar.DataSource = controlador.view_Personas(txt_Buscar.Text);
                rowautosize();
            }
            catch (Exception)
            {
                label1.Text = "Error Inesperado favor intente mas tarde.";
                label1.ForeColor = Color.Red;
            }
        }

        private void dgv_Buscar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }
    }
}
