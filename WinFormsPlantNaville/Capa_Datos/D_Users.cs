using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    /// <summary>
    /// Clase para la Conexion de la Base de Datos
    /// </summary>
    public class D_Users
    {
        //Cadena de Conexion a la base de datos
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        //Creacion de tabla para hacer uso a la Capa Entidades
        public DataTable D_User(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("iniciar_sesion", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            //Declaracion de nombre de variables para llevar a cabo el proceso
            cmd.Parameters.AddWithValue("@nombre_us", obje.usuario);
            cmd.Parameters.AddWithValue("@contrasena", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
    }
}
