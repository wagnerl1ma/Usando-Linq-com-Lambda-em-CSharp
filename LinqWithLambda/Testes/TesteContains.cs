using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteContains : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            //var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o método Contains
            //Retorna True ou False

            var IdsClientes = clientes.Select(x => x.Id);

            //Verificando se contem o id 50
            if (IdsClientes.Contains(50))
            {
                Console.WriteLine("Contém o id com esse valor.");
            }
            else
            {
                Console.WriteLine("Não contém o id com esse valor.");
            }


            var NomeClientes = clientes.Select(x => x.Nome);

            //Verificando se contem o nome Cliente0
            if (NomeClientes.Contains("Cliente0"))
            {
                Console.WriteLine("Contém esse nome");
            }
            else
            {
                Console.WriteLine("Não contém esse nome");
            }



            #endregion
        }
    }
}
