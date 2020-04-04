using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira um palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em ({tentativas}) tentativas");
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("O valor é MAIOR que o número secreto ... tente novamente");
                    Console.WriteLine($"Tentativas restante: {tentativasRestantes}");
                } else
                {
                    Console.WriteLine("O valor é Memor que o número secreto ... tente novamente");
                    Console.WriteLine($"Tentativas restante: {tentativasRestantes}");
                }
            }
        }
    }
}
