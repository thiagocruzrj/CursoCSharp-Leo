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
                conta.Sacar(1600);
                Console.WriteLine("Saque realizado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thanks bro !");
            }
        }
    }
}
