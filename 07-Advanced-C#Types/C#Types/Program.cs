using Utilities;

public class DerivedFromPublicClass : PublicClass
{
    public void Test()
    {
        ProtectedInternal();
        PrivateProtected();
    }
}