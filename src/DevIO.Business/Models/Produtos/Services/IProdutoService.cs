using System;
using System.Threading.Tasks;

namespace ChiavelliDev.Business.Models.Produtos.Services
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}