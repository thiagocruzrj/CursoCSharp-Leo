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
            var novoDirProj = @"~/Documents/GitHub/CursoCSharp-Leo".ParseHome();

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
        }
    }
}
