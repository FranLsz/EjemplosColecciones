using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemplosColecciones.Clases;

namespace EjemplosColecciones
{
    class Program
    {
        static void Main2(string[] args)
        {
            //los tipos de algoritmos para manejar la informacion son: colas (FIFO), pilas (LIFO), listas(array dinamico), diccionarios (key - value), set(almacen rapido y sin orden)

            ArrayList l = new ArrayList();
            l.Add(new Persona());
            l.Add("wewe");


            //coleccion en cola, para sacar Persona, tengo que haber sacado antes la "A"
            Queue  q = new Queue();
            q.Enqueue("A");
            q.Enqueue(new Persona());

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Console.ReadLine();

        }
    }
}
