using System;

namespace CursoCsharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9;
            bool bomComportamento = false;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
