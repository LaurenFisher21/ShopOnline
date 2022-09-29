using Microsoft.EntityFrameworkCore;

namespace ShopOnline.Data
{
    public class CakeFactoryContext : DbContext
    {
        public CakeFactoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cakes> Cakeses {get; set;}
        public DbSet<CakeTypes> CakeTypeses {get; set;}
    }
}