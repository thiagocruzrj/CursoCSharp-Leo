﻿using System;

namespace CursoCsharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(3,3));
            Console.WriteLine(mult(3,3));
        }
    }
}
