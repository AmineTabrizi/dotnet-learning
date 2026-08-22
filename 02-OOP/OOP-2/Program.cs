using Polymorphism.Extensions;

var cheddar = new Cheddar(2, 12);
var tomatoSauce = new TomatoSauce(1);
cheddar.Prepare();
tomatoSauce.Prepare();

Console.WriteLine("Next Season after Spring: " + Season.Spring.Next());
Console.WriteLine("Next Season after winter: " + Season.Winter.Next());


if (cheddar is not null)
{
    Console.WriteLine(cheddar.Name);
}
else
{
    Console.WriteLine("Conversation failed.");
}

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    if (number == 1 || number == 2) {return new Cheddar(2, 12); }
    else return new Mozzarella(2);
}
public class Pizza
{
    public int number;
    public DateTime date;
    private List<Ingredient> _ingredient = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredient.Add(ingredient);

    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredient)}";
    
}

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping){
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping {get; }

    public override string ToString() => Name;
    public virtual string Name {get; } = "Some Ingredient";

    public abstract void Prepare();
    
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class";
}
public abstract class Chesse : Ingredient
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

    public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza");

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

    public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza.");
}   

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams {get; }

    public override void Prepare() => Console.WriteLine("Cook tomatoes with basil, garlic and salt." + "Spread on pizza.");
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}