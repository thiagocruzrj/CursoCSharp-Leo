using System;

namespace CursoCsharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.99);
            var p2 = new Produto("Caneta", 1.99);
            var p3 = p2;

            // são diferentes pois cada instancia de produto é armazenada em um espaço de memória diferente assim que é criado
            Console.WriteLine(p1 == p2);

            // serão iguais pois o p3 está recebendo a referencia da memoria do valor p2
            Console.WriteLine(p3 == p2);

            // falso pois o equals compara o endereço de memória, usando o override na classe Produto alteramos o metodo Equals para comparar os valores e não o endereço da memoria
            // fazendo assim recebermos aqui true
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
