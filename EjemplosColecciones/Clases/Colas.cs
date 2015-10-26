using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones.Clases
{
    public class Colas
    {
        public static void Main2(string[] args)
        {
            Queue colaG = new Queue();

            colaG.Enqueue("Hola");
            colaG.Enqueue("Soy");
            colaG.Enqueue(new Persona() { Nombre = "Fran", Apellidos = "López" });
            colaG.Enqueue(22);


            Queue<Persona> colaP = new Queue<Persona>();

            //colaP.Enqueue("AAA"); //FAIL
            colaP.Enqueue(new Persona() { Nombre = "Pepe", Apellidos = "Ramón" });
            colaP.Enqueue(new Persona() { Nombre = "Clara", Apellidos = "Martín" });
            colaP.Enqueue(new Persona() { Nombre = "Hugo", Apellidos = "Layo" });

            foreach (var c in colaG)
            {
                //safe casting
                /*var p = c as Persona;

                if (p != null)
                    Console.WriteLine(p.Nombre);
                else*/
                Console.WriteLine(c);

            }


            foreach (var c in colaP)
            {
                Console.WriteLine(c.Nombre);
            }

            Stack<Persona> stackP = new Stack<Persona>();

            stackP.Push(new Persona() { Nombre = "Pepe", Apellidos = "Ramón" });
            stackP.Push(new Persona() { Nombre = "Clara", Apellidos = "Martín" });
            stackP.Push(new Persona() { Nombre = "Hugo", Apellidos = "Layo" });
            stackP.Pop();
            foreach (var s in stackP)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
