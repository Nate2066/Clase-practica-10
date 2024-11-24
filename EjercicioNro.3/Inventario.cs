using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._3
{
    public class Inventario<T> where T : Producto
    {
        public List<T> inventario = new List<T>();

        public void _MostrarInventario(double precio)
        {
            if(inventario.Count > 0)
            {
                foreach(var item in inventario)
                {
                    if(item.precio > precio)
                    {
                        Console.WriteLine("{0} ..... C$ {1}",item.nombre, item.precio);
                    }
                }
            }
        }
    }
}
