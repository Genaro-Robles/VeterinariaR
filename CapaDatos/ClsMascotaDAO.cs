using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class ClsMascotaDAO : ClsConexion
    {
        SqlConnection cnx = new SqlConnection();

        public DataTable ListarPropietarioDAO()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("ListarPropietario", conectar()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }

        }
        //BUSCAR MASCOTA 
        public DataTable BuscarMascotaNombreDAO(ClsMascotaEnt ent)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("BuscarMascota", conectar()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@nombre", ent.nombre);
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        //INSERTAR
        public void InsertarMascotasDAO(ClsMascotaEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("InsertarMascota", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@tipo", ent.tipo);
                cmd.Parameters.AddWithValue("@tam", ent.tam);
                cmd.Parameters.AddWithValue("@edad", ent.edad);
                cmd.Parameters.AddWithValue("@idpropietario", ent.idpropietario);
                cmd.ExecuteNonQuery();

            }

        }

        //ACTUALIZAR
        public void ActualizarMascotaDAO(ClsMascotaEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("ActualizarMascota", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@tipo", ent.tipo);
                cmd.Parameters.AddWithValue("@tam", ent.tam);
                cmd.Parameters.AddWithValue("@edad", ent.edad);
                cmd.Parameters.AddWithValue("@idpropietario", ent.idpropietario);
                cmd.ExecuteNonQuery();

            }
        }

        //ELIMINAR
        public void EliminarMascotaDAO(ClsMascotaEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("EliminarMascota", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
