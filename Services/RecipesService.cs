using System;
using System.Collections.Generic;
using AllSpice.Models;
using AllSpice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Services
{
  class RecipesService
  {
    private readonly RecipesRepository _Rrepo;

    public RecipesService(RecipesRepository Rrepo)
    {
      _Rrepo = Rrepo;
    }

    public List<Recipe> GetRecipes()
    {
      return _Rrepo.GetRecipes();
    }

    public Recipe GetRecipeById(int id)
    {
      return _Rrepo.GetRecipeById(id);
    }

    public Recipe CreateRecipe(Recipe recipeData)
    {
      int id = _Rrepo.CreateRecipe(recipeData);
      recipeData.Id = id;
      return recipeData;
    }

    public Recipe UpdateRecipe(Recipe recipeData, int id)
    {
      var recipe = GetRecipeById(id);
      recipe.Id = id;
      var updated = _Rrepo.UpdateRecipe(recipe);
      if (updated > 0)
      {
        return recipe;
      }
      else
      {
        throw new Exception("Invalid Id");
      }
    }

    public string DeleteRecipe(int id)
    {
      var deleted = _Rrepo.DeleteRecipe(id);
      if (deleted > 0)
      {
        return "Successfully Deleted";
      }
      else
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}