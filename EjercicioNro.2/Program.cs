using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparador<Persona> compa = new Comparador<Persona>();

            Persona persona1 = new Persona("Maria", 23);
            Persona persona2 = new Persona("Juan", 15);
            Persona persona3 = new Persona("Claudio", 27);
            Persona persona4 = new Persona("Margaret", 19);
            compa._Comparar(persona1, persona2);
            Console.ReadKey();
            compa._Comparar(persona2, persona3);
            Console.ReadKey();
            compa._Comparar(persona3, persona4);
            Console.ReadKey();
            compa._Comparar(persona4, persona1);
            Console.ReadKey();
        }
    }
}
