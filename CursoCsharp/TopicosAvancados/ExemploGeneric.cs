using System;

namespace CursoCsharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = Coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class ExemploGeneric
    {
        public static void Executar()
        {

        }
    }
}
