using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Dal
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        :base(options)
        {
            
        }
        public DbSet<Make> MAks  { get; set; }
    }
}       