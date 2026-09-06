using CookBook.Recipes;
using CookBook.Recipes.Ingredients;
using Microsoft.VisualBasic;

namespace CookBook.App;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
private readonly IIngredientsRegister _ingredientRegister;
    private IngredientsRegister ingredientsRegister;

    public RecipesConsoleUserInteraction(IIngredientsRegister ingredientsRegister)
    {
        _ingredientRegister = ingredientsRegister;
    }

    public void ShowMessage(string message)
{
    Console.WriteLine(message);
}
public void Exit()
{
    Console.WriteLine("Press any key to close.");
    Console.ReadKey();
}

public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
{
    if (allRecipes.Count() > 0)
    {
        Console.WriteLine("Existing recipes are: " + Environment.NewLine);
        var allRecipesAsStrings = allRecipes
        .Select((recipe, index) =>
$@"*****{index + 1}*****
{recipe}");
        Console.WriteLine(string.Join(Environment.NewLine, allRecipesAsStrings));
        Console.WriteLine();
    }
}

public void PromptToCreateRecipe()
{
    Console.WriteLine("Create a new cookie recipe! " + "Available ingredients are: ");
    
    Console.WriteLine(string.Join(Environment.NewLine, _ingredientRegister.All));
}

public IEnumerable<Ingredient> ReadIngredientsFromUser()
{
    bool shallStop = false;
    var ingredients = new List<Ingredient>();

    while (!shallStop)
    {
        Console.WriteLine("Add an ingredient by its ID, " + "or type anything else if finished.");

        var userInput = Console.ReadLine();

        if(int.TryParse(userInput, out int id))
        {
            var selectedIngredient = _ingredientRegister.GetById(id);
            if(selectedIngredient is not null)
            {
                ingredients.Add(selectedIngredient);
            }
        }
        else
        {
            shallStop = true;
        }
    }


    return ingredients;
}
}
