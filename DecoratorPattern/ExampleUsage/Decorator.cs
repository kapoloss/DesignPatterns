using System;

namespace DesignPattern.Structural.DecoratorPattern.ExampleUsage;

//Decorator
public abstract class SkillDecorator : Skill
{
    protected Skill _skill;

    public SkillDecorator(Skill skill)
    {
        _skill = skill;
    }

    public override void Cast()
    {
        _skill.Cast();
    }
}

//ConcreteDecorator

public class ExplosiveSkillDecorator : SkillDecorator
{
    public ExplosiveSkillDecorator(Skill skill) : base(skill) { }

    public override void Cast()
    {
        base.Cast();
        Console.WriteLine("Explosion added! Deals area damage.");
    }
}

public class PoisonSkillDecorator : SkillDecorator
{
    public PoisonSkillDecorator(Skill skill) : base(skill) { }

    public override void Cast()
    {
        base.Cast();
        Console.WriteLine("Poison added! Deals damage over time.");
    }
}

public class HomingSkillDecorator : SkillDecorator
{
    public HomingSkillDecorator(Skill skill) : base(skill) { }

    public override void Cast()
    {
        base.Cast();
        Console.WriteLine("Homing ability added! Targets enemies automatically.");
    }
}