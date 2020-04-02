using System;

namespace CursoCsharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;

            // não pode ser alterada
            const double Pi = 3.14;

            raio = 5.5;
            //PI = 6.34;

            double area = Pi * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é :" + area);
        }
    }
}
