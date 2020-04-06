using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get { return "Opcional: " + nome; }
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

        }
    }
}
