using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorRepository
    {
        private IList<Fornecedor> _fornecedores = new List<Fornecedor>();

        public Fornecedor Insert(Fornecedor fornecedor)
        {
            // Aqui você poderia inserir o Fornecedor em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            this._fornecedores[this._fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }

        public void Remove(Fornecedor fornecedor)
        {
            this._fornecedores.Remove(fornecedor);
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _fornecedores;
        }

        public IList<Fornecedor> GetAll()
        {
            return _fornecedores;
        }
    }
}
