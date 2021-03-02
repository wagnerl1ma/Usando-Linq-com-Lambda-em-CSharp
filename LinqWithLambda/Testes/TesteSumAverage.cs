using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteSumAverage : ITeste
    {
        public void Teste()
        {
            //var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o metodo Sum
            //Calcula a soma de uma sequencia de valores

            var somaValorTotal = ordens.Sum(x => x.ValorTotal);
            Console.WriteLine("Soma total: " + somaValorTotal.ToString("C2"));

            #endregion


            #region Usando o metodo Average
            //Calcula a média de uma sequencia de valores

            var mediaValorTotal = ordens.Average(x => x.ValorTotal);
            Console.WriteLine("Média total: " + mediaValorTotal.ToString("C2"));

            #endregion

            Console.WriteLine("Total Ordens: " + ordens.Count());
            Console.WriteLine("Média Total Ordens: " + (somaValorTotal / ordens.Count()).ToString("C2"));  // caso nao usar o método Average é necessário fazer a média manual


            var primeiroClienteOrdens = ordens.Where(x => x.IdCliente == 0);
            Console.WriteLine("Soma Total cliente 0: " + primeiroClienteOrdens.Sum(x => x.ValorTotal).ToString("C2"));
            Console.WriteLine("Média Total Clinte 0: " + primeiroClienteOrdens.Average(x => x.ValorTotal).ToString("C2"));
        }
    }
}
