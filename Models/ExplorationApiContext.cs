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
      builder.Entity<Place>() // Place ID is linked to Place (eg: name) review ID is incrementing on # of reviews for a place?
      .HasData(
        new Place { PlaceId = 1, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 2, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 3, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 4, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 5, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 6, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 7, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 8, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 9, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 10, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 11, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 12, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 13, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 14, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 15, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 16, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 17, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 18, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 19, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 20, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 21, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 22, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 23, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 24, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 25, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 26, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 27, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 28, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 29, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 30, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 31, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 32, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 33, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 34, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 35, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 36, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 37, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 38, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 39, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 40, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 41, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 42, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 43, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 44, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"},
        new Place { PlaceId = 45, Name = "Puerta Vallarta", UserName = "Brittany", Rating = 5, Description = "A warm sunny town with lots of good food carts and food fresh from the ocean.", Country = "Mexico" },
        new Place { PlaceId = 46, Name = "Yachats", UserName = "Brittany", Rating = 4, Description = "A little town on the Oregon coast with beautiful views of the ocean and one brewery.", Country = "USA" },
        new Place { PlaceId = 47, Name = "Timothy Lake", UserName = "Kate", Rating = 2, Description = "Not that scenic and way too crowded to enjoy, unless you have a boat or some other watercraft.", Country = "USA" },
        new Place { PlaceId = 48, Name = "Puerta Vallarta", UserName = "Kate", Rating = 1, Description = "There was a hurricane! Was there for a wedding that had to be postponed.", Country = "Mexico" },
        new Place { PlaceId = 49, Name = "La Palud sur Verdon", UserName = "Kate", Rating = 5, Description = "A beautiful little town outside of Gorges du Verdon. Great views and restaurants.", Country = "France" },
        new Place { PlaceId = 50, Name = "Matsue", UserName = "Brittany", Rating = 5, Description = "Town that has a famous fireworks show every summer, cute local shops and traditional Ryokan", Country = "Japan"},
        new Place { PlaceId = 51, Name = "Atlantis", UserName = "Cody", Rating = 1, Description = "Came expecting mystical underwater city, got some theme park, refund was not approved.", Country = "Idk hawaii?"}
      );
    }
  }
}