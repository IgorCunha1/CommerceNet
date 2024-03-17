namespace Data.Model
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; }
    }
}
