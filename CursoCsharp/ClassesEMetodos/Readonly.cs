using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        // Usamos readonly para quando o valor é imutavel e poder ser inicializado pelo construtor
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Thiago Cruz", new DateTime(1994, 3, 18));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetNascimento());
        }
    }
}