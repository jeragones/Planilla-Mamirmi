using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mamirmi
{
    class Login
    {

        public static bool log_in(string user, string pass)
        {
            SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Mamirmi;Integrated Security=True");
            conexion.Open();
            SqlCommand query1 = new SqlCommand("select * from dbo.Usuario where Usuario='" + user + "'and Contraseña ='" + pass + "'", conexion);
            SqlDataReader eject = query1.ExecuteReader();

            if (eject.Read() == true)
            {
                return true;

            }

            else
            {
                return false;
            }
            conexion.Close();


        }

    }
}
