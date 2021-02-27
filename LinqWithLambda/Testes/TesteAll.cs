using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteAll : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            //var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o método All
            //Verifica se todos os clientes que estão na lista corresponde a condição
            //retona true ou false

            var todosClientesIdMaiorQueZero = clientes.All(x => x.Id >= 0);

            if (todosClientesIdMaiorQueZero == true)
            {
                Console.WriteLine("Contém todos os clientes id maior que 0");
            }
            else
            {
                Console.WriteLine("Não contém todos os clientes id maior que 0");
            }


            var todosClientesIdadeMaiorQueVinte= clientes.All(x => x.Idade > 20);

            if (todosClientesIdadeMaiorQueVinte == true)
            {
                Console.WriteLine("Contém todos os clientes com mais do que 20 anos ");
            }
            else
            {
                Console.WriteLine("Não Contém todos os clientes com mais do que 20 anos");
            }

            #endregion
        }
    }
}
