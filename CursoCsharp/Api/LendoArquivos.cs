using System;
using System.IO;

namespace CursoCsharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Bic preta;2.10;1");
                    sw.WriteLine("Borracha;0.99;1");
                }
            }
        }
    }
}
