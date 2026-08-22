namespace Polymorphism.Flyables
{
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public void Tweet() => Console.WriteLine("Tweer, tweer!");

        public void Fly() => Console.WriteLine("Flying using its wings.");
    }

    public class Kite : IFlyable
    {
        public void Fly() => Console.WriteLine("Flying carried by the wind.");
    }
    public class Plane : IFlyable
    {
        public void Fly() => Console.WriteLine("Flying using jet propulsion");
        
    }
}