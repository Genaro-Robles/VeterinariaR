using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsMascotaEnt
    {
        public Int32 codigo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public Int32 tam { get; set; }
        public Int32 edad { get; set; }
        public Int32 idpropietario { get; set; }
    }
}
