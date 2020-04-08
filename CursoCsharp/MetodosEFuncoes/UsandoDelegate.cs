using System;

namespace CursoCsharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImpimirSoma(double a, double b);

        static double MinhaSoma(double a, double b)
        {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(3,4));

            ImpimirSoma i1 = MeuImprimirSoma;
            i1(9, 10);

            Func<double, double, double> funcTeste = MinhaSoma;
            Console.WriteLine(funcTeste(10, 20));

            Action<double, double> actTest = MeuImprimirSoma;
            actTest(30, 40);
        }
    }
}
