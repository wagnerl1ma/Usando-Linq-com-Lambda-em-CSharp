using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteSkip : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();


            #region Usando o método Skip
            //O metodo Skip pula uma quantidade de registros e pega o restante

            //Pular os 10 primeiros clientes e pegar o restante
            var skipClientes = clientes.Skip(10);

            foreach (var item in skipClientes)
            {
                Console.WriteLine(item.Nome);
            }

            #endregion


            #region Usando o método SkipWhile
            //O metodo SkipWhile pula uma quantidade de registros e pega o restante conforme a condição

            Console.WriteLine("-------------- Usando o SkipWhile --------------");

            //Pular somente a idade diferente de 40
            var skipWhileClientes = clientes.SkipWhile(x => x.Idade != 40);

            foreach (var item in skipWhileClientes)
            {
                Console.WriteLine("Skip While: " + item.Nome + " Idade: " + item.Idade);
            }

            #endregion
        }
    }
}
