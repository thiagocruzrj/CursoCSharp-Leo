using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Eae rapeize!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Isabella", "Thainá", "Suzi", "Giulia", "Thiago" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
