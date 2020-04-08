using System;
using System.Collections.Generic;

namespace CursoCsharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "Tururu tururuuuu tru tu ru ru ru ruuuu ru";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Siri!";
        }
    }

    // A classe abstrata serve para ser herdada por outras classes, sendo que as classes concretas que herdarem
    // obrigatoriamente precisamos implementar todos os metodos abstratos que foram recebidos por herança

    // Classes concretas - Metodos implementados
    // Classes abstradas - Metodos implementados(concretos)/ Metodos não implementados(abstrados) - Quando outra classe herdar tem obrigatoriedade de implementar os metodos abstratos(incompletos);
    // Interfaces - Todos os metodos abstratos nos quais devem ser implementados - contrato

    class ClassesAbstratas
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
