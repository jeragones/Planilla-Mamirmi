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

namespace Mamirmi
{
    public partial class formPersona : Form
    {
        DBcontroller Controlador=new DBcontroller();        
        public formPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador.InsertPersona();
        }
    }
}
