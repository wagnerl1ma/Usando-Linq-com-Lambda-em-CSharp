using LinqWithLambda.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITeste teste = new TesteTodosClientes();
            ITeste teste = new TesteSelect();
            teste.Teste();


            Console.ReadLine();
        }
    }
}
