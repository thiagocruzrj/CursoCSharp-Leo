using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            // Iniciando com while
            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine($"O valor de i é {i}.");
                i++;
            }
            Console.WriteLine();

            // Alterando para while
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"O valor de x é {x}");
            }
            Console.WriteLine();

            // Exemplo completo
            double somatorio = 0;

            Console.Write("Informe o tamanho da turma: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int aluno = 1; aluno <= tamanhoTurma; aluno++)
            {
                Console.Write($"Informe a nota do aluno {aluno}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double mediaTurma = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"A média da turma com {tamanhoTurma} alunos foi {mediaTurma}.");
        }
    }
}
