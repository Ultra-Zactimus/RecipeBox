using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }

    public int RecipeId { get; set; }
    public int Rating { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public List<Type> Types { get; set; }
    public virtual ICollection<RecipeTag> JoinEntities { get; set; }

  }

  public enum RecipeType
  {
    Vegan,
    Vegetarian,
    Pescatarian,
    Paleo,
    GlutenFree,
    Omnivorous,
    NoneOfTheAbove
  }
}