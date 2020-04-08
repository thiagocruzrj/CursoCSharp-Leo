using System;

namespace CursoCsharp.OO
{
    // Uma classe selada não permite herança e nem sobreescrita (override)
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_405_033.65;
        }
    }

    //class SouFilho : SemFilho { }

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        // Não consiguimos já que o metodo foi selado de herança e sobreescrita
        //public override sealed bool HonrarNomeFamilia()
        //{
        //    return false;
        //}

        // Mas podemos ocultar o metodo herdado
        //public new bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho sem = new SemFilho();
            Console.WriteLine($"O valor da fortuna é R$ {sem.ValorDaFortuna()}");

            FilhoRebelde rebelde = new FilhoRebelde();
            Console.WriteLine(rebelde.HonrarNomeFamilia());
        }
    }
}
