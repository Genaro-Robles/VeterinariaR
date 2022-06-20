using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClsCitasDAO:ClsConexion
    {


        public DataTable ListarMascotasDAO()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("ListarMascotaCita", conectar()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ListarDoctoresDAO()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("ListarDoctorCita", conectar()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        //INSERTAR
        public void InsertarCitasDAO(ClsCitasEnt ent)
        {
            using (SqlCommand cmd = new SqlCommand("InsertarCita", conectar()))
            {
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmascota", ent.mascota);
                cmd.Parameters.AddWithValue("@efermedad", ent.enfermedad);
                cmd.Parameters.AddWithValue("@tratamiento", ent.tratamiento);
                cmd.Parameters.AddWithValue("@iddoctor", ent.doctor);
                cmd.Parameters.AddWithValue("@fecha", ent.fecha);
                cmd.ExecuteNonQuery();

            }
        }
        //DETALLES CITAS
        public DataTable CitasFechaDAO(DateTime f1, DateTime f2,int mascota)
        {
            SqlCommand cmd = new SqlCommand("CitasFecha", conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha1", f1);
            cmd.Parameters.AddWithValue("@fecha2", f2);
            cmd.Parameters.AddWithValue("@mascota", mascota);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CitasDetalleDAO(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DetallesCitas", conectar()))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
