using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public int? Id { get; set; }
        public TipoPessoa TipoFornecedor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Produto Produto { get; set; }
        public Documento Documento { get; set; }
        public string RazaoSocial { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(int? id, TipoPessoa tipofornecedor, string nome, string email, Produto produto, Documento documento, string razaosocial, string rua, string numero, string bairro, string cidade, string complemento, string cep, string telefone, string celular)
        {
            Id = id;
            this.TipoFornecedor = tipofornecedor;
            Nome = nome;
            Email = email;
            Produto = produto;
            this.Documento = documento;
            RazaoSocial = razaosocial;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Complemento = complemento;
            CEP = cep;
            Telefone = telefone;
            Celular = celular;
        }

        public override bool Equals(object obj)
        {
            return obj is Fornecedor fornecedor &&
                   Id == fornecedor.Id &&
                   TipoFornecedor == fornecedor.TipoFornecedor &&
                   Nome == fornecedor.Nome &&
                   Email == fornecedor.Email &&
                   Produto == fornecedor.Produto &&
                   Documento == fornecedor.Documento &&
                   RazaoSocial == fornecedor.RazaoSocial &&
                   Rua == fornecedor.Rua &&
                   Numero == fornecedor.Numero &&
                   Bairro == fornecedor.Bairro &&
                   Cidade == fornecedor.Cidade &&
                   Complemento == fornecedor.Complemento &&
                   CEP == fornecedor.CEP &&
                   Telefone == fornecedor.Telefone &&
                   Celular == fornecedor.Celular;
        }

        public override int GetHashCode()
        {
            int hashCode = -1601931259;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + TipoFornecedor.GetHashCode();
            hashCode = hashCode * -1521134295 + Produto.GetHashCode();
            hashCode = hashCode * -1521134295 + Documento.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RazaoSocial);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Rua);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Numero);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CEP);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Celular);
            return hashCode;
        }
    }
}
