using ProdutoAPI.Domain.Models;

namespace ProdutoAPI.Events
{
    public class ProdutoCriadoEventArgs : EventArgs
    {
        public Produto produto { get; set; }
    }
}
