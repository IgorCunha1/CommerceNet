using Data.ViewModel.Produto;

namespace Business.Interfaces
{
    public interface IProdutoService
    {
        Task InserirProdutos(CadastroProdutoViewModel ProdutoViewModel);
        Task EditarProdutos(EditarProdutoViewModel ProdutoViewModel);
        Task<IList<ProdutoViewModel>> ObterProdutos();
        Task<ProdutoViewModel?> ObterProdutoPorId(int id);
    }
}
