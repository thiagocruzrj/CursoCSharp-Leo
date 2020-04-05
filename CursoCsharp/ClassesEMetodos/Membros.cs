using System;

namespace CursoCsharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa teste = new Pessoa();
            teste.Nome = "Thiago";
            teste.Idade = 26;

            // Console.WriteLine($"{teste.Nome} tem {teste.Idade} !");

            teste.ApresentarNoConsole();
        }
    }
}
