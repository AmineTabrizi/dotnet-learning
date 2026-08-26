using CookBook.Recipes;
using CookBook.Recipes.Ingredients;

var cookiesRecipesApp = new CookiesRecipesApp(new RecipesRepository(new StringsTextualRepository()), new RecipesConsoleUserInteraction(new IngredientsRegister()));
cookiesRecipesApp.Run("recipes.txt");

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

public interface IRecipesRepository
{
    List<Recipe> Read(object filePath);
    void Write(string filePath, List<Recipe> allRecipes);
}
public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
public class IngredientsRegister
{
    public IEnumerable<Ingredient> All {get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };

    public Ingredient GetById(int id)
    {
        foreach(var ingredient in All)
        {
            if(ingredient.Id == id)
            {
                return ingredient;
            }
        }
        return null;
    }
}
public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IngredientsRegister _ingredientRegister;

    public RecipesConsoleUserInteraction(IngredientsRegister ingredientsRegister)
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
            var counter = 1;
            foreach(var recipe in allRecipes)
            {
                Console.WriteLine($"*****{counter}*****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                counter++;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " + "Available ingredients are: ");

        foreach(var ingredient in _ingredientRegister.All)
        {
            Console.WriteLine(ingredient);
        }
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

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringRepository;

    public RecipesRepository(IStringsRepository stringRepository)
    {
        _stringRepository = stringRepository;
    }

    public List<Recipe> Read(object filePath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar(),
            }),
            new Recipe(new List<Ingredient>{
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon()
            })
        };
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach(var recipe in allRecipes)
        {
            var allIds = new List<int>();
            foreach(var ingredient in recipe.Ingredients)
            {
                allIds.Add(ingredient.Id);
            }
            recipesAsStrings.Add(string.Join(",", allIds));
        }
        _stringRepository.Write(filePath, recipesAsStrings);
    }
}

public interface IStringsRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> strings);
}

public class StringsTextualRepository : IStringsRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
    }
    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, string.Join(Separator, strings));
    }
}
