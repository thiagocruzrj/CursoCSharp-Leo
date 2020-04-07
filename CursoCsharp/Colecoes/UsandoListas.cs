using System;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }
    class UsandoListas
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 30.0),
                new Produto("Jogo", 70.0),
                new Produto("Vioão", 150.0),
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
