using System;

namespace CursoCsharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie o meu atendimento(0-5) ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimos");
                    Console.WriteLine("Estamos muito felizes com isso !");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Atendimento finalizado ...");
        }
    }
}
