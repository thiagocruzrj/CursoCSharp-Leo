﻿using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome ? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é {nome}, de idade {idade} com o salario R${salario}");
        }
    }
}