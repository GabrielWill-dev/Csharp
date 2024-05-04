using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ItemCompraRepository
    {
        private IList<ItemCompra> _itens = new List<ItemCompra>();

        public ItemCompra Insert(ItemCompra itemCompra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._itens.Add(itemCompra);
            return itemCompra;
        }

        public ItemCompra Update(ItemCompra itemCompra)
        {
            this._itens[this._itens.IndexOf(itemCompra)] = itemCompra;
            return itemCompra;
        }

        public void Remove(ItemCompra itemCompra)
        {
            this._itens.Remove(itemCompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return _itens;
        }

        public IList<ItemCompra> getAll()
        {
            return _itens;
        }

        public IList<ItemCompra> getItemsCompraPorCompraId(int id)
        {
            return _itens.Where(item => item.Compra.Id == id).ToList();
        }
        public IList<ItemCompra> getItemsCompraPorProdutoId(int id)
        {
            return _itens.Where(item => item.Produto.Id == id).ToList();
        }
    }
}
