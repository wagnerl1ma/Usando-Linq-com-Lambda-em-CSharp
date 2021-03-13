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
            //ITeste teste = new TesteSelect();
            //ITeste teste = new TesteFirst();
            //ITeste teste = new TesteSingle();
            //ITeste teste = new TesteLast();
            //ITeste teste = new TesteTake();
            //ITeste teste = new TesteSkip();
            //ITeste teste = new TesteJoin();
            //ITeste teste = new TesteSelectMany();
            //ITeste teste = new TesteOrderBy();
            //ITeste teste = new TesteWhere();
            //ITeste teste = new TesteAny();
            //ITeste teste = new TesteContains();
            //ITeste teste = new TesteAll();
            //ITeste teste = new TesteDistinct();
            //ITeste teste = new TesteDesafio1();
            //ITeste teste = new TesteMaxCountMaxMin();
            //ITeste teste = new TesteSumAverage();
            ITeste teste = new TesteGroupBy();
            teste.Teste();


            Console.ReadLine();
        }
    }
}
