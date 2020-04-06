using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} e {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} e {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Thiago",
                Idade = 26
            };

            Dependente depCopia = dep;
            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{depCopia.Nome} {depCopia.Idade}");

            depCopia.Nome = "Renato";
            dep.Idade = 13;

            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{depCopia.Nome} {depCopia.Idade}");
            // Novamente: Por ser uma classe a alteração será feita em ambas as instancias pois uma classe aponta para o mesmo local na memoria(referencia);
            // Novamente: Caso utilizamos struct teremos a alteração feita tanto no nome da copia quanto na idade do dep, já que é levado em consideração o valor;
        }
    }
}
