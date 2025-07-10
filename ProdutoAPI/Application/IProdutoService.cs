using ProdutoAPI.Domain.Models;
using ProdutoAPI.Events;

namespace ProdutoAPI.Application
{
    public interface IProdutoService
    {
        public event EventHandler<ProdutoCriadoEventArgs> ProdutoCriado;
        public  Task<Produto?> CriarAsync(Produto produto);
        public  Task<List<Produto>> ListarAsync();
    }
}
