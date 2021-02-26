using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteOrderBy : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();


            //retorna o cliente e todas as ordens
            //parametros: 1º lista clientes ou de ordens, 2º id da lista de clientes, 3º id da lista de ordens, 4º Instanciar uma nova lista com os parametros que foram definidos
            var clienteOrdens = clientes.Join(
                ordens, cliente => cliente.Id,
                ordem => ordem.IdCliente,
                (cliente, ordem) => new { ClienteId = cliente.Id, Nome = cliente.Nome, Idade = cliente.Idade, ValorTotal = ordem.ValorTotal, DataCriacao = ordem.DataCriacao });


            #region Usando o método OrderBy
            //Ordena a lista pela chave que foi definida, ordenando do menor para o Maior

            foreach (var item in clienteOrdens.OrderBy(x => x.ValorTotal))
            {
                //Console.WriteLine(item.Nome + " Comprou: " + item.ValorTotal.ToString("C2"));   // ToString("C2") = formato em real
            }
            #endregion



            #region Usando o método OrderByDescending
            //Ordena a lista pela chave que foi definida, ordenando do Maior para o menor

            foreach (var item in clienteOrdens.OrderByDescending(x => x.ValorTotal))
            {
                //Console.WriteLine(item.Nome + " Comprou: " + item.ValorTotal.ToString("C2"));   // ToString("C2") = formato em real
            }
            #endregion


            #region Usando o método OrderBy com o ThenBy
            //Ordena pelo nome e depois pelo valor total usando o ThenBy, mostrando os valores pelas ordens do menor para o maior

            foreach (var item in clienteOrdens.OrderBy(x => x.Nome).ThenBy(x => x.ValorTotal))
            {
                Console.WriteLine(item.Nome + " Comprou: " + item.ValorTotal.ToString("C2"));   // ToString("C2") = formato em real
            }
            #endregion


            #region Usando o método OrderBy com o ThenByDescending
            //Ordena pelo nome e depois pelo valor total usando o ThenByDescending, mostrando os valores pelas ordens do maior para o menor

            foreach (var item in clienteOrdens.OrderBy(x => x.Nome).ThenByDescending(x => x.ValorTotal))
            {
                //Console.WriteLine(item.Nome + " Comprou: " + item.ValorTotal.ToString("C2"));   // ToString("C2") = formato em real
            }
            #endregion
        }
    }
}
