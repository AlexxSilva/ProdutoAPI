using ProdutoAPI.Domain.Models;
using ProdutoAPI.Events;
using ProdutoAPI.Infraestruture.Context;
using ProdutoAPI.Infraestruture.Repository;
using System;

namespace ProdutoAPI.Application
{
    public class ProdutoService
    {
        
        private readonly IProdutoRepository _produtoRepository;
        public event EventHandler<ProdutoCriadoEventArgs> ProdutoCriado;    
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;   
        }

        public async Task<Produto?> CriarAsync(Produto produto)
        {
            var produtoCriado = await _produtoRepository.CriarAsync(produto);

            if (produtoCriado != null)
            {

                ProdutoCriado.Invoke(this, new ProdutoCriadoEventArgs { produto = produto });
                return produtoCriado;
            }

            return null;
        }

        public async Task<List<Produto>> ListarAsync()
        {
            return await _produtoRepository.ListarAsync();
        }

    }
}
