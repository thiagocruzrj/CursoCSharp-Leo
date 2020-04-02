using System;

namespace CursoCsharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada é {notaTruncada}");

            Console.Write("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine(idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Idade convertida {idadeInteiro}");

            Console.Write("Digite o primeiro numero :");
            string palavra = Console.ReadLine();
            //int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine($"Resultado : {numero}");

            Console.Write("Digite o segundo numero :");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2: {numero2}");
        }
    }
}
