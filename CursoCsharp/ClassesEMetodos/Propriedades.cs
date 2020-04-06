using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get { return "\nOpcional: " + nome; }
            set { nome = value; }
        }

        // Propriedades autoimplementadas
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Lambda
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional()
        {

        }
    }

    class Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3999);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional("Direcao Eletrica", 2000);
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
