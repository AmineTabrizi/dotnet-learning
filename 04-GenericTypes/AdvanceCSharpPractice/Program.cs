using System.Numerics;

void SomeMethod<Tpet, TOwner>(Tpet pet, TOwner owner) where Tpet : Pet, IComparable<Tpet> where TOwner : new()
{
    
}


public class Pet{ }
public class PetOwner{ }

// public static class Calculator
// {
//     public static T Square<T>(T input) where T : INumber<T> => input * input;
// }