using System;

namespace CursoCsharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    class ExcecoesPersonalizadas
    {
        public static void Executar()
        {

        }
    }
}
