using System;

namespace CursoCsharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero += 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 += 15;
            numero2 += 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a); // Utilizamos o Ref para modificar a referencia da função, sendo assim o valor passa a ser o que está incluso na variavel a sendo ela agora o valor do parametro (numero = 3 + 1000)

            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b}, {c}");
        }
    }
}
