using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteDistinct : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();
            var ordens = DataBase.DataBase.GetOrdem();


            #region Usando o método Distinct
            //Serve para verificar ou tirar dados repetidos em uma consulta
            //verifica se contém duplicados e tira os duplicados e deixa um registro de cada

            //exemplo que repete os ids
            //foreach (var ordem in ordens)
            //{
            //    Console.WriteLine(ordem.Id);
            //}

            //verifica se contém duplicados e tira os duplicados e deixa um registro de cada
            var clientesIds = ordens.Select(x => x.IdCliente).Distinct();

            foreach (var cliente in clientesIds)
            {
                Console.WriteLine(cliente);
            }

            #endregion
        }
    }
}
