using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Model
{
    public class Ordem
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
