using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClsDoctorDAO:ClsConexion
    {
        //BUSCAR PROPIETARIO 
        public DataTable BuscarDoctorNombreDAO(ClsDoctorEnt ent)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("BuscarDoctor", conectar()))
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
        public void InsertarDoctorDAO(ClsDoctorEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("InsertarDoctor", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@apellidos", ent.apellidos);
                cmd.Parameters.AddWithValue("@dni", ent.dni);
                cmd.Parameters.AddWithValue("@especialidad", ent.especialidad);
                cmd.ExecuteNonQuery();

            }
        }

        //ACTUALIZAR
        public void ActualizarDoctorDAO(ClsDoctorEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("ActualizarDoctor", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.Parameters.AddWithValue("@nombre", ent.nombre);
                cmd.Parameters.AddWithValue("@apellidos", ent.apellidos);
                cmd.Parameters.AddWithValue("@dni", ent.dni);
                cmd.Parameters.AddWithValue("@especialidad", ent.especialidad);
                cmd.ExecuteNonQuery();
            }
        }

        //ELIMINAR PRODUCTO
        public void EliminarDoctorDAO(ClsDoctorEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("EliminarDoctor", conectar()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ent.codigo);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
