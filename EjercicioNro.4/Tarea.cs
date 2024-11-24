using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._4
{
    public class Tarea
    {
        public string asunto { get; set; }
        public string estado { get; set; }
        public Tarea(string asunto, string estado)
        {
            this.asunto = asunto;
            this.estado = estado;
        }
    }
}
