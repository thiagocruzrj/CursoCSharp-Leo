using System;

namespace CursoCsharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            // pós-fixado
            num1++;
            Console.WriteLine(num1);

            // pré-fixado
            --num1;
            Console.WriteLine(num1);

            /* num1 será incrementado depois da comparação e num2 será incrementado antes da comparação
            *  Codigo de difícil leitura
            */
            Console.WriteLine(num1++ == --num2);

            Console.WriteLine($"{num1} e {num2}");
        }
    }
}
