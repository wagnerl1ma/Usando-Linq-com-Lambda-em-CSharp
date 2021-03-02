using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteDesafio1 : ITeste
    {
        public void Teste()
        {
            //Desafio:
            //Se tivermos uma lista, como a baixo, como ficaria o comando em Linq para trazermos apenas as frutas com o nome menor ou igual a 5 letras?

            //Com Linq - foi necessário usar o COUNT

            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            Console.WriteLine("Frutas com o nome menor ou igual a 5 letras:");

            foreach (var item in fruits)
            {
                var contagem = item.Count();

                if (contagem <= 5)
                {
                    Console.WriteLine(item);
                }
            }


            // sem linQ - foi necessário usar o apenas o LENGTH

            List<string> fruits2 = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            foreach (var item in fruits2)
            {
                if (item.Length <= 5)
                {
                    Console.WriteLine(item);
                }
            }

        }

    }
}

