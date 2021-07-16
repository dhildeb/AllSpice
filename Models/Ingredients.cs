using System.ComponentModel.DataAnnotations;

namespace AllSpice.Models
{
  class Ingredients
  {
    public string Name { get; set; }
    public int Quantity { get; set; }

    [Required]
    public int RecipeId { get; set; }

  }
}