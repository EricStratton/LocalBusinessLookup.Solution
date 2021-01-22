using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContext : DbContext
  {
    public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options)
        : base(options)
    {
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Resturant> Resturants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Shop>()
          .HasData(
            new Shop { ShopId = 1, Name = "Ricc's Records", StreetAddress = "123 Groovy Way", KeyBusiness = "Record Shop"},
            new Shop { ShopId = 2, Name = "Aubrey's Amps & LoudSpeakers", StreetAddress = "666 Industry Ave", KeyBusiness = "Professional Audio"},
            new Shop { ShopId = 3, Name = "Les Fluers", StreetAddress = "1300 Rue St Jean", KeyBusiness = "Plant Shop"},
            new Shop { ShopId = 4, Name = "Auntie A's Antiques", StreetAddress = "44 Junk St", KeyBusiness = "Antiques"},
            new Shop { ShopId = 5, Name = "General Store", StreetAddress = "15 Old Town Ave", KeyBusiness = "Convenience Store"}
          );

      builder.Entity<Resturant>()
          .HasData(
            new Resturant { ResturantId = 1, Name = "24hr Kabab", StreetAddress = "151 High St", KeyBusiness = "Late night bites"},
            new Resturant { ResturantId = 2, Name = "Maria's Cantina", StreetAddress = "132 High St", KeyBusiness = "Casual drinks & street food"},
            new Resturant { ResturantId = 3, Name = "Pastini Ristorante", StreetAddress = "222 Old Town Ave", KeyBusiness = "Italian dining"},
            new Resturant { ResturantId = 4, Name = "O'Leary's Pub", StreetAddress = "100 High St", KeyBusiness = "Beer on tap & pub food"},
            new Resturant { ResturantId = 5, Name = "Pierre's Bon Cuisine", StreetAddress = "1310 Rue St Jean", KeyBusiness = "French cuisine"}
          );
    }

  }
}