using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteJoin : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();

            #region Usando o método Join
            //retorna o cliente e todas as ordens, exemplo: retorna o nome do cliente variaz vezes junto com todas as compras dele. 
            //parametros: 1º lista clientes ou de ordens, 2º id da lista de clientes, 3º id da lista de ordens, 4º Instanciar uma nova lista com os parametros que foram definidos
            var clienteOrdem = clientes.Join(
                ordens, cliente => cliente.Id,
                ordem => ordem.IdCliente,
                //(cliente, ordem) => new { Cliente = cliente, Ordem = ordem }             //retorna a lista com todas a propriedades
                (cliente, ordem) => new { Nome = cliente.Nome, ValorTotal = ordem.ValorTotal, Data = ordem.DataCriacao }  //retornando apenas as propriedades que desejo
                );

            foreach (var item in clienteOrdem)
            {
                //Console.WriteLine("O cliente " + item.Cliente.Nome + " comprou " + item.Ordem.ValorTotal.ToString("c2") + " em " + item.Ordem.DataCriacao.ToString("dd/MM"));
                Console.WriteLine("O cliente " + item.Nome + " comprou " + item.ValorTotal.ToString("c2") + " em " + item.Data.ToString("dd/MM"));
            }

            //juntar lista manual é necessário chamar as duas lista e fazer um foreach em cada uma, e verificar se o id ordem é iagual ao id cliente
            //foreach (var cliente in clientes)
            //{
            //    foreach (var ordem in ordens)
            //    {
            //        if (cliente.Id == ordem.Id)
            //        {
            //            //Esta ordem tem vinculo com esse cliete
            //        }
            //    }
            //}

            #endregion



            #region Usando o método GroupJoin

            //retorna o cliente e todas as ordens, exemplo: retorna somente uma vez o nome do cliente e todas as compras dele. 
            //parametros: 1º lista clientes ou de ordens, 2º id da lista de clientes, 3º id da lista de ordens, 4º Instanciar uma nova lista com os parametros que foram definidos

            Console.WriteLine("------------------------------ Usando o método GroupJoin ---------------------------------------");

            var clienteOrdemGroupJoin = clientes.GroupJoin(
                ordens, cliente => cliente.Id,
                ordem => ordem.IdCliente,
                (cliente, todasOrdens) => new { Cliente = cliente, TodasOrdens = todasOrdens }             //retorna a lista com todas a propriedades
                );

            foreach (var item1 in clienteOrdemGroupJoin)
            {
                Console.WriteLine("O cliente " + item1.Cliente.Nome + " comprou:");

                foreach (var ordem in item1.TodasOrdens)
                {
                    Console.WriteLine("Valor Total: " + ordem.ValorTotal.ToString("c2") + " em " + ordem.DataCriacao.ToString("dd/MM"));
                }

                
            }


            #endregion
        }
    }
}
