using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CompraRepository
    {
        private IList<Compra> _compras = new List<Compra>();

        public Compra Insert(Compra compra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._compras.Add(compra);
            return compra;
        }

        public Compra Update(Compra compra)
        {
            this._compras[this._compras.IndexOf(compra)] = compra;
            return compra;
        }

        public void Remove(Compra compra)
        {
            this._compras.Remove(compra);
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return _compras;
        }

        public IList<Compra> getAll()
        {
            return _compras;
        }

        public IList<Compra> getComprasPorFornecedorId(int id)
        {
            return _compras.Where(v => v.Fornecedor.Id == id).ToList();
        }
    }
}
