﻿using System;

namespace CursoCsharp.OO
{
    public class Feijao
    {
        public double Peso;
    }

    public class Arroz
    {
        public double Peso;
    }

    public class Carne
    {
        public double Peso;
    }

    public class Pessoa
    {
        public double Peso;
        public void Comer(Feijao feijao)
        {
            Peso += feijao.Peso;
        }

        public void Comer(Arroz arroz)
        {
            Peso += arroz.Peso;
        }

        public void Comer(Carne carne)
        {
            Peso += carne.Peso;
        }
    }

    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 90.0;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine(cliente.Peso);
        }
    }
}
