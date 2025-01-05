using System;

namespace DesignPattern.Structural.DecoratorPattern.ExampleUsage;

//Component
public abstract class Skill
{
    public abstract void Cast(); 
}


//ConcreteComponent
public class Fireball : Skill
{
    public override void Cast()
    {
        Console.WriteLine("Fireball casted! Deals damage to a single target.");
    }
}