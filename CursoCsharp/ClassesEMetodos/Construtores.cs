using System;

namespace CursoCsharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro = new Carro();
            carro.Modelo = "X1";
            carro.Fabricante = "BMW";
            carro.Ano = 2017;

            Console.WriteLine($"O carro {carro.Modelo} da fabricante {carro.Fabricante} construido no ano {carro.Ano} foi leiloado.");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"O carro {carro2.Modelo} da fabricante {carro2.Fabricante} construido no ano {carro2.Ano} foi leiloado.");
        }
    }
}
