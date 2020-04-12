using System;
using System.IO;

namespace CursoCsharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProject = @"C:/Users/thiago.justo_ext/Documents/GitHub/CursoCSharp-Leo";
            var dirInfo = new DirectoryInfo(dirProject);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos =============");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n== Diretorios =============");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
