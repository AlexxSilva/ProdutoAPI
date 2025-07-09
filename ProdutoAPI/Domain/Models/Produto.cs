using System.ComponentModel.DataAnnotations;

namespace ProdutoAPI.Domain.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get ; set; } = string.Empty;
        public double Quantidade { get; set; }

    }
}
