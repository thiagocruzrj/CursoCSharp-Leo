using OrientacaoObjeto;
using System;

namespace CursoCsharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {

        }
    }
}
