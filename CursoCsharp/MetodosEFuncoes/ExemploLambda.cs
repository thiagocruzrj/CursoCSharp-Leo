﻿using System;

namespace CursoCsharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formartarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            Console.WriteLine(formartarData(18,03,94));
        }
    }
}
