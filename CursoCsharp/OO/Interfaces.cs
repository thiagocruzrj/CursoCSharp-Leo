using System;

namespace CursoCsharp.OO
{
    interface OperacaoBinaria
    {
        // Internamente todos os itens de uma interface são publicos e abstratos
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }

    class Interfaces
    {
        public static void Executar()
        {

        }
    }
}
