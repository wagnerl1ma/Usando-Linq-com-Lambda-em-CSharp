using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.DataBase
{
    public static class DataBase
    {
        public static List<Cliente> GetClientes()
        {
            var listaClientes = new List<Cliente>();

            for (int index = 0; index <= 50; index++)
            {
                var cliente = new Cliente();
                cliente.Id = index;
                cliente.Nome = $"Cliente{index}";           //com o index vai receber, cliente1, cliente2....7
                cliente.Idade = 19 + index;                 //começa com 19 e vai receber mais a quantidade do index

                listaClientes.Add(cliente);
            }


            return listaClientes;
        }

        public static List<Ordem> GetOrdem()
        {
            var listaOrdem = new List<Ordem>();
            int idCliente = 0;

            for (int index = 0; index <= 1000; index++)
            {
                var ordem = new Ordem();
                ordem.Id = index;

                if (idCliente > 50)
                {
                    idCliente = 0;
                }

                ordem.IdCliente = idCliente;

                ordem.DataCriacao = DateTime.Now;
                ordem.ValorTotal = 10 * index;

                listaOrdem.Add(ordem);

                idCliente++;
            }

            return listaOrdem;
        }
    }
}
