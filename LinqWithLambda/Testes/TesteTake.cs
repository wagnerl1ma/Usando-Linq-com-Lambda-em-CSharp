using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteTake : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();


            #region Usando o método Take
            // É usado para retornar somente a quantidade que voce deseja de uma lista.

            //retornando os 10 primeiros clientes
            var dezClientesPrimeiros = clientes.Take(10);

            foreach (var item in dezClientesPrimeiros)
            {
                Console.WriteLine(item.Nome);
            }

            #endregion


            #region Usando o método TakeWhile
            //Retorna os elementos de uma sequência contanto que uma condição especificada seja verdadeira
            //Depois que a condição for atendida ele para a execução

            Console.WriteLine("-------------- Usando o TakeWhile --------------");

            //retornando somente os clientes que tem a idade diferente de 40 anos e quando ele achar um cliente diferente de 40 o metodo TakeWhile para a leitura da lista e não lé o restante
            var takeWhileClientes = clientes.TakeWhile(x => x.Idade != 40);

            //o metodo Where é parecido com o TakeWhile, porém ele não para a leitura da lista depois da condição
            //var takeWhileClientes = clientes.Where(x => x.Idade != 40);

            foreach (var item in takeWhileClientes)
            {
                Console.WriteLine(item.Nome + "-" + " " + item.Idade);
            }


            #endregion

        }
    }
}
