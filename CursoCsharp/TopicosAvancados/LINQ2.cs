using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} nota {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("fulano"));
            if (fulano == null)
                Console.WriteLine("aluno não existe");

            var ana = alunos.First(alunos => alunos.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nome} existe");

            var ciclano = alunos.FirstOrDefault(alunos => alunos.Nome.Equals("ciclano"));
            if (ciclano == null)
                Console.WriteLine("aluno não existe");

            var outraAna = alunos.LastOrDefault(alunos => alunos.Nome.Equals("Ana"));
            Console.WriteLine($"{outraAna.Nota}");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somaNotas = alunos.Sum(alunos => alunos.Nota);
            Console.WriteLine(somaNotas);

            var media = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(media);
        }
    }
}
