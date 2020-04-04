using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            // Iniciando com while
            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine($"O valor de i é {i}.");
                i++;
            }

            // Alterando para while
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine($"O valor de x é {x}");
            }
        }
    }
}
