using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteTodosClientes : ITeste
    {
        public void Teste()
        {
            var clientes = DataBase.DataBase.GetClientes();


            foreach (var item in clientes)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}
