using System;

namespace CursoCsharp.Colecoes
{
    class UsandoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Thiago";
            alunos[1] = "da";
            alunos[2] = "Cruz";
            alunos[3] = "Justo";
            alunos[4] = "Stone";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
