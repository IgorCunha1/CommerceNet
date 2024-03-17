namespace Data.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public double Quantidade { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
    }
}
