using System;

namespace CursoCsharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa teste = new Pessoa();
            teste.Nome = "";
            teste.Idade = 0;

            if(teste.Nome == null || teste.Idade > 0)
            {
                teste.ApresentarNoConsole();
            } else
            {
                Console.WriteLine("Sem informações de cadastro");
            }

            // Console.WriteLine($"{teste.Nome} tem {teste.Idade} !");

            teste.Zerar();
            teste.ApresentarNoConsole();

            var testeVar = new Pessoa();
            testeVar.Nome = "Isabella";
            testeVar.Idade = 25;

            var apresentacaoIsabella = testeVar.Apresentar();
            Console.WriteLine(apresentacaoIsabella);
        }
    }
}
