using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public abstract class ClsConexion
    {
        protected SqlConnection conectar()
        {
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["xcon"].ConnectionString);
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            else
            {
                cnx.Open();
            }
            return cnx;
        }
    }
}
