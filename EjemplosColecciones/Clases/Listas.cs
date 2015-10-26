using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Clases
{
    class Listas
    {
        public static void Mai(string[] args)
        {
            List<Persona> p = new List<Persona>();

            p.Add(new Persona() { Nombre = "Pepe", Apellidos = "Ramón" });
            p.Add(new Persona() { Nombre = "Clara", Apellidos = "Martín" });
            p.Add(new Persona() { Nombre = "Hugo", Apellidos = "Layo" });
            

            p.RemoveAt(2);

            foreach (var v in p)
            {
                Console.WriteLine(p);
            }
        }
    }
}
