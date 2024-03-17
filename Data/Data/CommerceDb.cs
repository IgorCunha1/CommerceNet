using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class CommerceDb : DbContext
    {
        public CommerceDb(DbContextOptions<CommerceDb> options) : base(options) { }

        public DbSet<Produto> Produtos {get;set;}
}
}
