using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    class UsandoQueue
    {
        public static void Executar()
        {
            // com generics
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Teste1");
            fila.Enqueue("Teste2");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            // sem generics
            var fila2 = new Queue();
            fila2.Enqueue(3);
            fila2.Enqueue("string");
            fila2.Enqueue(true);
            fila2.Enqueue(7.5);

            Console.WriteLine(fila2.Contains("string"));
        }
    }
}
