using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._2
{
    public class Persona
    {
        public string nombre { get; set; }
        public byte edad { get; set; }
        public Persona(string nombre, byte edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
