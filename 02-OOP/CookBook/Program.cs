var cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(), new RecipesConsoleUserInteraction());
cookiesRecipesApp.Run();

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;
    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction )
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);
        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();
        if(ingredients.Count > 0)
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

public interface IRecipesRepository
{
    
}
public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

}

public class RecipesRepository : IRecipesRepository
{
}

// Console.WriteLine(@"Create a new Cookie recipe! Available ingredients are:
// 1. Wheat flour
// 2. Coconut flour
// 3. Butter
// 4. Chocolate
// 5. Sugar
// 6. Cardamom
// 7. Cinnamon
// 8. Cocoa powder
// Add an ingredient by it's Id or type anything else if finished.");
// var userItems = Console.ReadLine();

