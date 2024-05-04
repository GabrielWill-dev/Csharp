using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagarRepository
    {
        private IList<ContaPagar> _contasPagar = new List<ContaPagar>();

        public ContaPagar Insert(ContaPagar contaPagar)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contasPagar.Add(contaPagar);
            return contaPagar;
        }

        public ContaPagar Update(ContaPagar contaPagar)
        {
            this._contasPagar[this._contasPagar.IndexOf(contaPagar)] = contaPagar;
            return contaPagar;
        }

        public void Remove(ContaPagar contaPagar)
        {
            this._contasPagar.Remove(contaPagar);
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return _contasPagar;
        }

        public IList<ContaPagar> getAll()
        {
            return _contasPagar;
        }

        public IList<ContaPagar> getContasPagarPorFornecedorId(int id)
        {
            return _contasPagar.Where(v => v.Compra.Id == id).ToList();
        }
    }
}
