using System;

namespace CursoCsharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "thiago";
            //nome = 123;
            Console.WriteLine(nome);

            // declarando variavel
            int a;
            a = 3;

            // declarando e atribuindo valor a variavel
            int b = 4;

            int resultado = (a + b);
            Console.WriteLine(resultado);
        }
    }
}
