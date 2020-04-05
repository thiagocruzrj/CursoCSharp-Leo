using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {

        // Metodo de classe ou metodo estatico (somente 1 copia)
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        // Metodo de instancia, pode ser instanciado inumeras vezes
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

            Console.WriteLine(CalculadoraEstatica.Multiplicar(10, 7));
        }
    }
}
