using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mamirmi_s_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hoursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Mamirmi_s_FormDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Mamirmi_s_FormDataSet.Hours' Puede moverla o quitarla según sea necesario.
            this.hoursTableAdapter.Fill(this._Mamirmi_s_FormDataSet.Hours);

        }
    }
}
