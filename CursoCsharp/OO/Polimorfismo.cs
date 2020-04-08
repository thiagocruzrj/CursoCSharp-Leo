﻿using System;

namespace CursoCsharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso) { Peso = peso; }

        public Comida() { }
    }
    public class Feijao : Comida { public Feijao(double peso) : base(peso) { } }

    public class Arroz : Comida { public Arroz(double peso) : base(peso) { } }

    public class Carne : Comida { public Carne(double peso) : base(peso) { } }

    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.3);

            Arroz ingrediente2 = new Arroz(0.25);

            Carne ingrediente3 = new Carne(0.3);

            Pessoa cliente = new Pessoa();
            cliente.Peso = 90.0;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é KG {cliente.Peso}!");
        }
    }
}
