using CookBook.Recipes.Ingredients;

namespace CookBook.Recipes;

public interface IIngredientsRegister
{
IEnumerable<Ingredient> All { get; }

Ingredient GetById(int id);
}
