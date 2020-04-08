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

    public class AmigoDistante
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante...");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos);
            //Console.WriteLine(amigo.NumeroCelular);
            //Console.WriteLine(amigo.JeitoDeFalar);
            //Console.WriteLine(amigo.SegredoDeFamilia);
            //Console.WriteLine(amigo.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {

        }
    }
}
