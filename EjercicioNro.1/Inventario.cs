using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._1
{
    public class Inventario<T> where T:Producto
    {
        List<T> objetos = new List<T>();

        public void _AgregarObjeto(T item, string name)
        {
            objetos.Add(item);
        }
        public void _RemoverObjeto(int indice)
        {
            if(objetos.Count > 0)
            {
                if (indice > -1 && indice < objetos.Count)
                {
                    objetos.RemoveAt(indice);
                }
            }
        }
        public void _MostrarInventario()
        {
            Console.Clear();
            Console.WriteLine("lista de objetos");
            if(objetos.Count > 0)
            {
                for(int i = 0; i< objetos.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, objetos[i].nombre);
                }
            }
        }
    }
}
