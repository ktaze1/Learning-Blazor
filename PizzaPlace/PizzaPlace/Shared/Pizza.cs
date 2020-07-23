using System;

namespace PizzaPlace.Shared
{
  public enum Spiciness
  {
    None,
    Spicy,
    Hot
  }

  public class Pizza
  {
    public Pizza() { } //default constructor

    public Pizza(int id, string name, decimal price, 
                 Spiciness spiciness)
    {
      Id = id;
      Name = name
        ?? throw new ArgumentNullException(nameof(name),
           "A pizza needs a name!");
      Price = price;
      Spiciness = spiciness;
    }

    //read and write
    public int Id { get; set; }
    public string Name { get; set;  }
    public decimal Price { get; set; }
    public Spiciness Spiciness { get; set; }
  }
}
