using System;

namespace CursoCsharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            // Exemplo sem o break
            Random random = new Random();
            int num = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {num} !");

            for (int i = 1; i <= 50 ; i++)
            {
                Console.Write($"{i} é o número que quermos ? ");
                if (i == num)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else
                {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim");
        }
    }
}
