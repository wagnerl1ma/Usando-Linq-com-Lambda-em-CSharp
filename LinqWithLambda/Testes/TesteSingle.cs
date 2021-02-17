using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteSingle : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();

            // O Single e o SingleOrDefault é muito parecido com o metodo First e FirstOrDefault... 
            //...porém o Single percorre e lê a lista inteira até achar o resultado, já o First lê apenas o primeiro e já parar de percorrer a lista
            // O Single também te obriga a trazer apenas um unico resultado, caso ao contrário ele irá lançar exceção
            // O First e FirstOrDefault são mais performaticos que o Single e o SingleOrDefault


            //var clienteIdade = clientes.Single(x => x.Idade == 19);

            //var clienteIdade = clientes.SingleOrDefault(x => x.Idade == 19);
            //Console.WriteLine(clienteIdade.Idade);


            #region Teste com Single e First

            //O Single percorre e lê a lista inteira até achar o resultado
            var clienteComSingle = clientes.Single(x => x.SegundaIdade == 19);
            Console.WriteLine("Este é o cliente: " + clienteComSingle.Nome);

            //O First lê apenas o primeiro e já parar de percorrer a lista
            var clienteComFirst = clientes.First(x => x.SegundaIdade == 19);
            Console.WriteLine("Este é o cliente: " + clienteComFirst.Nome);

            #endregion
        }
    }
}
