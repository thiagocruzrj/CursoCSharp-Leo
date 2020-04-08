using System;

namespace CursoCsharp.OO
{
    public class Animal
    {
        public Animal(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} instanciado.");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        // mostra implicitamente quando chamamos uma string
        public override string ToString()
        {
            return $"{Nome} tem {Altura} de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());
        }
    }
}
