using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Domain.Models;
using ProdutoAPI.Infraestruture.Context;
using System.ComponentModel.DataAnnotations;

namespace ProdutoAPI.Infraestruture.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext produtoContext;

        public ProdutoRepository(ProdutoContext _produtoContext)
        {
            this.produtoContext = _produtoContext;
        }

        public async Task<Produto?> CriarAsync(Produto produto)
        {
            try
            {
                produtoContext.Produtos.Add(produto);
                return await produtoContext.SaveChangesAsync() > 0 ? produto! : null;
            }
            catch (Exception ex) when (ex is DbUpdateException || ex is ValidationException)
            {
                Console.WriteLine($"Erro ao salvar o produto: {ex.Message}");
                Console.WriteLine($"Detalhes internos: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            return null;
        }

        public async Task<List<Produto>> ListarAsync()
        {
            return await produtoContext.Produtos.ToListAsync();
        }
    }
}
