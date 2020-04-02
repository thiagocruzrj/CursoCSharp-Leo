using System;

namespace CursoCsharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "iae".ToUpper().Insert(3, "World").Replace("World", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Thiago".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
