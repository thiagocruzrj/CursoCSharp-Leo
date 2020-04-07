using System;
using System.Collections;

namespace CursoCsharp.Colecoes
{
    class UsandoArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList
            {
                "Word",
                3,
                false
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
