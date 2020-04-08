using System;

namespace OrientacaoObjeto
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um Ig";

        // Herança
        protected string CorDosOlhos = "Verde";

        // Mesmo Projeto (assembly)
        internal ulong NumeroCelular = 5521999999999;

        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // Mesma classe ou herança no mesmo projeto
        private protected string SegredoDeFamilia = "Bla bla";

        // Private é o padrão
        private bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade ...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
