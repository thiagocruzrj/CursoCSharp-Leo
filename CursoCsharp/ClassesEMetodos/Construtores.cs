using System;

namespace CursoCsharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
    }

    class Construtores
    {
        public static void Executar()
        {
            Carro carro = new Carro();
            carro.Modelo = "X1";
            carro.Fabricante = "BMW";
            carro.Ano = 2017;

            Console.WriteLine($"O carro {carro.Modelo} da fabricante {carro.Fabricante} construido no ano {carro.Ano} foi leiloado.");
        }
    }
}
