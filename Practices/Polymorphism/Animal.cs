using Practices.Polymorphism;

namespace Practices.Polymorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}


public class Cat : Animal
{
    // Override the base class method
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}
