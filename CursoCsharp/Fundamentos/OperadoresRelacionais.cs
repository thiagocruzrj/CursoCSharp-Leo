using System;

namespace CursoCsharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite a sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Perfeito {0}?", nota == 10);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Reprovado ? {0}", nota <= 3.0);
            Console.WriteLine("Recuperação ? {0}", nota > 3.0 && nota < 6.9);
            Console.WriteLine("Aprovado ? {0}", nota >= notaDeCorte);
        }
    }
}
