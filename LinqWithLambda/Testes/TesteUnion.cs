using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqWithLambda.Testes
{
    public class TesteUnion : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();

            #region Usando o Método Union
            //Serve para juntar consultas de listas do mesmo tipo

            var primeiroCliente = clientes.FirstOrDefault();
            var ultimoCliente = clientes.LastOrDefault();

            var primeiroClienteOrdens = ordens.Where(x => x.IdCliente == primeiroCliente.Id);
            var ultimoClienteOrdens = ordens.Where(x => x.IdCliente == ultimoCliente.Id);

            //Ao Inves de fazer um foreach para da cada lista: primeiroClienteOrdens e ultimoClienteOrdens, usei o union abaixo e fiz somente um foreach
            var FirstUnion = primeiroClienteOrdens.Union(ultimoClienteOrdens);


            foreach (var item in FirstUnion)
            {
                Console.WriteLine("Id Cliente: " + item.IdCliente + " - Valor Total: " + item.ValorTotal.ToString("C2"));
            }

            #endregion
        }
    }
}
