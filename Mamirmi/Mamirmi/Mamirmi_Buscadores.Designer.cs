﻿namespace Mamirmi
{
    partial class Mamirmi_Buscadores
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbx_activo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chk_Salida = new System.Windows.Forms.CheckBox();
            this.chk_Entrada = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_DepartamentoBusqueda = new System.Windows.Forms.ComboBox();
            this.chk_Estado = new System.Windows.Forms.CheckBox();
            this.chk_Nombre = new System.Windows.Forms.CheckBox();
            this.chk_Carne = new System.Windows.Forms.CheckBox();
            this.chk_Identificacion = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Buscar = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Busqueda de Empleados";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbx_activo);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_Buscar);
            this.panel4.Location = new System.Drawing.Point(509, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 140);
            this.panel4.TabIndex = 30;
            // 
            // cbx_activo
            // 
            this.cbx_activo.FormattingEnabled = true;
            this.cbx_activo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_activo.Location = new System.Drawing.Point(8, 91);
            this.cbx_activo.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_activo.Name = "cbx_activo";
            this.cbx_activo.Size = new System.Drawing.Size(188, 24);
            this.cbx_activo.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar ...";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(8, 49);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(307, 22);
            this.txt_Buscar.TabIndex = 7;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.cmb_DepartamentoBusqueda);
            this.panel2.Controls.Add(this.chk_Estado);
            this.panel2.Controls.Add(this.chk_Nombre);
            this.panel2.Controls.Add(this.chk_Carne);
            this.panel2.Controls.Add(this.chk_Identificacion);
            this.panel2.Location = new System.Drawing.Point(16, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 140);
            this.panel2.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departamento";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chk_Salida);
            this.panel5.Controls.Add(this.chk_Entrada);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Location = new System.Drawing.Point(256, 62);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 72);
            this.panel5.TabIndex = 7;
            // 
            // chk_Salida
            // 
            this.chk_Salida.AutoSize = true;
            this.chk_Salida.Location = new System.Drawing.Point(143, 46);
            this.chk_Salida.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Salida.Name = "chk_Salida";
            this.chk_Salida.Size = new System.Drawing.Size(69, 21);
            this.chk_Salida.TabIndex = 7;
            this.chk_Salida.Text = "Salida";
            this.chk_Salida.UseVisualStyleBackColor = true;
            // 
            // chk_Entrada
            // 
            this.chk_Entrada.AutoSize = true;
            this.chk_Entrada.Location = new System.Drawing.Point(5, 46);
            this.chk_Entrada.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Entrada.Name = "chk_Entrada";
            this.chk_Entrada.Size = new System.Drawing.Size(80, 21);
            this.chk_Entrada.TabIndex = 6;
            this.chk_Entrada.Text = "Entrada";
            this.chk_Entrada.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmb_DepartamentoBusqueda
            // 
            this.cmb_DepartamentoBusqueda.FormattingEnabled = true;
            this.cmb_DepartamentoBusqueda.Items.AddRange(new object[] {
            "Pelado\t",
            "Fruta",
            "Empaque",
            "Limpieza Diurna",
            "Limpiza Nocturna",
            "Hoja",
            "Descarga",
            "Planta Descarga",
            "Encargado de Camara",
            "Pesadora",
            "Control de  Calidad",
            "Bodega",
            "Asistente de Empaque"});
            this.cmb_DepartamentoBusqueda.Location = new System.Drawing.Point(256, 28);
            this.cmb_DepartamentoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_DepartamentoBusqueda.Name = "cmb_DepartamentoBusqueda";
            this.cmb_DepartamentoBusqueda.Size = new System.Drawing.Size(221, 24);
            this.cmb_DepartamentoBusqueda.TabIndex = 6;
            this.cmb_DepartamentoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmb_DepartamentoBusqueda_SelectedIndexChanged);
            // 
            // chk_Estado
            // 
            this.chk_Estado.AutoSize = true;
            this.chk_Estado.Location = new System.Drawing.Point(16, 100);
            this.chk_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Estado.Name = "chk_Estado";
            this.chk_Estado.Size = new System.Drawing.Size(74, 21);
            this.chk_Estado.TabIndex = 4;
            this.chk_Estado.Text = "Estado";
            this.chk_Estado.UseVisualStyleBackColor = true;
            // 
            // chk_Nombre
            // 
            this.chk_Nombre.AutoSize = true;
            this.chk_Nombre.Location = new System.Drawing.Point(16, 15);
            this.chk_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Nombre.Name = "chk_Nombre";
            this.chk_Nombre.Size = new System.Drawing.Size(80, 21);
            this.chk_Nombre.TabIndex = 0;
            this.chk_Nombre.Text = "Nombre";
            this.chk_Nombre.UseVisualStyleBackColor = true;
            // 
            // chk_Carne
            // 
            this.chk_Carne.AutoSize = true;
            this.chk_Carne.Location = new System.Drawing.Point(16, 43);
            this.chk_Carne.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Carne.Name = "chk_Carne";
            this.chk_Carne.Size = new System.Drawing.Size(68, 21);
            this.chk_Carne.TabIndex = 1;
            this.chk_Carne.Text = "Carné";
            this.chk_Carne.UseVisualStyleBackColor = true;
            // 
            // chk_Identificacion
            // 
            this.chk_Identificacion.AutoSize = true;
            this.chk_Identificacion.Location = new System.Drawing.Point(16, 71);
            this.chk_Identificacion.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Identificacion.Name = "chk_Identificacion";
            this.chk_Identificacion.Size = new System.Drawing.Size(112, 21);
            this.chk_Identificacion.TabIndex = 2;
            this.chk_Identificacion.Text = "Identificación";
            this.chk_Identificacion.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgv_Buscar);
            this.panel3.Controls.Add(this.btn_Atras);
            this.panel3.Location = new System.Drawing.Point(16, 194);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 430);
            this.panel3.TabIndex = 27;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(709, 383);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(100, 41);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "Volver";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "...";
            // 
            // dgv_Buscar
            // 
            this.dgv_Buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Buscar.Location = new System.Drawing.Point(16, 12);
            this.dgv_Buscar.Name = "dgv_Buscar";
            this.dgv_Buscar.RowTemplate.Height = 24;
            this.dgv_Buscar.Size = new System.Drawing.Size(792, 364);
            this.dgv_Buscar.TabIndex = 2;
            // 
            // Mamirmi_Buscadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mamirmi_Buscadores";
            this.Text = "buscar_Personas";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chk_Salida;
        private System.Windows.Forms.CheckBox chk_Entrada;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_DepartamentoBusqueda;
        private System.Windows.Forms.CheckBox chk_Estado;
        private System.Windows.Forms.CheckBox chk_Nombre;
        private System.Windows.Forms.CheckBox chk_Carne;
        private System.Windows.Forms.CheckBox chk_Identificacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.ComboBox cbx_activo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Buscar;
    }
}