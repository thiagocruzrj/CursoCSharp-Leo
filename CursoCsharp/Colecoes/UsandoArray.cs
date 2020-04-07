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

            double somatorio = 0;
            double[] notas = { 6.9, 9.9, 6.7, 3.5, 9.2 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            // Exemplo com for
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            Console.WriteLine(somatorio);

            double media = somatorio / notas.Length;
            Console.WriteLine($"A média da turma foi {media}.");

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
