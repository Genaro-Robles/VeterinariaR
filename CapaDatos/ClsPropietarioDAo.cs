using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClsPropietarioDAO:ClsConexion
    {
        //BUSCAR PROPIETARIO 
        public DataTable BuscarPropietarioNombreDAO(ClsPropietarioEnt ent)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("BuscarPropietario", conectar()))
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
        public void InsertarPropietarioDAO(ClsPropietarioEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("InsertarPropietario", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@apellidos", ent.apellidos);
                cmd.Parameters.AddWithValue("@edad", ent.edad);
                cmd.Parameters.AddWithValue("@dni", ent.dni);
                cmd.Parameters.AddWithValue("@activo", ent.activo);
                cmd.ExecuteNonQuery();

            }
        }

        //ACTUALIZAR
        public void ActualizarPropietariosDAO(ClsPropietarioEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("ActualizarPropietario", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@apellidos", ent.apellidos);
                cmd.Parameters.AddWithValue("@edad", ent.edad);
                cmd.Parameters.AddWithValue("@dni", ent.dni);
                cmd.Parameters.AddWithValue("@activo", ent.activo);
                cmd.ExecuteNonQuery();
            }
        }

        //ELIMINAR PRODUCTO
        public void EliminarPropietarioDAO(ClsPropietarioEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("EliminarPropietario", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
