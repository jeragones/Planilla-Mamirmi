namespace Mamirmi
{
    partial class registro_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AgregarEmpleado = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCuentaBp = new System.Windows.Forms.TextBox();
            this.txt_cuentaBN = new System.Windows.Forms.TextBox();
            this.lbl_CuentaBP = new System.Windows.Forms.Label();
            this.lbl_cuantabn = new System.Windows.Forms.Label();
            this.cmbEstudios = new System.Windows.Forms.ComboBox();
            this.cmbPersonaid = new System.Windows.Forms.ComboBox();
            this.lbl_Persona = new System.Windows.Forms.Label();
            this.txtEnfermedades = new System.Windows.Forms.TextBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.lbl_Profesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbl_Información = new System.Windows.Forms.Panel();
            this.txtManipulacionA = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtFIngreso = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pbl_Información.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(569, 379);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(96, 34);
            this.btn_AgregarEmpleado.TabIndex = 15;
            this.btn_AgregarEmpleado.Text = "Agregar";
            this.btn_AgregarEmpleado.UseVisualStyleBackColor = true;
            this.btn_AgregarEmpleado.Click += new System.EventHandler(this.btn_AgregarEmpleado_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(89, 13);
            this.lbl_Titulo.TabIndex = 14;
            this.lbl_Titulo.Text = "Nuevo Empleado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtCuentaBp);
            this.panel1.Controls.Add(this.txt_cuentaBN);
            this.panel1.Controls.Add(this.lbl_CuentaBP);
            this.panel1.Controls.Add(this.lbl_cuantabn);
            this.panel1.Controls.Add(this.cmbEstudios);
            this.panel1.Controls.Add(this.cmbPersonaid);
            this.panel1.Controls.Add(this.lbl_Persona);
            this.panel1.Controls.Add(this.txtEnfermedades);
            this.panel1.Controls.Add(this.txtProfesion);
            this.panel1.Controls.Add(this.lbl_Profesion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(52, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 319);
            this.panel1.TabIndex = 13;
            // 
            // txtCuentaBp
            // 
            this.txtCuentaBp.Location = new System.Drawing.Point(93, 213);
            this.txtCuentaBp.Name = "txtCuentaBp";
            this.txtCuentaBp.Size = new System.Drawing.Size(154, 20);
            this.txtCuentaBp.TabIndex = 13;
            // 
            // txt_cuentaBN
            // 
            this.txt_cuentaBN.Location = new System.Drawing.Point(93, 171);
            this.txt_cuentaBN.Name = "txt_cuentaBN";
            this.txt_cuentaBN.Size = new System.Drawing.Size(154, 20);
            this.txt_cuentaBN.TabIndex = 12;
            // 
            // lbl_CuentaBP
            // 
            this.lbl_CuentaBP.AutoSize = true;
            this.lbl_CuentaBP.Location = new System.Drawing.Point(23, 213);
            this.lbl_CuentaBP.Name = "lbl_CuentaBP";
            this.lbl_CuentaBP.Size = new System.Drawing.Size(58, 13);
            this.lbl_CuentaBP.TabIndex = 11;
            this.lbl_CuentaBP.Text = "Cuenta BP";
            // 
            // lbl_cuantabn
            // 
            this.lbl_cuantabn.AutoSize = true;
            this.lbl_cuantabn.Location = new System.Drawing.Point(20, 171);
            this.lbl_cuantabn.Name = "lbl_cuantabn";
            this.lbl_cuantabn.Size = new System.Drawing.Size(59, 13);
            this.lbl_cuantabn.TabIndex = 10;
            this.lbl_cuantabn.Text = "Cuenta BN";
            // 
            // cmbEstudios
            // 
            this.cmbEstudios.FormattingEnabled = true;
            this.cmbEstudios.Location = new System.Drawing.Point(93, 273);
            this.cmbEstudios.Name = "cmbEstudios";
            this.cmbEstudios.Size = new System.Drawing.Size(154, 21);
            this.cmbEstudios.TabIndex = 9;
            // 
            // cmbPersonaid
            // 
            this.cmbPersonaid.FormattingEnabled = true;
            this.cmbPersonaid.Location = new System.Drawing.Point(93, 26);
            this.cmbPersonaid.Name = "cmbPersonaid";
            this.cmbPersonaid.Size = new System.Drawing.Size(154, 21);
            this.cmbPersonaid.TabIndex = 7;
            // 
            // lbl_Persona
            // 
            this.lbl_Persona.AutoSize = true;
            this.lbl_Persona.Location = new System.Drawing.Point(23, 26);
            this.lbl_Persona.Name = "lbl_Persona";
            this.lbl_Persona.Size = new System.Drawing.Size(46, 13);
            this.lbl_Persona.TabIndex = 6;
            this.lbl_Persona.Text = "Persona";
            // 
            // txtEnfermedades
            // 
            this.txtEnfermedades.Location = new System.Drawing.Point(93, 129);
            this.txtEnfermedades.Name = "txtEnfermedades";
            this.txtEnfermedades.Size = new System.Drawing.Size(154, 20);
            this.txtEnfermedades.TabIndex = 5;
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(93, 81);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(154, 20);
            this.txtProfesion.TabIndex = 4;
            // 
            // lbl_Profesion
            // 
            this.lbl_Profesion.AutoSize = true;
            this.lbl_Profesion.Location = new System.Drawing.Point(20, 79);
            this.lbl_Profesion.Name = "lbl_Profesion";
            this.lbl_Profesion.Size = new System.Drawing.Size(51, 13);
            this.lbl_Profesion.TabIndex = 0;
            this.lbl_Profesion.Text = "Profesión";
            this.lbl_Profesion.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enfermedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grado Academico";
            // 
            // pbl_Información
            // 
            this.pbl_Información.BackColor = System.Drawing.Color.Silver;
            this.pbl_Información.Controls.Add(this.txtManipulacionA);
            this.pbl_Información.Controls.Add(this.cmbDepartamento);
            this.pbl_Información.Controls.Add(this.txtFIngreso);
            this.pbl_Información.Controls.Add(this.txtExperiencia);
            this.pbl_Información.Controls.Add(this.txtCarne);
            this.pbl_Información.Controls.Add(this.label4);
            this.pbl_Información.Controls.Add(this.label7);
            this.pbl_Información.Controls.Add(this.label5);
            this.pbl_Información.Controls.Add(this.label6);
            this.pbl_Información.Controls.Add(this.label3);
            this.pbl_Información.Location = new System.Drawing.Point(364, 46);
            this.pbl_Información.Name = "pbl_Información";
            this.pbl_Información.Size = new System.Drawing.Size(301, 319);
            this.pbl_Información.TabIndex = 12;
            // 
            // txtManipulacionA
            // 
            this.txtManipulacionA.Location = new System.Drawing.Point(28, 55);
            this.txtManipulacionA.Name = "txtManipulacionA";
            this.txtManipulacionA.Size = new System.Drawing.Size(230, 20);
            this.txtManipulacionA.TabIndex = 10;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(137, 254);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 11;
            // 
            // txtFIngreso
            // 
            this.txtFIngreso.Location = new System.Drawing.Point(137, 213);
            this.txtFIngreso.Name = "txtFIngreso";
            this.txtFIngreso.Size = new System.Drawing.Size(121, 20);
            this.txtFIngreso.TabIndex = 10;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Location = new System.Drawing.Point(137, 157);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(121, 20);
            this.txtExperiencia.TabIndex = 9;
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(137, 105);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(121, 20);
            this.txtCarne.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carné";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Area de Trabajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Exp. Laboral";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cursos Referentes Manipulación de Alimentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.personasToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // registro_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_AgregarEmpleado);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbl_Información);
            this.Name = "registro_Empleados";
            this.Text = "registro_Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pbl_Información.ResumeLayout(false);
            this.pbl_Información.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarEmpleado;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCuentaBp;
        private System.Windows.Forms.TextBox txt_cuentaBN;
        private System.Windows.Forms.Label lbl_CuentaBP;
        private System.Windows.Forms.Label lbl_cuantabn;
        private System.Windows.Forms.ComboBox cmbEstudios;
        private System.Windows.Forms.ComboBox cmbPersonaid;
        private System.Windows.Forms.Label lbl_Persona;
        private System.Windows.Forms.TextBox txtEnfermedades;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label lbl_Profesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pbl_Información;
        private System.Windows.Forms.TextBox txtManipulacionA;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtFIngreso;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
    }
}