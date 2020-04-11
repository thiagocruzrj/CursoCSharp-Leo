using System;
using System.IO;

namespace CursoCsharp.Api
{
    class ExemploFileInfo
    {
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            using(StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Original file");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
