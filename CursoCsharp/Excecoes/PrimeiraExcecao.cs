using System;

namespace CursoCsharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new AggregateException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            Conta conta = new Conta(1_245.45);

            try
            {
                //int.Parse("abc");
                conta.Sacar(1600);
                Console.WriteLine("Saque realizado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Thanks bro !");
            }
        }
    }
}
