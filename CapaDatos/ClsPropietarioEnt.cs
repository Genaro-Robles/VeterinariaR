using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsPropietarioEnt
    {
        public Int32 codigo { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public Int32 edad { get; set; }
        public string dni { get; set; }
        public bool activo { get; set; }
    }
}
