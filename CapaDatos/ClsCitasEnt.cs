using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsCitasEnt
    {
        public Int32 codigo { get; set; }
        public Int32 mascota { get; set; }
        public string enfermedad { get; set; }
        public string tratamiento { get; set; }
        public Int32 doctor { get; set; }
        public DateTime fecha { get; set; }
    }
}
