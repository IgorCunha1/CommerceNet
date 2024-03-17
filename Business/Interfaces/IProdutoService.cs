using Data.ViewModel.Produto;

namespace Business.Interfaces
{
    public interface IProdutoService
    {
        Task InserirProdutos(CadastroProdutoViewModel ProdutoViewModel);
        Task EditarProdutos(CadastroProdutoViewModel ProdutoViewModel);
        Task<IEnumerable<ProdutoViewModel>> ObterProdutos();
        Task<ProdutoViewModel> ObterProdutoPorId(int id);
    }
}
