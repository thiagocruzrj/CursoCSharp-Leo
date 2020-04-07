using System;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    public class ProdutoSet
    {
        public string Nome;
        public double Preco;

        public ProdutoSet(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class UsandoSet
    {
        public static void Executar()
        {
            var livro = new ProdutoSet("Game of Thrones", 49.9);
            var carrinho = new List<ProdutoSet>();
            carrinho.Add(livro);

            var combo = new List<ProdutoSet>
            {
                new ProdutoSet("Camisa", 30.0),
                new ProdutoSet("Jogo", 70.0),
                new ProdutoSet("Vioão", 150.0),
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(0);

            foreach (var produto in carrinho)
            {
                Console.Write(carrinho.IndexOf(produto));
                Console.WriteLine($"{produto.Nome} {produto.Preco}");
            }
        }
    }
}
