using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteLast : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();

            #region Usando o método Last
            //O Metodo Last é a mesma coisa do First, porém ele pega o ultimo registro.
            //Se atentar quando usar o metodo Last, quando ele não achar retorno nenhum, ele para a aplicação informando que está nulo
            // é recomendado usar o Try/Catch para fazer um tratamento nesses casos usado pelo metodo Last

            var clienteLast = clientes.Last();
            Console.WriteLine(clienteLast.Nome);

            try
            {
                var erroCliente = clientes.Last(x => x.Id < 0);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Este cliente não existe! - " + ex.Message);
            }

            #endregion


            #region Usando o método LastOrDefault

            // Usando o LastOrDefault ele não estoura exceção, caso não encontrar vai retornar nulo ou vazio ou 0
            Console.WriteLine("-------------- Usando o LastOrDefault --------------");

            var clienteLastOrDefault = clientes.LastOrDefault(x => x.Id < 0);
            //var clienteLastOrDefault = clientes.LastOrDefault(x => x.Id == 1);

            if (clienteLastOrDefault == null)
            {
                Console.WriteLine("Este cliente não existe! ");
            }
            else
            {
                Console.WriteLine(clienteLastOrDefault.Nome);
            }

            #endregion

        }
    }
}
