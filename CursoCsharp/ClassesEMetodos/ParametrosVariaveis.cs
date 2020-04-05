using System;

namespace CursoCsharp.ClassesEMetodos
{
    class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Isabella", "Thainá", "Suzi");
        }
    }
}
