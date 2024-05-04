using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemCompra
    {
        public int Id { get; set; }
        public Compra Compra { get; set; }
        public Produto Produto { get; set; }
        
        public double Preco { get; set; }
    }
}
