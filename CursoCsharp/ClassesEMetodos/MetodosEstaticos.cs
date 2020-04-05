using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultadoSoma = CalculadoraEstatica.Somar(2, 4);
            Console.WriteLine($"Resultado: {resultadoSoma}.");
        }
    }
}
