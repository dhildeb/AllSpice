using System.Collections.Generic;
using AllSpice.Models;
using AllSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  class RecipesController : ControllerBase
  {
    private readonly RecipesService _ks;
    public RecipesController(RecipesService ks)
    {
      _ks = ks;
    }

    [HttpGet]
    public ActionResult<List<Recipe>> GetRecipes()
    {
      try
      {
        return _ks.GetRecipes();
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Recipe> GetRecipeById(int id)
    {
      try
      {
        return _ks.GetRecipeById(id);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Recipe> CreateRecipe([FromBody] Recipe recipeData)
    {
      try
      {
        return _ks.CreateRecipe(recipeData);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Recipe> UpdateRecipe([FromBody] Recipe recipeData, int id)
    {
      try
      {
        return _ks.UpdateRecipe(recipeData, id);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteRecipe(int id)
    {
      try
      {
        return _ks.DeleteRecipe(id);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}