using System;

namespace CursoCsharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(mes: 3, dia: 18, ano: 1994);
        }
    }
}
