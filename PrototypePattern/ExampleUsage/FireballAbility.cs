namespace DesignPattern.Creational.PrototypePattern.ExampleUsage
{
    public class FireballAbility : BaseAbility
    {
        public int FireDamage { get; set; }

        public FireballAbility(string name, int manaCost, int fireDamage) 
            : base(name, manaCost)
        {
            FireDamage = fireDamage;
        }

        public override IAbilityPrototype Clone()
        {
            var clone = (FireballAbility)this.MemberwiseClone();
            clone.FireDamage = this.FireDamage;
            return clone;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Fire Damage: {FireDamage}";
        }
    }
}