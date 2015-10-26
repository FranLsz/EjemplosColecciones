using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Clases
{
    class Diccionarios
    {
        public static void Main(string[] args)
        {
            Dictionary<String, Persona> d = new Dictionary<string, Persona>();

            d.Add("Uno", new Persona() { Nombre = "Pepe", Apellidos = "Ramón" });
            d.Add("Dos", new Persona() { Nombre = "Clara", Apellidos = "Martín" });
            d.Add("Tres", new Persona() { Nombre = "Hugo", Apellidos = "Layo" });

            if (d.ContainsKey("Tres"))
                d.Remove("Tres");

        }
    }
}
