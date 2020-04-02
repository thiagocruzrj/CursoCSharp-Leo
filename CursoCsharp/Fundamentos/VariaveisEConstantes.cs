using System;

namespace CursoCsharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;

            // não pode ser alterada
            const double Pi = 3.14;

            raio = 5.5;
            //PI = 6.34;

            double area = Pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é :" + area);

            // Tipos internos

            bool estaChovendo = false;
            Console.WriteLine("Está chovendo ?" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor do int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Polulação brasileira = " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long : " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial : " + populacaoMundial);

            float precoComputador = 1299.89f;
            Console.WriteLine("Computador preco: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor mercado apple: " + valorDeMercadoApple);

            decimal distanciaDasEstrelasEmMetros = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas" + distanciaDasEstrelasEmMetros);

            char letra = 'b';
            Console.WriteLine(letra);

            string text = "Bem vindo ao curso de C#";
            Console.WriteLine(text);
        }
    }
}
