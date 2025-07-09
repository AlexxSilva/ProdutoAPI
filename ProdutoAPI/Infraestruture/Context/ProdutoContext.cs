using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Domain.Models;

namespace ProdutoAPI.Infraestruture.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
            
        }
    }
}
