using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class ClsCitasNeg
    {
        ClsCitasDAO dao = new ClsCitasDAO();
        //llenar combobox
        public DataTable ListarMascotasneg()
        {
            return dao.ListarMascotasDAO();
        }

        public DataTable ListarDoctoresneg()
        {
            return dao.ListarDoctoresDAO();
        }

        //insertar
        public void InsertarCitasNeg(ClsCitasEnt ent)
        {
            dao.InsertarCitasDAO(ent);
        }
    }
}
