using System;

namespace CursoCsharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            return (double)a / (double)b;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine(calculadoraComum.Somar(1,2));
            Console.WriteLine(calculadoraComum.Subtrair(1,2));
            Console.WriteLine(calculadoraComum.Multiplicar(1,2));
            Console.WriteLine(calculadoraComum.Dividir(1,2));
        }
    }
}
