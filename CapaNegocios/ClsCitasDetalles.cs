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
    public class ClsCitasDetalles
    {
        ClsCitasDAO dao = new ClsCitasDAO();

        public DataTable CitasFechaNeg(DateTime f1, DateTime f2, int mascota)
        {
            return dao.CitasFechaDAO(f1, f2, mascota);
        }

        public DataTable CitasDetalleNeg(int cod)
        {
            return dao.CitasDetalleDAO(cod);
        }
    }
}
