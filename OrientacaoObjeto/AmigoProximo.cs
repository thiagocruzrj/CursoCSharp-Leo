using System;

namespace OrientacaoObjeto
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo próximo ...");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos);
            Console.WriteLine(amigo.NumeroCelular);
            Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoDeFamilia);
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }
    }
}
