using System;
using System.IO;

namespace CursoCsharp.Api
{
    public static class ExtencaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                            Environment.OSVersion.Platform == PlatformID.Win32NT) ?
                            Environment.GetEnvironmentVariable("HOME") :
                            Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_Arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é o nosso primeiro arquivo");
                }
            }

            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("é possivel");
                sw.WriteLine(" adicionar");
            }
        }
    }
}
