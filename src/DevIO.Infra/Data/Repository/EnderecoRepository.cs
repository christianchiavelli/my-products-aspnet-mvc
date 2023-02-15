using ChiavelliDev.Business.Models.Fornecedores;
using ChiavelliDev.Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace ChiavelliDev.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}