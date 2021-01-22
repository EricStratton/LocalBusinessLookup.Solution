using Microsoft.EntityFrameworkCore;

namespace LocalApi.Models
{
  public class LocalApiContext : DbContext
  {
    public LocalApiContext(DbContextOptions<LocalApiContext> options)
        : base(options)
    {
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Resturant> Resturants { get; set; }
  }
}