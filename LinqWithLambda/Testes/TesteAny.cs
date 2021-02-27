using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteAny : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o método Any
            //verifica se contem pelo menos um registro na condição que foi escrita - retorna true ou false
            //também é possível passar a condição que voce deseja dentro do Any usando Expressões Lambda

            var grandeOrdens = ordens.Where(x => x.ValorTotal > 5000);

            if (grandeOrdens.Any())  
            {
                Console.WriteLine("Possui registro acima de 5 mil");
            }
            else
            {
                Console.WriteLine("Não possui registro acima de 5 mil");
            }

            Console.WriteLine("----------------------------------------------------");

            bool temGrandesOrdens = ordens.Any(x => x.ValorTotal > 500000);

            if (temGrandesOrdens == true)
            {
                Console.WriteLine("Possui registro acima de 5 mil");
            }
            else
            {
                Console.WriteLine("Não possui registro acima de 5 mil");
            }

            //Juntando o Any com o Where
            var clienteVelhoOrdens = ordens.Where(order => clientes.Any(cliente => cliente.Id == order.Id && cliente.Idade > 50));

            foreach (var item in clienteVelhoOrdens)
            {
                Console.WriteLine("Id Cliente: " + item.IdCliente + " - Valor Total: " + item.ValorTotal.ToString("C2"));
            }

            #endregion

        }
    }
}
