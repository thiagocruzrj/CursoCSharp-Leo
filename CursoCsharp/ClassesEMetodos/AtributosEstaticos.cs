using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var prod1 = new Produto("Caneta", 2.1, 0.2);
            var prod2 = new Produto()
            {
                Nome = "Lápis",
                Preco = 1.7
            };

            var desconto = Produto.Desconto = 0.05;

            Console.WriteLine($"O preco do produto {prod1.Nome} é {prod1.Preco} com desconto {desconto * 100}% o valor final fica R$ {prod1.CalcularDesconto()}");
            Console.WriteLine($"O preco do produto {prod2.Nome} é {prod2.Preco} com desconto {desconto * 100}% o valor final fica R$ {prod2.CalcularDesconto()}");
        }
    }
}
