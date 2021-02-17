using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteFirst : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();


            #region Usando o método First

            var firstCliente = clientes.First();

            Console.WriteLine(firstCliente.Nome);
            //Outra forma de selecionar apenas o primeiro NOME da lista
            //Console.WriteLine(clientes.Select(x => x.Nome).First());


            var firstClienteIdade = clientes.First(x => x.Idade > 30);
            Console.WriteLine(firstClienteIdade.Nome + " Idade:" + firstClienteIdade.Idade);


            //Se atentar quando usar o metodo First, quando ele não achar retorno nenhum, ele para a aplicação informando que está nulo
            // é recomendado usar o Try/Catch para fazer um tratamento nesses casos usado pelo metodo First
            try
            {
                var firstClienteIdadeMenor10 = clientes.First(x => x.Idade < 10);
                Console.WriteLine(firstClienteIdadeMenor10.Nome + " Idade:" + firstClienteIdadeMenor10.Idade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi encontrado nenhum cliente com essa condição! " + " Detalhes: " + ex.Message);
            }

            #endregion


            #region Usando o método FirstOrDefault

            // Usando o FirstOrDefault ele não estoura exceção, caso não encontrar vai retornar nulo ou vazio ou 0
            Console.WriteLine("-------------- Usando o FirstOrDefault --------------");

            //var queryComFirstOrDefault = clientes.FirstOrDefault();
            var queryComFirstOrDefault = clientes.FirstOrDefault(x => x.Idade > 30);
            Console.WriteLine(queryComFirstOrDefault.Nome);


            var firstOrDefaultClienteIdadeMenor10 = clientes.FirstOrDefault(x => x.Idade < 10);

            if(firstOrDefaultClienteIdadeMenor10 != null)
            {
                Console.WriteLine(firstOrDefaultClienteIdadeMenor10.Nome + " Idade:" + firstOrDefaultClienteIdadeMenor10.Idade);
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum cliente com essa condição! ");
            }

            //var idadesCliente = clientes.Select(x => x.Idade).FirstOrDefault(idade => idade < 10);
            //Console.WriteLine(idadesCliente);
           
            var idadesCliente = clientes.Select(x => x.Idade);
            var firtstIdade = idadesCliente.FirstOrDefault(idade => idade < 10);

            Console.WriteLine(firtstIdade);
            #endregion

        }
    }
}
