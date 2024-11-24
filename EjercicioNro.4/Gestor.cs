using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._4
{
    public class Gestor<T> where T:Tarea
    {
        List<T> tareas = new List<T>();

        public void _AgregarTarea(T tarea)
        {
            tareas.Add(tarea);
        }
        public void _CompletarTarea(int indice)
        {
            if(indice > -1 && indice < tareas.Count)
            {
                tareas[indice].estado = "Completada";
            }
        }
        public void _MostrarTareas()
        {
            if(tareas.Count > 0)
            {
                for(int i = 0; i< tareas.Count; i++)
                {
                    Console.WriteLine("{0}.{1} [{2}]", i+1, tareas[i].asunto, tareas[i].estado);
                }
            }
        }
    }
}
