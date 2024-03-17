using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class CommerceDb : DbContext
    {
        public CommerceDb(DbContextOptions<CommerceDb> options) : base(options) { }


    }
}
