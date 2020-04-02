using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("##.#"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo culturaEua = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            Console.WriteLine(valor.ToString("C2", culturaEua));

        }
    }
}
