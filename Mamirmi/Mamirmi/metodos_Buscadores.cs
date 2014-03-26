using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Diagnostics;
using System.Windows.Forms;

namespace Buscadores {
    class metodos_Buscadores
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=201.191.100.11\\RANGUROSERVER,1433;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed";
            //string sc = "Data Source = CHRISTIAM-PC; Initial Catalog = Mamirmi's Form; Integrated Security = True";
            string string_Coneccion = "Data Source=localhost;Initial Catalog=Mamirmi;Integrated Security=True";    
            SqlConnection conn = new SqlConnection(string_Coneccion);
            conn.Open();
            return (conn);
        }

        public void buscar_PersonasCarne(string carne, DataGridView tabla)
        {
            SqlConnection conn = conectar();
            string consulta;
            // string consulta = "select * from Empleado where carne=" + carne;
            if (!carne.Equals(""))
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre, ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado "
                + "Where carne =" + "'" + carne + "'";
            }
            else
            {
                consulta = "SELECT (nombre + ' ' + apellidos) as Nombre,ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado";
            }

            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //tabla.Rows.Clear();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tabla);

                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Ingreso")).ToShortDateString().ToUpper();
                //row.Cells[5].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Salida")).ToShortDateString();
                if (dr.GetOrdinal("estado") == 6)
                {
                    row.Cells[6].Value = "Activo";
                }
                else
                {
                    row.Cells[6].Value = "Inactivo";
                }

                /*row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString().ToUpper();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[3].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_de_ingreso")).ToShortDateString();*/
                tabla.Rows.Add(row);
                // tabla.Rows[n].Cells[4].Value = dr.GetString(dr.GetOrdinal("Fecha_Salida")).ToString();

            }
            dr.Close();
            conn.Close();

        }

        public void buscar_PersonasNombre(string Nombre, DataGridView tabla)
        {
            SqlConnection conn = conectar();
            string consulta;
            // string consulta = "select * from Empleado where carne=" + carne;
            if (!Nombre.Equals(""))
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre, ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado " +
                "WHERE nombre like" + "'%" + Nombre + "%'";
            }
            else
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre, ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado";
            }
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //tabla.Rows.Clear();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();

                /*row.CreateCells(tabla); row.CreateCells(tabla);
                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Ingreso")).ToShortDateString();*/
                //row.Cells[5].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Salida")).ToShortDateString();
                if (dr.GetOrdinal("estado") == 6)
                {
                    row.Cells[6].Value = "Activo";
                }
                else
                {
                    row.Cells[6].Value = "Inactivo";
                }

                row.CreateCells(tabla);
                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_de_ingreso")).ToShortDateString().ToUpper();

                tabla.Rows.Add(row);
                // tabla.Rows[n].Cells[4].Value = dr.GetString(dr.GetOrdinal("Fecha_Salida")).ToString();

            }
            dr.Close();
            conn.Close();
        }
        public void buscar_PersonasId(string Id, DataGridView tabla)
        {
            SqlConnection conn = conectar();
            string consulta;
            // string consulta = "select * from Empleado where carne=" + carne;
            if (!Id.Equals(""))
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre,ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado " +
                "WHERE ID =" + "'" + Id + "'";
            }
            else
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre,ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado";
            }
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //tabla.Rows.Clear();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tabla); row.CreateCells(tabla);
                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Ingreso")).ToShortDateString().ToUpper();
                //row.Cells[5].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Salida")).ToShortDateString();
                if (dr.GetOrdinal("estado") == 6)
                {
                    row.Cells[6].Value = "Activo";
                }
                else
                {
                    row.Cells[6].Value = "Inactivo";
                }
                tabla.Rows.Add(row);
                // tabla.Rows[n].Cells[4].Value = dr.GetString(dr.GetOrdinal("Fecha_Salida")).ToString();

            }
            dr.Close();
            conn.Close();

        }

        public void buscar_PersonasEstado(string estado, DataGridView tabla)
        {
            byte estadonum = 1;
            SqlConnection conn = conectar();
            string consulta;
            if (estado.Equals("Inactivo"))
            {
                estadonum = 0;
            }
            // string consulta = "select * from Empleado where carne=" + carne;
            if (!estado.Equals(""))
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre,ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado " +
                "WHERE estado =" + "'" + estadonum + "'";
            }
            else
            {
                consulta = "SELECT nombre + ' ' + apellidos as Nombre,ID, Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado" +
                    "WHERE estado = 1";
            }
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            //tabla.Rows.Clear();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tabla); row.CreateCells(tabla);
                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Ingreso")).ToShortDateString().ToUpper();
                //row.Cells[5].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Salida")).ToShortDateString();
                if (dr.GetOrdinal("estado") == 6)
                {
                    row.Cells[6].Value = "Activo";
                }
                else
                {
                    row.Cells[6].Value = "Inactivo";
                }
                tabla.Rows.Add(row);
                // tabla.Rows[n].Cells[4].Value = dr.GetString(dr.GetOrdinal("Fecha_Salida")).ToString();

            }
            dr.Close();
            conn.Close();

        }

        public void buscar_PersonasSinFiltro(DataGridView tabla)
        {
            SqlConnection conn = conectar();
            /// String podría caer en error por el inner JOIN -> on persona.id = Empleado.Personaid = persona.id
            string consulta = "SELECT (nombre + ' ' + apellidos) as Nombre,ID,Carne, Departamento,Fecha_Ingreso,Fecha_Salida, estado FROM Empleado";
            SqlCommand cmd = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            tabla.Rows.Clear();
            while (dr.Read())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tabla);

                /*row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Ingreso")).ToShortDateString();*/
                //row.Cells[5].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_Salida")).ToShortDateString();
                if (dr.GetOrdinal("estado") == 6)
                {
                    row.Cells[6].Value = "Activo";
                }
                else
                {
                    row.Cells[6].Value = "Inactivo";
                }

                row.Cells[0].Value = dr.GetString(dr.GetOrdinal("Nombre")).ToString().ToUpper();
                row.Cells[1].Value = dr.GetString(dr.GetOrdinal("ID")).ToString();
                row.Cells[2].Value = dr.GetString(dr.GetOrdinal("Carne")).ToString().ToUpper();
                row.Cells[3].Value = dr.GetString(dr.GetOrdinal("Departamento")).ToString().ToUpper();
                row.Cells[4].Value = dr.GetDateTime(dr.GetOrdinal("Fecha_de_ingreso")).ToShortDateString();

                tabla.Rows.Add(row);
                // tabla.Rows[n].Cells[4].Value = dr.GetString(dr.GetOrdinal("Fecha_Salida")).ToString();

            }
            dr.Close();
            conn.Close();

        }
        public void insertar_Empleado(string Personaid,string cuentaBN,
            string cuentaBP,string profesion ,string estudios,string manipulacionesA,
            string enfermedades,string carne, string experiencia,
            string fIngreso,string departamento,string des_salida,string fSalida, string estado) {
            SqlConnection conn = conectar();
            string sql = "exec InsertarEmpleado '" + Personaid + "' , '" + cuentaBN + "' , '" + cuentaBP;
            sql += "' , '" + profesion + "' , '" + estudios + "' , '" + manipulacionesA + "' , '" + enfermedades + "' , '" + carne;
            sql += "' , '"+ experiencia + "' , '" + fIngreso + "' , '"+ departamento + "' , '" + des_salida + "' , '" + fSalida + "' , '" +estado + "'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            Debug.WriteLine(sql);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.Write("PERSONAS INSERTADA");
            }
            catch (SqlException e)
            {
                conn.Close();
                Console.Write("NO PERSONAS INSERTADA");
            }
        
        }

    }
}
