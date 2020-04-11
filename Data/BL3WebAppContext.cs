using Microsoft.EntityFrameworkCore;

namespace BL3WebApp.Data
{
    public class BL3WebAppContext : DbContext
    {
        public BL3WebAppContext (
            DbContextOptions<BL3WebAppContext> options)
            : base(options)
        {

        }

        public DbSet<BL3WebApp.Models.Item> Item { get; set; }
    }
}