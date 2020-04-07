using System;
using System.Collections;

namespace CursoCsharp.Colecoes
{
    class UsandoStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push('A');
            pilha.Push(3.79f);
            pilha.Push(true);

            foreach (var items in pilha)
            {
                Console.WriteLine($"{items} ");
            }

            Console.WriteLine($"\nPilhaPop : {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPilhaPeek : {pilha.Peek()}");
        }
    }
}
