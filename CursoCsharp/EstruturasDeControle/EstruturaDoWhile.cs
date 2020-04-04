﻿using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome ? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {entrada}");
                Console.WriteLine("Deseja continuar ? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
