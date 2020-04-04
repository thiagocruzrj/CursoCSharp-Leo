using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if(nota >= 9)
            {
                Console.WriteLine("Aluno no quadro de honra");
            } else if (nota >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            } else if (nota >= 5)
            {
                Console.WriteLine("Recuperaçãoi");
            } else
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("Boas festas");
        }
    }
}
