using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MamirmiDB
{
    class Database
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=201.191.100.11\\RANGUROSERVER,1433;Initial Catalog=" + "Mamirmi's Form" + ";User ID=lesmed;Password=lesmed";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }

        public string insertar_Persona(string ID, string Name, string ln1, string ln2, string age, string nc, string direccion, string gender, string departamento)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertPerson " + "'" + ID + "' , '" + Name + "' , '" + ln1 + "' , '" + ln2;
            sql += "' , " + age + " , '" + nc + "' , '"+direccion+"' , '"+gender+"' , '"+departamento+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Persona insertada correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar la persona, verifique que los datos esten bien escritos.");
            }
        }

        public string insertar_Barril(string ID, string fecha, string total)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertBarrel " + "'" + ID + "' , '" + fecha + "' , " + total;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Barril insertado correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar el barril, verifique que los datos esten bien escritos.");
            }
        }



        public string insertar_Telefono(string ID, string telefono)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertTelephone " + "'" + ID + "' , '" + telefono + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Telefono insertado correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar el Telefono, verifique que los datos esten bien escritos.");
            }
        }




        public string insertar_Vacacion(string ID, string departure, string entry)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertVacation " + "'" + ID + "' , '" + departure + "' , '" + entry + "'"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Vacacion insertado correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar el vacacion, verifique que los datos esten bien escritos.");
            }
        }


        public string insertar_Aguinaldo(string monto, string date, string ID)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertChristmasBox " + monto + " , '" + date + "' , '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Aguinaldo insertado correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar el Aguinaldo, verifique que los datos esten bien escritos.");
            }
        }


        public string insertar_Empleado(string ID_empleado, string ID, string BN, string BP, string HC)
        {
            SqlConnection conn = conectar();
            string sql = "EXEC insertEmployee " + ID_empleado + " , '" + ID + "' , '" + BN + "' , '";
            sql+= BP + "' , "+HC;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return ("Empleado insertado correctamente");
            }
            catch (SqlException e)
            {
                conn.Close();
                return ("No se puede insertar el Empleado, verifique que los datos esten bien escritos.");
            }
        }


    }
}