using System;

namespace CursoCsharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intevalo = 50;
            Console.WriteLine($"Numeros pares entre 1 e {intevalo}!");

            for (int i = 1; i < intevalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }
    }
}
