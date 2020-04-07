using System;

namespace CursoCsharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("A", 1);
            var p2 = new Produto("A", 1);

            Console.WriteLine(p1 == p2);
        }
    }
}
