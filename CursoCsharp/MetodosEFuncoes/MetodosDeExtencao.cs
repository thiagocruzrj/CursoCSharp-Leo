using System;

namespace CursoCsharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtracao(this int num1, int num2)
        {
            return num1 - num2;
        }
    }
    class MetodosDeExtencao
    {
        public static void Executar()
        {
            int num = 5;

            Console.WriteLine(num.Soma(3));
            Console.WriteLine(num.Subtracao(10));
            Console.WriteLine(2.Subtracao(4));
            Console.WriteLine(2.Soma(4));
        }
    }
}
