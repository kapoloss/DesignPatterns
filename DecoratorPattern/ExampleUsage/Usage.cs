namespace DesignPattern.Structural.DecoratorPattern.ExampleUsage;

public class Usage
{
    public void Method()
    {
        Skill basicFireball = new Fireball(); 

        Skill explosivePoisonFireball = new ExplosiveSkillDecorator(
            new PoisonSkillDecorator(basicFireball)
        );

        explosivePoisonFireball.Cast();

        Skill ultimateFireball = new HomingSkillDecorator(explosivePoisonFireball);

        ultimateFireball.Cast();
    }
}

//     Fireball casted! Deals damage to a single target.
//     Poison added! Deals damage over time.
//     Explosion added! Deals area damage.
//
//     Fireball casted! Deals damage to a single target.
//     Poison added! Deals damage over time.
//     Explosion added! Deals area damage.
//     Homing ability added! Targets enemies automatically.