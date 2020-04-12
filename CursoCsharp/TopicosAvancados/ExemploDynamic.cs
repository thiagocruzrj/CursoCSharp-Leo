using System;

namespace CursoCsharp.TopicosAvancados
{
    class ExemploDynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maira";
            aluno.nota = 1.7;
            aluno.idade = 17;
            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}