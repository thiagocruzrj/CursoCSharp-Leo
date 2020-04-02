using System;

namespace CursoCsharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            var marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + " reais.");
            Console.WriteLine("O {0} da marca {1} custa {2} reais.", nome, marca, preco);
            Console.WriteLine($"O {nome} da marca {marca} custa {preco} reais.");
            Console.WriteLine($"1 + 1 = {1+1}");
        }
    }
}
