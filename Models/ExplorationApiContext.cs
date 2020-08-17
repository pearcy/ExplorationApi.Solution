using Microsoft.EntityFrameworkCore;

namespace ExplorationApi.Models
{
  public class ExplorationApiContext : DbContext
  {
    public ExplorationApiContext(DbContextOptions<ExplorationApiContext> options)
    : base(options)
    {

    }
    public DbSet<Place> Places {get;set;}
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
      .HasData(
        new Place { PlaceId = 1, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 2, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 3, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 4, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 5, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 6, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 7, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"}
        
      );
    }
  }
}