using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            // 1 Opção
            //if(cilindrada > 0)
            //    Cilindrada = cilindrada;
            // 2 opção
            //Cilindrada = Math.Abs(cilindrada);
            // Somente inteiros positivos
            Cilindrada = cilindrada;
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Z-1000", 1000);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("Hornet");
            moto2.SetCilindrada(600);
            Console.WriteLine($"A moto da marca {moto2.GetMarca()} do modelo {moto2.GetModelo()} tem o total de {moto2.GetCilindrada()} cilindradas!");
        }
    }
}
