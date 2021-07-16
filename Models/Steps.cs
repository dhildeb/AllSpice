using System.ComponentModel.DataAnnotations;

namespace AllSpice.Models
{
  class Steps
  {
    public string Step { get; set; }
    public int Index { get; set; }

    [Required]
    public int RecipeId { get; set; }
  }
}