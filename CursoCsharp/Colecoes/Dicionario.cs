using System;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    class Dicionario
    {
        public static void Executar()
        {
            // aceita repetição no valor mas não na chave
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2012, "Homem aranha");
            filmes.Add(2004, "Os incriveis");
            filmes.Add(2006, "Grande truque");

            if (filmes.ContainsKey(2000))
            {
                Console.WriteLine("2000 :" + filmes[2000]); // chave deve existir se não haverá execeção
                Console.WriteLine("2000 :" + filmes.GetValueOrDefault(2000)); // default string vazia
            }

            Console.WriteLine(filmes.ContainsValue("Anta"));
            Console.WriteLine("Removeu ? " + filmes.Remove(2006));
            
            // caso encontre o filme com a key 2006, filme2006 será a chamada do valor
            filmes.TryGetValue(2004, out string filme2004);
            Console.WriteLine($"Filme {filme2004}");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value}: ano {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value}: ano {filme.Key}");
            }
        }
    }
}
