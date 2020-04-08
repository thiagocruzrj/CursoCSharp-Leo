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

        public override string ToString()
        {
            return $"{Nome} tem {Altura} de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {

        }
    }
}
