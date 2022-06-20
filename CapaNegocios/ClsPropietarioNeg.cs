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
    public class ClsPropietarioNeg
    {
        ClsPropietarioDAO dao = new ClsPropietarioDAO();
        //buscar
        public DataTable BuscarPropietarioNeg(ClsPropietarioEnt ent)
        {
            return dao.BuscarPropietarioNombreDAO(ent);
        }

        public void InsertarPropietarioNeg(ClsPropietarioEnt ent)
        {
            dao.InsertarPropietarioDAO(ent);
        }

        public void ActualizarPropietarioNeg(ClsPropietarioEnt ent)
        {
            dao.ActualizarPropietariosDAO(ent);
        }

        public void EliminarPropietarioNeg(ClsPropietarioEnt ent)
        {
            dao.EliminarPropietarioDAO(ent);
        }
    }
}
