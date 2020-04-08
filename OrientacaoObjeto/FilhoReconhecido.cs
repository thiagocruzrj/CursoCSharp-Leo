using System;

namespace OrientacaoObjeto
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
