// var pizza = new Pizza();
// pizza.AddIngredient(new Cheddar());
// pizza.AddIngredient(new Mozzarella());
// pizza.AddIngredient(new TomatoSauce());

// Console.WriteLine(pizza.ToString());

var ingredient = new Ingredient(1);
var cheddar = new Cheddar(2, 12);




public class Pizza
{
    private List<Ingredient> _ingredient = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredient.Add(ingredient);

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredient)}";
    
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping){
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping {get; }
    public virtual string Name {get; } = "Some Ingredient";
    
    
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}
public class Chesse : Ingredient
{
    public Chesse(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}
public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping){
        Console.WriteLine("Constructor from the Cheddar class");
        AgedForMonths = agedForMonths;
    }
    public override string Name => $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths} months.";

    public int AgedForMonths {get; }
    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public class Mozzarella : Chesse
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";

    public bool IsLight {get; }
}