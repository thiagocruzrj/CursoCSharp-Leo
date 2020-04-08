﻿using System;

namespace CursoCsharp.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado :" + resultado;
        }

        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 10, 3));
            Console.WriteLine(Calculadora(Soma, 32, 8));
        }
    }
}
