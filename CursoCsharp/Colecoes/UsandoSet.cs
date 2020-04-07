using System;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    class UsandoSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new HashSet<Produto>();
            // HashSet não é uma estrutura indexada, não aceitando assim duplicação de itens
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 30.0),
                new Produto("Jogo", 70.0),
                new Produto("Vioão", 150.0),
                new Produto("Vioão", 150.0)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(0);

            foreach (var produto in carrinho)
            {
                //Console.Write(carrinho.IndexOf(produto));
                Console.WriteLine($"{produto.Nome} {produto.Preco}");
            }
        }
    }
}
