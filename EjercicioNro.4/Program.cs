using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gestor<Tarea> gestor = new Gestor<Tarea>();
            bool salir = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Agregar tarea");
                    Console.WriteLine("2. completar tarea");
                    Console.WriteLine("3. Mostrar tareas");
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
                            Console.WriteLine("escriba el asunto de la tarea");
                            string asunto= Console.ReadLine();
                            gestor._AgregarTarea(new Tarea(asunto, "Sin completar"));
                            break;
                        case 2:
                            Console.Clear();
                            gestor._MostrarTareas();

                            Console.WriteLine("\n\nIngrese el indice de la tarea que desee marcar como completa");
                            int indice = Convert.ToInt32(Console.ReadLine());
                            gestor._CompletarTarea(indice - 1);
                            break;
                        case 3:
                            Console.Clear();
                            gestor._MostrarTareas();
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException) { _MensajeError(); }
                catch (IndexOutOfRangeException) { _MensajeError(); }
                catch (OverflowException) { _MensajeError(); }
                catch (NullReferenceException) { _MensajeError(); }
            } while (!salir);
            void _MensajeError()
            {
                Console.Clear();
                Console.WriteLine("Error! valor no valido");
                Console.ReadKey();
            }
        }
    }
}
