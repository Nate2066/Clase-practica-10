using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._2
{
    public class Comparador<T> where T:Persona 
    {
        public void _Comparar(T obj1, T obj2)
        {
            if(obj1.edad > obj2.edad)
            {
                Console.WriteLine("{0} es mayor que {1}", obj1.nombre, obj2.nombre);
            }
            if (obj1.edad < obj2.edad)
            {
                Console.WriteLine("{1} es mayor que {0}", obj1.nombre, obj2.nombre);
            }
            if (obj1.edad == obj2.edad)
            {
                Console.WriteLine("{0} tiene la misma edad que {1}", obj1.nombre, obj2.nombre);
            }
        }
    }
}
