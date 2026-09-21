using Utilities;

var derived = new DerivedFromPublicClass();
derived.Test();

Console.WriteLine("Done!");

public class DerivedFromPublicClass : PublicClass
{
    public void Test()
    {
        ProtectedInternal();
        // PrivateInternal();
    }
}