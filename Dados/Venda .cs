using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Venda
    {
        public Produto Produto { get; set; }
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Instante { get; set; }
        public string Descricao { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }
    }
}
