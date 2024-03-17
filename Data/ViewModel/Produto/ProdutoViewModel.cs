namespace Data.ViewModel.Produto
{
    public class ProdutoViewModel
    {
        public string Nome { get; set; } = string.Empty;
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public double Quantidade { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
    }
}
