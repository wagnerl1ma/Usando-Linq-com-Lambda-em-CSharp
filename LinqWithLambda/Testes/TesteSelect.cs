using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteSelect : ITeste
    {
        public void Teste()
        {
            var listaClientes = DataBase.DataBase.GetClientes();

            ////select em Linq apenas no nome do cliente
            //var primeiraQueryClientes = from cliente in listaClientes select cliente.Nome;

            ////select em Linq apenas no Id e Nome
            //var primeiraQueryClientes2 = from cliente in listaClientes select new { cliente.Id, cliente.Nome };

            //foreach (var item in primeiraQueryClientes)
            //{
            //    Console.WriteLine(item);
            //}


            //Select com Linq e Lambda, apenas o nome do cliente
            var segundaQueryClientes = listaClientes.Select(cliente => cliente.Nome);

            //Select com Linq e Lambda, Id e nome do cliente
            var segundaQueryClientes2 = listaClientes.Select(cliente => new { cliente.Id, cliente.Nome});


            foreach (var item in segundaQueryClientes2)
            {
                Console.WriteLine(item.Nome + " " + item.Id);
            }
        }
    }
}
