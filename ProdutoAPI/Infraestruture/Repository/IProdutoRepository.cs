using ProdutoAPI.Domain.Models;

namespace ProdutoAPI.Infraestruture.Repository
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> ListarAsync();
        Task<Produto?> CriarAsync(Produto produto);
    }
}
