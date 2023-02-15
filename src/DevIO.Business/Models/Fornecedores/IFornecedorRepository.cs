using ChiavelliDev.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace ChiavelliDev.Business.Models.Fornecedores
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}