using System;

namespace CursoCsharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto);
            Console.WriteLine("O preco final é {0}", totalDesconto);

            // IMC
            double peso = 92;
            double altura = 1.78;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu imc é: {imc}");
        }
    }
}
