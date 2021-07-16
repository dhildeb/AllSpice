using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AllSpice.Models;
using Dapper;

namespace AllSpice.Repositories
{
  class RecipesRepository
  {
    private readonly IDbConnection _db;
    public RecipesRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Recipe> GetRecipes()
    {
      var sql = "SELECT * recipes;";
      return _db.Query<Recipe>(sql).ToList();
    }

    public Recipe GetRecipeById(int id)
    {
      var sql = "SELECT * recipes WHERE id = @id;";
      return _db.QueryFirstOrDefault(sql, new { id });
    }

    public int CreateRecipe(Recipe recipeData)
    {
      var sql = @"
      INSERT INTO recipes
      (title, description, imgUrl, steps, ingedients, creator, creatorId)
      VALUES
      (@title, @description, @imgUrl, @steps, @ingedients, @creator, @creatorId);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, recipeData);
    }

    public int UpdateRecipe(Recipe recipe)
    {
      var sql = @"
      UPDATE recipe 
      SET title = @title,
      description = @description,
      imgUrl = @imgUrl,
      steps = @steps,
      ingredients = @ingredients,
      creator = @creator,
      creatorId = @creatorId
      WHERE id = @id;
      ";
      return _db.Execute(sql, recipe);
    }

    public int DeleteRecipe(int id)
    {
      var sql = "DELETE recipe WHERE id = @id;";
      return _db.Execute(sql, new { id });
    }
  }
}