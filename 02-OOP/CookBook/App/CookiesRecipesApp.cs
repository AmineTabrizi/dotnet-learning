using CookBook.Recipes;

namespace CookBook.App;

public class CookiesRecipesApp
{
private readonly IRecipesRepository _recipesRepository;
private readonly IRecipesUserInteraction _recipesUserInteraction;
public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction )
{
    _recipesRepository = recipesRepository;
    _recipesUserInteraction = recipesUserInteraction;
}

public void Run(string filePath)
{
    var allRecipes = _recipesRepository.Read(filePath);
    _recipesUserInteraction.PrintExistingRecipes(allRecipes);
    _recipesUserInteraction.PromptToCreateRecipe();

    var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();
    if(ingredients.Count() > 0)
    {
        var recipes = new Recipe(ingredients);
        allRecipes.Add(recipes);
        _recipesRepository.Write(filePath, allRecipes);

        _recipesUserInteraction.ShowMessage("Recipe added: ");
        _recipesUserInteraction.ShowMessage(recipes.ToString());
    }
    else
    {
        _recipesUserInteraction.ShowMessage("No Ingredients have been selected." + "Recipe won't be saved!");
    }

    _recipesUserInteraction.Exit();
}
}



