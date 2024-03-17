using Business.Interfaces;
using Data.Data;
using Data.Model;
using Data.ViewModel.Produto;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Business.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly CommerceDb _context;

        public ProdutoService(CommerceDb context)
        {
            _context = context;
        }

        public async Task InserirProdutos(CadastroProdutoViewModel ProdutoViewModel)
        {
            _context.Produtos.Add(new Produto
            {
                Categoria = ProdutoViewModel.Categoria,
                Quantidade = 0,
                Img = ProdutoViewModel.Img,
                Descricao = ProdutoViewModel.Descricao,
                PrecoCompra = ProdutoViewModel.PrecoCompra,
                PrecoVenda = ProdutoViewModel.PrecoVenda,
            });
            
            await _context.SaveChangesAsync();
        }

        public async Task EditarProdutos(EditarProdutoViewModel ProdutoViewModel)
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == ProdutoViewModel.Id);

            if(produto is null)
                throw new NullReferenceException("Produto não encontrado");

            produto.PrecoVenda = ProdutoViewModel.PrecoVenda;
            produto.PrecoCompra = ProdutoViewModel.PrecoCompra;
            produto.Categoria = ProdutoViewModel.Categoria;
            produto.Img = ProdutoViewModel.Img;
            produto.Descricao = ProdutoViewModel.Descricao;
                        
        }

        public async Task<ProdutoViewModel?> ObterProdutoPorId(int id)
        {
            var produto = await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null)
                return null;

            return new ProdutoViewModel
            {
                Categoria = produto.Categoria,
                Img = produto.Img,
                Descricao = produto.Descricao,
                PrecoCompra = produto.PrecoCompra,
                PrecoVenda = produto.PrecoVenda,
                Quantidade = produto.Quantidade
            };
        }

        public async Task<IList<ProdutoViewModel>> ObterProdutos()
        {
            return await _context.Produtos.AsNoTracking()
                .Select(x => new ProdutoViewModel
                {
                    Descricao = x.Descricao,
                    Categoria = x.Categoria,
                    Img = x.Img,
                    PrecoCompra = x.PrecoCompra,
                    PrecoVenda = x.PrecoVenda,
                    Quantidade = x.Quantidade
                }).ToListAsync();
        }
    }
}
