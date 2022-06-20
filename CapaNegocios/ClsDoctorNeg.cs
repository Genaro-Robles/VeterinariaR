using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class ClsDoctorNeg
    {
        ClsDoctorDAO dao = new ClsDoctorDAO();
        //buscar
        public DataTable BuscarDoctorNeg(ClsDoctorEnt ent)
        {
            return dao.BuscarDoctorNombreDAO(ent);
        }

        public void InsertarDoctorNeg(ClsDoctorEnt ent)
        {
            dao.InsertarDoctorDAO(ent);
        }

        public void ActualizarDoctorNeg(ClsDoctorEnt ent)
        {
            dao.ActualizarDoctorDAO(ent);
        }

        public void EliminarDoctorNeg(ClsDoctorEnt ent)
        {
            dao.EliminarDoctorDAO(ent);
        }
    }
}
