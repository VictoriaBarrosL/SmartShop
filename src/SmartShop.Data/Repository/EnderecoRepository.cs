using Microsoft.EntityFrameworkCore;
using SmartShop.Business.Interfaces;
using SmartShop.Business.Models;
using SmartShop.Data.Context;

namespace SmartShop.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(SmartShopDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
