using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellidos}";
        }
    }
}
