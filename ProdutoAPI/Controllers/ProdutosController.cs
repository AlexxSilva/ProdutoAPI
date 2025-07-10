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
        private readonly IProdutoService _service;
        private readonly IEmailService _emailService;

        public ProdutosController(IProdutoService service, IEmailService emailService)
        {
            _service = service;
            _emailService = emailService;

            _service.ProdutoCriado += (sender, args) =>
             {
                 _emailService.Enviar(para: "destinatario.com.br",
                     assunto: "Novo Produto Criado",
                     corpo: $"Produto Criado:{args.produto.Nome}");

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
