using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario<Producto> inventario = new Inventario<Producto>();
            inventario.inventario.Add(new Producto("camara", 20000));
            inventario.inventario.Add(new Producto("Computadora", 25638));
            inventario.inventario.Add(new Producto("telefono", 8628));
            inventario.inventario.Add(new Producto("Bolsa de uvas", 233));
            inventario.inventario.Add(new Producto("Mandarina", 10));
            inventario.inventario.Add(new Producto("Cargador", 9263));
            inventario.inventario.Add(new Producto("Guitarra", 35672));
            Console.WriteLine("Ingrese un valor en C$");
            double precio = Convert.ToDouble(Console.ReadLine());
            inventario._MostrarInventario(precio);
            Console.ReadKey();
        }
    }
}
