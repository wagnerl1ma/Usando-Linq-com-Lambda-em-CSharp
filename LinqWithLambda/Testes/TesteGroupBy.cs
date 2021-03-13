using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteGroupBy : ITeste
    {
        public void Teste()
        {
            //var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();

            #region Usando o Método GroupBy
            //Serve para agrupar resultados em nossas consultas
            //Quando usar o group by e necessário usar o select também para espeficicar o campo que voce quer agrupar

            //Agrupando por IdCliente, Somando o Valor total de compras, calculando o média dos gastos e mostrando a quantidade total dos pedidos
            var TotalOrdens = ordens.GroupBy(x => x.IdCliente)
                .Select(x =>
            new
            {
                IdCliente = x.Key,
                ValorTotal = x.Sum(y => y.ValorTotal),
                ValorMedia = x.Average(y => y.ValorTotal),
                TotalOrdens = x.Count()
            }
            );


            foreach (var item in TotalOrdens)
            {
                Console.WriteLine("Cliente " + item.IdCliente + " - Valor Total: " + item.ValorTotal.ToString("C2") + " - Valor Média: " + item.ValorMedia.ToString("C2")
                    + " - Contagem dos Pedidos: " + item.TotalOrdens);
            }


            #endregion
        }
    }
}
