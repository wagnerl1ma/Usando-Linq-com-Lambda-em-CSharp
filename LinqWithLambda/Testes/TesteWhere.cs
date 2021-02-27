using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteWhere : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();

            #region Usando o método Where
            //Usando o Where é póssivel usar mais de uma condição no filtro

            var clienteIdade = clientes.Where(x => x.Idade > 40 && x.Idade < 51);

            foreach (var item in clienteIdade)
            {
                Console.WriteLine(item.Nome + " Idade: " + item.Idade);
            }

            Console.WriteLine("---------------------------------------------------------");
            var primeiroClienteOrdem = ordens.Where(x => (x.IdCliente == 1 && x.ValorTotal > 1000 && x.ValorTotal < 3000) || (x.IdCliente == 2));
            
            //Se as condições foram muito grande, é recomendado criar um metod conforme a linha de baixo
            //var primeiroClienteOrdem = ordens.Where(x => ValidarOrdem(x));


            foreach (var item in primeiroClienteOrdem)
            {
                Console.WriteLine("Id Cliente: " + item.IdCliente + " ValorTotal: " + item.ValorTotal.ToString("C2"));  // ToString("C2") = formato em real
            }

            #endregion
        }

        private bool ValidarOrdem(Model.Ordem x)
        {
            return (x.IdCliente == 1 && x.ValorTotal > 1000 && x.ValorTotal < 3000) || (x.IdCliente == 2);
        }
    }
}
