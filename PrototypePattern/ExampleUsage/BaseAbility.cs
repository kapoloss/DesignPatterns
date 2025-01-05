namespace DesignPattern.Creational.PrototypePattern.ExampleUsage
{
    public class BaseAbility : IAbilityPrototype
    {
        public string Name { get; set; }
        public int ManaCost { get; set; }

        public BaseAbility(string name, int manaCost)
        {
            Name = name;
            ManaCost = manaCost;
        }

        public virtual IAbilityPrototype Clone()
        {
            return (IAbilityPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Ability: {Name}, Mana Cost: {ManaCost}";
        }
    }
}