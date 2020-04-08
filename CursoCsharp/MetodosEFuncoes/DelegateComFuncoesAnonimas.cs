using System;

namespace CursoCsharp.MetodosEFuncoes
{
    class DelegateComFuncoesAnonimas
    {
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            StringOperacao inverter = delegate (string o)
            {
                char[] charArray = o.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };
            Console.WriteLine(inverter("Doideira isso ae ..."));
        }
    }
}
