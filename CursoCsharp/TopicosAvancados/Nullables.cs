﻿using System;
namespace CursoCsharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine($"Valor de num: {num1}");
            } else
            {
                Console.WriteLine("Valor nulo ou não possue valor");
            }

            int valor1 = num1 ?? 1000;
            Console.WriteLine(valor1);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
