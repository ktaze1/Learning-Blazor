using Microsoft.EntityFrameworkCore;
using PizzaPlace.Shared;

namespace PizzaPlace.Server
{
  public class PizzaPlaceDbContext : DbContext // representaiton in database
  {
    public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) //constructor for making a connection
      : base(options) { }

    public DbSet<Pizza> Pizzas { get; set; } // add table to database
        // DbSet is like List<>

    protected override void OnModelCreating(ModelBuilder modelBuilder) //describe the tables
    {
      base.OnModelCreating(modelBuilder);

      var pizzaEntity = modelBuilder.Entity<Pizza>();

      pizzaEntity.HasKey(pizza => pizza.Id);
      pizzaEntity.Property(pizza => pizza.Price)
        .HasColumnType("money");
    }
  }
}
