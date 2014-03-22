using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mamirmi.Controller;
using Mamirmi.Data;

namespace Mamirmi
{
    public partial class Mamirmi_Registro : Form
    {
        DBcontroller Controlador=new DBcontroller();        
        public Mamirmi_Registro()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Agregar")
            {
                Persona nn = new Persona();
                nn.ID = textBox1.Text;
                nn.nombre = textBox2.Text;
                nn.apellidos = textBox3.Text;
                nn.edad = Int32.Parse(numericUpDown1.Value.ToString());
                nn.EstadoCivil = comboBox2.SelectedItem.ToString();
                nn.nacionalidad = comboBox1.SelectedItem.ToString();
                nn.direccion = textBox4.Text;
                nn.sexo = comboBox3.SelectedItem.ToString();
                nn.Hijos = Int32.Parse(numericUpDown2.Value.ToString());
                if (nn.ID != "" && nn.nombre != "" && nn.apellidos != "" && nn.direccion != "")
                {
                    nn.fecha_de_ingreso = dateTimePicker1.Value.Date;
                    label11.Text = Controlador.Insert_Persona(nn);
                    dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
                    rowautosize();
                }
                else
                {
                    label11.Text = "Revisar parametros de entrada.";
                    label11.ForeColor = Color.Red;
                }
            }
            else
            {
                Persona nn = new Persona();
                nn.ID = textBox1.Text;
                nn.nombre = textBox2.Text;
                nn.apellidos = textBox3.Text;
                nn.edad = Int32.Parse(numericUpDown1.Value.ToString());
                nn.EstadoCivil = comboBox2.SelectedItem.ToString();
                nn.nacionalidad = comboBox1.SelectedItem.ToString();
                nn.direccion = textBox4.Text;
                nn.sexo = comboBox3.SelectedItem.ToString();
                nn.Hijos = Int32.Parse(numericUpDown2.Value.ToString());
                nn.fecha_de_ingreso = dateTimePicker1.Value;
                label11.Text = Controlador.Update_Persona(nn);
                dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
                rowautosize();
            }
        }


        private void formPersona_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
            rowautosize();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
            rowautosize();
        }

        private void rowautosize()
        {
            dataGridView1.Columns[0].Width = (groupBox3.Width/3);
            dataGridView1.Columns[1].Width = (groupBox3.Width / 3) + (groupBox3.Width / 4);
            dataGridView1.BackgroundColor = this.BackColor;
            dataGridView1.BorderStyle = BorderStyle.None;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            int[] selecion = new Int32[2];
            selecion = null;
            selecion = new Int32[2];
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Seleccione una celda.", "Alerta");
                }
                else
                {
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        selecion[0] = dataGridView1.SelectedCells[i].RowIndex;
                        selecion[1] = dataGridView1.SelectedCells[i].ColumnIndex;
                    }

                    Persona nn = Controlador.Get_Persona(dataGridView1.Rows[selecion[0]].Cells[0].Value.ToString(), dataGridView1.Rows[selecion[0]].Cells[1].Value.ToString());
                    textBox1.Text=nn.ID.ToString();
                    textBox2.Text = nn.nombre;
                    textBox3.Text = nn.apellidos;
                    numericUpDown1.Value = nn.edad;
                    comboBox2.SelectedItem = nn.EstadoCivil;
                    comboBox1.SelectedItem = nn.nacionalidad;
                    textBox4.Text = nn.direccion;
                    comboBox3.SelectedItem = nn.sexo;
                    numericUpDown2.Value = (decimal)nn.Hijos;
                    dateTimePicker1.Value = nn.fecha_de_ingreso;
                    button1.Text = "Actualizar";
                    tabControl1.SelectedIndex=1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                numericUpDown1.Value = 18;
                comboBox2.SelectedItem = "Soltero";
                comboBox1.SelectedItem = "Costa Rica";
                textBox4.Text = string.Empty;
                comboBox3.SelectedItem = "Masculino";
                numericUpDown2.Value = 0;
                dateTimePicker1.Value = DateTime.Today;
                button1.Text = "Agregar";
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
            Mamirmi_Registro nn = new Mamirmi_Registro();
            nn.Show();
            this.Hide();
        }*/

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (button1.Text == "Agregar")
            //{
                Persona nn = new Persona();
                nn.ID = txt_Cedula.Text;
                nn.nombre = txt_Nombre.Text;
                nn.apellidos = txt_Apellidos.Text;
                nn.fecha_de_ingreso = DateTime.UtcNow.Date;
                //nn.carne = txt_Carne.Text;
                //nn.cuenta_BN = txt_BancoNacional.Text;
                //nn.cuenta_BP = txt_BancoPopular.Text;
                //nn.departamento = cmb_Departamento.Text;
                //nn.numeroComprobante = txt_NumeroComprabante.Text;
                //nn.estado = true;

                if (nn.ID != "" && nn.nombre != "" && nn.apellidos != "" /*&& nn.carne != "" && 
                  * nn.fecha_de_ingreso.GetHashCode() != 0 && nn.departamento != "" && nn.cuenta_BN != "" &&
                    nn.numeroComprobante != 0*/)
                {
                    nn.fecha_de_ingreso = DateTime.UtcNow.Date;
                    //label11.Text = Controlador.Insert_Persona(nn);
                    //dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
                    //rowautosize();
                }
                else
                {
                    lbl_error.Text = "Revisar parametros de entrada.";
                    lbl_error.ForeColor = Color.Red;
                }
        /*    }
          //  else
            //{
                Persona nn = new Persona();
                nn.ID = textBox1.Text;
                nn.nombre = textBox2.Text;
                nn.apellidos = textBox3.Text;
                //nn.edad = Int32.Parse(numericUpDown1.Value.ToString());
                //nn.EstadoCivil = comboBox2.SelectedItem.ToString();
                //nn.nacionalidad = comboBox1.SelectedItem.ToString();
                //nn.direccion = textBox4.Text;
                //nn.sexo = comboBox3.SelectedItem.ToString();
                //nn.Hijos = Int32.Parse(numericUpDown2.Value.ToString());
                //nn.fecha_de_ingreso = dateTimePicker1.Value;
                //label11.Text = Controlador.Update_Persona(nn);
                //dataGridView1.DataSource = Controlador.view_Personas(textBox5.Text);
                rowautosize();
            }*/
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Mamirmi_Loggin nn = new Mamirmi_Loggin();
            nn.Show();
            this.Hide();
        }
    }
}
