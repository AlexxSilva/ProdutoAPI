using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Application;
using ProdutoAPI.Domain.Models;
using ProdutoAPI.Events;

namespace ProdutoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _service;

        public ProdutosController(ProdutoService service)
        {
            _service = service;

            _service.ProdutoCriado += (sender, args) =>
             {
                 Console.WriteLine($"Produto criado: {args.produto.Nome}");
             };
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _service.ListarAsync();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            var criado = await _service.CriarAsync(produto);
            return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
        }

    }
}
