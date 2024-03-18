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
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Ativo);
            builder.Property(x => x.Descricao);
            builder.Property(x => x.PrecoCompra);
            builder.Property(x => x.PrecoVenda);
            builder.Property(x => x.Quantidade).HasDefaultValue(0);
            builder.Property(x => x.Img);
            builder.Property(x => x.Categoria);
            builder.Property(x => x.DataAtualizacao).IsRequired(false);

            builder.Property(x => x.DataCriacao);
            
                        
        }
    }
}
