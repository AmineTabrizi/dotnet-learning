namespace Utilities;


public class PublicClass
{
    // public InternalClass InternalClass {get;}
    private InternalClass _internalClass;

    public int SomeMethod()
    {
        var someMethod = new InternalClass();
        return 0;
    }

    protected internal void ProtectedInternal(){ }
    private protected void PrivateProtected(){ }
}

internal class DerivedFromPublicClass : PublicClass
{
    void Test()
    {
        
        PrivateProtected();

    }
}

internal class InternalClass
{
    public static void SomeMethod()
    {
        new PublicClass().ProtectedInternal();
    }
}
file class AccesibleOnlyInThisFile
{
    
}