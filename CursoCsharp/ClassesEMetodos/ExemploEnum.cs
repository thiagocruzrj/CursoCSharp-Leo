using System;

namespace CursoCsharp.ClassesEMetodos
{
    public enum Genero { Ação, Aventura, Terror, SciFi, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            // fazendo cast para converter para inteiro um enum
            int id = (int)Genero.SciFi;
            Console.WriteLine(id);

            Filme filmeCasal = new Filme();
            filmeCasal.Titulo = "Bruxa de Blair";
            filmeCasal.GeneroDoFilme = Genero.Terror;

            Console.WriteLine($"{filmeCasal.Titulo} é um {filmeCasal.GeneroDoFilme}");
        }
    }
}
