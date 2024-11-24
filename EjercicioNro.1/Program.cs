using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._1{
    internal class Program{
        static void Main(string[] args){
            Inventario<Producto> inventario = new Inventario<Producto>();
            bool salir = false;
            do{
                try{
                    Console.Clear();
                    Console.WriteLine("1. Agregar objeto");
                    Console.WriteLine("2. Eliminar elemento");
                    Console.WriteLine("3. Mostrar inventario de objetos");
                    Console.WriteLine("\n0. Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());
                    switch (opc)
                    {
                        case 0:
                            Console.Clear();
                            salir = true;
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre del objeto que desee agregar");
                            string item = Console.ReadLine();
                            inventario._AgregarObjeto(new Producto(item), item);
                            break;
                        case 2:
                            Console.Clear();
                            inventario._MostrarInventario();
                            Console.WriteLine("\n\nSeleccione el indice del objeto que desee eliminar");
                            int indice = Convert.ToInt32(Console.ReadLine());
                            inventario._RemoverObjeto(indice -1);
                            break;
                        case 3:
                            inventario._MostrarInventario();
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException) { _MensajeError(); }
                catch (IndexOutOfRangeException) { _MensajeError(); }
                catch (OverflowException) { _MensajeError(); }
                catch (NullReferenceException) { _MensajeError(); }
            } while (!salir);
            void _MensajeError(){
                Console.Clear();
                Console.WriteLine("Error! valor no valido");
                Console.ReadKey();
            }
        }
    }
}
