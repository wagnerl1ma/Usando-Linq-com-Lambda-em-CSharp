using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteMaxCountMaxMin : ITeste
    {
        public void Teste()
        {
            //var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o Método Count
            //Retorna o numéro de elementos de uma sequencia

            var contarOrdens = ordens.Count();
            Console.WriteLine("Contagem das Ordens: " + contarOrdens);

            #endregion


            #region Usando o Método Max
            //Retorna o maior valor

            //retornando o valor maximo de ValorTotal, verifica o campo que tem o maior valor.
            var maxValorTotal = ordens.Max(x => x.ValorTotal);
            Console.WriteLine("Valor Máximo: " + maxValorTotal);

            #endregion



            #region Usando o Método Min
            //Retorna o menor valor

            //retornando o valor minimo de ValorTotal, verifica o campo que tem o menor valor.
            var minValorTotal = ordens.Min(x => x.ValorTotal);
            Console.WriteLine("Valor Minimo: " + minValorTotal);

            #endregion

            Console.WriteLine();
            Console.WriteLine("RESUMO:");
            var primeiroClienteOrdens = ordens.Where(x => x.IdCliente == 1);
            Console.WriteLine("Quantidade de pedidos: "  + primeiroClienteOrdens.Count());
            Console.WriteLine("Pedido com maior valor: " + primeiroClienteOrdens.Max(x => x.ValorTotal));
            Console.WriteLine("Pedido com menor valor: " + primeiroClienteOrdens.Min(x => x.ValorTotal));
        }
    }
}
