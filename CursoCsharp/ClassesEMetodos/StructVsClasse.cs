using System;

namespace CursoCsharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por Valor e não por referencia. (Struct a passagem sempre é por valor e não por referencia)
            ponto1.X = 3; 

            Console.WriteLine($"Ponto 1 X: {ponto1.X}");
            Console.WriteLine($"Copia ponto 1 X: {copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição de uma classe é feita por referencia (trocando assim o valor pelo novo setado)
            ponto2.X = 6;

            Console.WriteLine($"\nPonto 2 X: {ponto2.X}");
            Console.WriteLine($"Copia ponto 2 X: {copiaPonto2.X}");
        }
    }
}
