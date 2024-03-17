using Data.Data.Mapping;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class CommerceDb : DbContext
    {
        public CommerceDb(DbContextOptions<CommerceDb> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
