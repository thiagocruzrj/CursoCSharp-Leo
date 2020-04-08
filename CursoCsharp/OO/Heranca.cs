using System;

namespace CursoCsharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        // somente com o modificador virtual conseguimos sobreescrever o metodo
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200) { }
    }

    public class Bmw : Carro
    {
        public Bmw() : base(320)
        {
        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        // Ocutando o método da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-10);
        }
    }

    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno ...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("\nBMW ...");
            Bmw carro2 = new Bmw();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            // Ao criar um carro do tipo Bmw damos override no metodo pai, mas o metodo oculto 
            // dentro da classe Bmw não é utilizado
            Console.WriteLine("Bmw com tipo Carro...");
            Carro carro3 = new Bmw();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("\nUno com tipo Carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
