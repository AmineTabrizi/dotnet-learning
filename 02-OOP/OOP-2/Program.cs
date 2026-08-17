var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozzarella());
// pizaa.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza.Describe());




public class Pizza
{
    private List<Ingredient> _ingredient = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredient.Add(ingredient);

    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredient)}";
    
}

public class Ingredient
{
    public virtual string Name {get; } = "Some Ingredient";
    
    
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}
public class Chesse : Ingredient
{
    
}
public class Cheddar : Chesse
{
    public override string Name => "Cheddar cheese";

    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public class Mozzarella : Chesse
{
    public override string Name => "Mozzarella";

    public bool IsLight {get; }
}