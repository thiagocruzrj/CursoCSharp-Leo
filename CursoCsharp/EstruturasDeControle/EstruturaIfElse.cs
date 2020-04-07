using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;
            nota = 6.0;
            nota = 8.0;

            if (nota >= 7)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Fez sua obrigação!");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
