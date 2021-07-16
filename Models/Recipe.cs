using System.Collections.Generic;

namespace AllSpice.Models
{
  class Recipe
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public List<Steps> Steps { get; set; }
    public List<Ingredients> Ingredients { get; set; }
    public string Creator { get; set; }
    public int CreatorId { get; set; }
    public int Id { get; set; }

  }
}