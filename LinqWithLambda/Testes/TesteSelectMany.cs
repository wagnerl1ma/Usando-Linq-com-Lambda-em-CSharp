using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Testes
{
    public class TesteSelectMany : ITeste
    {
        public void Teste()
        {
            var pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa
            {
                Id = 1,
                Nome = "Wagner",
                TelefonePessoas = new List<TelefonePessoa>() { new TelefonePessoa { NumeroTelefone = "9999999999" }, new TelefonePessoa { NumeroTelefone = "8888888888" } }
            });


            pessoas.Add(new Pessoa
            {
                Id = 2,
                Nome = "Juliana",
                TelefonePessoas = new List<TelefonePessoa>() { new TelefonePessoa { NumeroTelefone = "777777777777" }, new TelefonePessoa { NumeroTelefone = "5555555555555" } }
            });


            #region Usando somente o método Select
            //retorna somente uma lista, com o somente select não é possível acessar a lista dentro de outra lista, para isso sera necessário fazer 2 foreach
            var telefonesSelect = pessoas.Select(x => x.TelefonePessoas);

            Console.WriteLine("-------------------Usando somente o Select-----------------------------");
            foreach (var ptelefone in telefonesSelect)
            {
                foreach (var telefone in ptelefone)
                {
                    Console.WriteLine("Telefones: " + telefone.NumeroTelefone);
                }
            }
            #endregion


            #region Usando somente o método SelectMany
            //Diferente do select, o SelectMany retorna todas as listas que estiver no objeto, sendo assim não é necessário fazer 2 foreach

            Console.WriteLine("-------------------Usando somente o SelectMany-----------------------------");

            var telefonesSelectMany = pessoas.SelectMany(x => x.TelefonePessoas);

            foreach (var item in telefonesSelectMany)
            {
                Console.WriteLine("Telefones com SelectMany: " + item.NumeroTelefone);
            }

            #endregion
        }


        class Pessoa
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<TelefonePessoa> TelefonePessoas { get; set; }
        }


        class TelefonePessoa
        {
            public string NumeroTelefone { get; set; }
        }
    }
}
