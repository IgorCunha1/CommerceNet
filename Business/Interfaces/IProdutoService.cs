using Data.ViewModel.Produto;

namespace Business.Interfaces
{
    public interface IProdutoService
    {
        Task InserirProduto(CadastroProdutoViewModel ProdutoViewModel);
        Task EditarProduto(EditarProdutoViewModel ProdutoViewModel);
        Task<IList<ProdutoViewModel>> ObterProdutos();
        Task<ProdutoViewModel?> ObterProdutoPorId(int id);
        Task DeletarProduto(int id);
    }
}
