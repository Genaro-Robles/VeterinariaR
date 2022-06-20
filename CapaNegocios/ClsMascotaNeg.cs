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
    public class ClsMascotaNeg
    {
        ClsMascotaDAO dao = new ClsMascotaDAO();

        //llenar combobox
        public DataTable ListarPropietarioneg()
        {
            return dao.ListarPropietarioDAO();
        }

        //buscar
        public DataTable BuscarMascotaNombreNeg(ClsMascotaEnt ent)
        {
            return dao.BuscarMascotaNombreDAO(ent);
        }

        //insertar
        public void InsertarMascotaNeg(ClsMascotaEnt ent)
        {
            dao.InsertarMascotasDAO(ent);
        }

        //actualizar
        public void ActualizarMascotaNeg(ClsMascotaEnt ent)
        {
            dao.ActualizarMascotaDAO(ent);
        }

        //eliminar
        public void EliminarMascotaNeg(ClsMascotaEnt ent)
        {
            dao.EliminarMascotaDAO(ent);
        }
    }
}
