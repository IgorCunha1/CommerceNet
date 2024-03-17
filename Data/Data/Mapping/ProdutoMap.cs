using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao);

            builder.Property(x => x.PrecoCompra);
            builder.Property(x => x.PrecoVenda);
            builder.Property(x => x.Quantidade);
            builder.Property(x => x.Img);

            builder.Property(x => x.Categoria);
                        
        }
    }
}
