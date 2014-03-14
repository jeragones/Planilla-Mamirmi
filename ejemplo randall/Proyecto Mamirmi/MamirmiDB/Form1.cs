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
using System.Data.Sql;

namespace MamirmiDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Persona(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text,textBox8.Text, textBox9.Text));
            
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Mamirmi_s_FormDataSet);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cargar_personas() {
            SqlConnection conn = new SqlConnection("Data Source=201.191.100.11\\RANGUROSERVER;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed");
            conn.Open();
            string consulta = "Select ID_Persona from Person where Department = 'Pelador'";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read()) {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }
        private void cargar_personas2()
        {
            SqlConnection conn = new SqlConnection("Data Source=201.191.100.11\\RANGUROSERVER;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed");
            conn.Open();
            string consulta = "Select ID_Persona from Person";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }


        private void cargar_personas3()
        {
            SqlConnection conn = new SqlConnection("Data Source=201.191.100.11\\RANGUROSERVER;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed");
            conn.Open();
            string consulta = "Select ID_Persona from Person inner join Employee on ID_Persona = ID_Person";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox3.Items.Clear();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }


        private void cargar_personas4()
        {
            SqlConnection conn = new SqlConnection("Data Source=201.191.100.11\\RANGUROSERVER;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed");
            conn.Open();
            string consulta = "Select ID_Persona from Person inner join Employee on ID_Persona = ID_Person";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox4.Items.Clear();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }

        private void cargar_personas5()
        {
            SqlConnection conn = new SqlConnection("Data Source=201.191.100.11\\RANGUROSERVER;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed");
            conn.Open();
            string consulta = "Select ID_Persona from Person";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            comboBox5.Items.Clear();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Barril(comboBox1.Text, textBox11.Text, textBox10.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargar_personas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cargar_personas2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Telefono(comboBox2.Text, textBox12.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cargar_personas3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Vacacion(comboBox3.Text,textBox13.Text, textBox14.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cargar_personas4();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Aguinaldo(textBox16.Text, textBox15.Text, comboBox4.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cargar_personas5();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Database metodos = new Database();
            MessageBox.Show(metodos.insertar_Empleado(textBox17.Text, comboBox5.Text, textBox18.Text, textBox19.Text, textBox20.Text));
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
    }
}
