using System;
using System.IO;

namespace CursoCsharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCsharp".ParseHome();
            var novoDirDestino = @"~/PastaCsharpDestino".ParseHome();
            var novoDirProj = @"C:/Users/thiago.justo_ext/Documents/GitHub/CursoCSharp-Leo";

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Console.WriteLine("== Pasta ===================");
            var pastas = Directory.GetDirectories(novoDirProj);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos ============");
            var arquivos = Directory.GetFiles(novoDirProj);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
        }
    }
}
