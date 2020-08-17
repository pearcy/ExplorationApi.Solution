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

  }
}